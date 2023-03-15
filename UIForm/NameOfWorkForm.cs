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
    public partial class NameOfWorkForm : DevExpress.XtraEditors.XtraForm 
    {
        ISOIService service;
        UserVO currentUser;
        NameOfWorkVO selectedNameOfWork;
        List<NameOfWorkVO> NameOfWorkList;
        string PleaseSelect = "--Please Select--";

        public NameOfWorkForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedNameOfWork = new NameOfWorkVO();
            this.NameOfWorkList = new List<NameOfWorkVO>();
        }

        private void ClearData()
        {
            this.selectedNameOfWork = new NameOfWorkVO();
            txtNameOfWorkActivities.Text = string.Empty;
            OPTypeLookUpEdit.EditValue = null;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtNameOfWorkActivities.Focus();
        }

        private void BindingGrid()
        {
            NameOfWorkList = service.GetActiveNameOfWork(true);
            NOWAGridControl.DataSource = NameOfWorkList;
            NOWAGridControl.RefreshDataSource();
        }

        private void BindingLookUpEdit()
        {
            List<OPTypeVO> OPTypeList = service.GetAllOPType();
            if (OPTypeList != null)
            {
                OPTypeList.Add(new OPTypeVO() { OperationPlan = PleaseSelect });
                OPTypeLookUpEdit.Properties.DataSource = OPTypeList.OrderBy(x => x.OPTypeID);
            }
        }

        private void NameOfWorkForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
            BindingLookUpEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(OPTypeLookUpEdit.EditValue) == 0)
                {
                    errorProvider1.SetError(OPTypeLookUpEdit, "Please fill OP Type!");
                    OPTypeLookUpEdit.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNameOfWorkActivities.Text))
                {
                    errorProvider1.SetError(txtNameOfWorkActivities, "Please fill Name Of Work!");
                    txtNameOfWorkActivities.Focus();
                    return;
                }
                else if (NameOfWorkList != null)
                {
                    if (NameOfWorkList.Where(x => x.NameofWork == txtNameOfWorkActivities.Text.Trim() && x.OPTypeID != selectedNameOfWork.OPTypeID).Any())
                    {
                        txtNameOfWorkActivities.Focus(); txtNameOfWorkActivities.SelectAll();
                        throw new Exception("Data Entry is already exists!");
                    }
                }
                NameOfWorkVO NameOfWorkVO = new NameOfWorkVO();
                NameOfWorkVO.ID = selectedNameOfWork.ID;
                NameOfWorkVO.NameofWork = txtNameOfWorkActivities.Text.Trim();
                NameOfWorkVO.OPTypeID = Convert.ToInt32(OPTypeLookUpEdit.EditValue);
                NameOfWorkVO.Active = chkActive.Checked;
                NameOfWorkVO.ModifiedBy = currentUser.ID;
                NameOfWorkVO.ModifiedDate = DateTime.Now;
                if (selectedNameOfWork.ID == 0)
                {
                    service.AddNameOfWork(NameOfWorkVO);
                }
                else
                {
                    service.EditNameOfWork(NameOfWorkVO);
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

        private void NOWAGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = NOWAGridControl.FocusedView as GridView;
            this.selectedNameOfWork = dgv.GetRow(dgv.FocusedRowHandle) as NameOfWorkVO;
            if (this.selectedNameOfWork != null)
            {
                txtNameOfWorkActivities.Text = this.selectedNameOfWork.NameofWork;
                OPTypeLookUpEdit.EditValue = this.selectedNameOfWork.OPTypeID;
                chkActive.Checked = this.selectedNameOfWork.Active;
                OPTypeLookUpEdit.Focus();
            }
        }

        private void NOWAGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = NOWAGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void txtNOWA_TextChanged(object sender, EventArgs e)
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
                NameOfWorkList = service.GetActiveNameOfWork(false);
                NOWAGridControl.DataSource = NameOfWorkList;
                NOWAGridControl.RefreshDataSource();
            }
        }
    }
}