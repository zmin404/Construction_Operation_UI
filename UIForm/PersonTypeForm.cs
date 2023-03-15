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
    public partial class PersonTypeForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        PersonTypeVO selectedPersonType;
        List<PersonTypeVO> PersonTypeList;

        public PersonTypeForm(ISOIService s , UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedPersonType = new PersonTypeVO();
            this.PersonTypeList = new List<PersonTypeVO>();
        }

        private void ClearData()
        {
            this.selectedPersonType = new PersonTypeVO();
            txtPersonType.Text = string.Empty;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtPersonType.Focus();
        }

        private void BindingGrid()
        {
            PersonTypeList = service.GetActivePersonType(true);
            PersonTypeGridControl.DataSource = PersonTypeList;
            PersonTypeGridControl.RefreshDataSource();
        }

        private void PersonTypeForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPersonType.Text))
                {
                    errorProvider1.SetError(txtPersonType, "Please fill PersonType Name!");
                    txtPersonType.Focus();
                    return;
                }
                else if (PersonTypeList != null)
                {
                    if (PersonTypeList.Where(x => x.PersonType == txtPersonType.Text.Trim() && x.PersonTypeID != selectedPersonType.PersonTypeID).Any())
                    {
                        txtPersonType.Focus(); txtPersonType.SelectAll();
                        throw new Exception("PersonType Name is already exists!");
                    }
                }
                PersonTypeVO PersonTypeVO = new PersonTypeVO();
                PersonTypeVO.PersonTypeID = selectedPersonType.PersonTypeID;
                PersonTypeVO.PersonType = txtPersonType.Text.Trim();
                PersonTypeVO.Active = chkActive.Checked;
                PersonTypeVO.ModifiedBy = currentUser.ID;
                PersonTypeVO.ModifiedDate = DateTime.Now;
                if (selectedPersonType.PersonTypeID == 0)
                {
                    service.AddPersonType(PersonTypeVO);
                }
                else
                {
                    service.EditPersonType(PersonTypeVO);
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

        private void PersonTypeGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = PersonTypeGridControl.FocusedView as GridView;
            this.selectedPersonType = dgv.GetRow(dgv.FocusedRowHandle) as PersonTypeVO;
            if (this.selectedPersonType != null)
            {
                txtPersonType.Text = this.selectedPersonType.PersonType;
                chkActive.Checked = this.selectedPersonType.Active;
                txtPersonType.Focus();
            }
        }

        private void PersonTypeGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = PersonTypeGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void txtPersonType_TextChanged(object sender, EventArgs e)
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
                PersonTypeList = service.GetActivePersonType(false);
                PersonTypeGridControl.DataSource = PersonTypeList;
                PersonTypeGridControl.RefreshDataSource();
            }
        }
    }
}