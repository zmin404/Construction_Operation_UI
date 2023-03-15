using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ISOService_API;
using ISOServiceVO;
using DevExpress.XtraGrid.Views.Grid;

namespace ISOFormat.UIForm
{
    public partial class BuildingTypeForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        BuildingTypeVO selectedBuildingType;
        List<BuildingTypeVO> BuildingTypeList;

        public BuildingTypeForm(ISOIService s , UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedBuildingType = new BuildingTypeVO();
            this.BuildingTypeList = new List<BuildingTypeVO>();
        }

        private void ClearData()
        {
            this.selectedBuildingType = new BuildingTypeVO();
            txtBuildingType.Text = string.Empty;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtBuildingType.Focus();
        }

        private void BindingGrid()
        {
            BuildingTypeList = service.GetActiveBuildingType(true);
            BuildingTypeGridControl.DataSource = BuildingTypeList;
            BuildingTypeGridControl.RefreshDataSource();
        }

        private void BuildingTypeForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuildingType.Text))
                {
                    errorProvider1.SetError(txtBuildingType, "Please fill BuildingType Name!");
                    txtBuildingType.Focus();
                    return;
                }
                else if (BuildingTypeList != null)
                {
                    if (BuildingTypeList.Where(x => x.BuildingType == txtBuildingType.Text.Trim() && x.BuildingTypeID != selectedBuildingType.BuildingTypeID).Any())
                    {
                        txtBuildingType.Focus(); txtBuildingType.SelectAll();
                        throw new Exception("BuildingType Name is already exists!");
                    }
                }
                BuildingTypeVO BuildingTypeVO = new BuildingTypeVO();
                BuildingTypeVO.BuildingTypeID = selectedBuildingType.BuildingTypeID;
                BuildingTypeVO.BuildingType = txtBuildingType.Text.Trim();
                BuildingTypeVO.Active = chkActive.Checked;
                BuildingTypeVO.ModifiedBy = currentUser.ID;
                BuildingTypeVO.ModifiedDate = DateTime.Now;
                if (selectedBuildingType.BuildingTypeID == 0)
                {
                    service.AddBuildingType(BuildingTypeVO);
                }
                else
                {
                    service.EditBuildingType(BuildingTypeVO);
                }
                MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindingGrid();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildingTypeGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = BuildingTypeGridControl.FocusedView as GridView;
            this.selectedBuildingType = dgv.GetRow(dgv.FocusedRowHandle) as BuildingTypeVO;
            if (this.selectedBuildingType != null)
            {
                txtBuildingType.Text = this.selectedBuildingType.BuildingType;
                chkActive.Checked = this.selectedBuildingType.Active;
                txtBuildingType.Focus();
            }
        }

        private void BuildingTypeGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = BuildingTypeGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void txtBuildingType_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                BindingGrid();
            }
            else
            {
                BuildingTypeList = service.GetActiveBuildingType(false);
                BuildingTypeGridControl.DataSource = BuildingTypeList;
                BuildingTypeGridControl.RefreshDataSource();
            }
        }
    }
}