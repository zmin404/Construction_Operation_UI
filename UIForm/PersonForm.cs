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
    public partial class PersonForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        PersonVO selectedPerson;
        List<PersonVO> PersonList;
        PersonTypeVO selectedPersonType;
        List<PersonTypeVO> PersonTypeList;
        string PleaseSelect = "--Please Select--";

        public PersonForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedPerson = new PersonVO();
            this.selectedPersonType = new PersonTypeVO();
            this.PersonList = new List<PersonVO>();
            this.PersonTypeList = new List<PersonTypeVO>();
        }

        private void ClearData()
        {
            this.selectedPerson = new PersonVO();
            txtPerson.Text = string.Empty;
            PersonTypeLookUpEdit.EditValue = 0;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtPerson.Focus();
        }

        private void BindingLookUpEdit()
        {
            List<PersonTypeVO> PersonTypeList = service.GetActivePersonType(true);
            if (PersonTypeList != null)
            {
                PersonTypeList.Add(new PersonTypeVO() { PersonType = PleaseSelect });
                PersonTypeLookUpEdit.Properties.DataSource = PersonTypeList.OrderBy(x => x.PersonTypeID);
            }
        }

        private void BindingGrid()
        {
            PersonList = service.GetActivePerson(true);
            PersonGridControl.DataSource = PersonList;
            PersonGridControl.RefreshDataSource();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
            BindingLookUpEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PersonTypeLookUpEdit.EditValue) == 0 || PersonTypeLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(PersonTypeLookUpEdit, "Please fill Person Type!");
                    PersonTypeLookUpEdit.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPerson.Text))
                {
                    errorProvider1.SetError(txtPerson, "Please fill Person Name!");
                    txtPerson.Focus();
                    return;
                }
                else if (PersonList != null)
                {
                    if (PersonList.Where(x => x.PersonName == txtPerson.Text.Trim() && x.PersonTypeID == Convert.ToInt32(PersonTypeLookUpEdit.EditValue) && x.PersonID != selectedPerson.PersonID).Any())
                    {
                        txtPerson.Focus(); txtPerson.SelectAll();
                        throw new Exception("Person Name is already exists!");
                    }
                }
            
                PersonVO PersonVO = new PersonVO();
                PersonVO.PersonID = selectedPerson.PersonID;
                PersonVO.PersonName = txtPerson.Text.Trim();
                PersonVO.PersonTypeID = Convert.ToInt32(PersonTypeLookUpEdit.EditValue);
                PersonVO.Active = chkActive.Checked;
                PersonVO.ModifiedBy = currentUser.ID;
                PersonVO.ModifiedDate = DateTime.Now;
                if (selectedPerson.PersonID == 0)
                {
                    service.AddPerson(PersonVO);
                }
                else
                {
                    service.EditPerson(PersonVO);
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

       

        private void PersonGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = PersonGridControl.FocusedView as GridView;
            this.selectedPerson = dgv.GetRow(dgv.FocusedRowHandle) as PersonVO;
            if (this.selectedPerson != null)
            {
                txtPerson.Text = this.selectedPerson.PersonName;
                PersonTypeLookUpEdit.EditValue = this.selectedPerson.PersonTypeID;
                chkActive.Checked = this.selectedPerson.Active;
                txtPerson.Focus();
            }
        }

        private void PersonGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            //For Upper Dev version 13.2
            int rowHandle = PersonGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }


        private void PersonType_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void NewPersonTypeSimpleButton_Click(object sender, EventArgs e)
        {
            PersonTypeForm form = new PersonTypeForm(service,currentUser);
            form.ShowDialog();
            BindingLookUpEdit();
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                BindingGrid();
            }
            else
            {
                PersonList = service.GetActivePerson(false);
                PersonGridControl.DataSource = PersonList;
                PersonGridControl.RefreshDataSource();
            }
        }

    }
}