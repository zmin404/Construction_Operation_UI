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
    public partial class PersonAndSiteForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        PersonAndSiteVO selectedPersonAndSite;
        List<PersonAndSiteVO> PersonAndSiteList;
        PersonVO selectedPerson;
        List<PersonVO> PersonList;
        ResponsibilityTypeVO selectedResponsibilityType;
        List<ResponsibilityTypeVO> ResponsibilityTypeList;
        SiteVO selectedSite;
        List<SiteVO> SiteList;
        string PleaseSelect = "--Please Select--";

        public PersonAndSiteForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedPersonAndSite = new PersonAndSiteVO();
            this.selectedPerson = new PersonVO();
            this.selectedResponsibilityType = new ResponsibilityTypeVO ();
            this.selectedSite = new SiteVO();
            this.PersonAndSiteList = new List<PersonAndSiteVO>();
            this.PersonList = new List<PersonVO>();
            this.ResponsibilityTypeList = new List<ResponsibilityTypeVO>();
            this.SiteList = new List<SiteVO>();
        }

        private void ClearData()
        {
            this.selectedPersonAndSite = new PersonAndSiteVO();
            //SiteNameLookUpEdit.EditValue = 0;
            ResponsibilityLookUpEdit.EditValue = 0;
            PersonNameLookUpEdit.EditValue = 0;
            chkFinished.Checked = false;
            errorProvider1.Clear();
            SiteNameLookUpEdit.Focus();
        }

        private void BindingLookUpEdit()
        {
            List<SiteVO> SiteList = service.GetIsCompleteSite(false,true);
            //SiteList = service.GetActiveSite(true);
            if (SiteList != null)
            {
                SiteList.Add(new SiteVO() { SiteName = PleaseSelect });
                SiteNameLookUpEdit.Properties.DataSource = SiteList.OrderBy(x => x.SiteID);
            }
            List<PersonVO> PersonList = service.GetActivePerson(true);
            if (PersonList != null)
            {
                PersonList.Add(new PersonVO() { PersonName = PleaseSelect });
                PersonNameLookUpEdit.Properties.DataSource = PersonList.OrderBy(x => x.PersonID);
            }
            List<ResponsibilityTypeVO> ResponsibilityTypeList = service.GetAllResponsibilityType();
            if (ResponsibilityTypeList != null)
            {
                ResponsibilityTypeList.Add(new ResponsibilityTypeVO() { Type = PleaseSelect });
                ResponsibilityLookUpEdit.Properties.DataSource = ResponsibilityTypeList.OrderBy(x => x.ID);
            }
        }

        private void BindingGrid()
        {
            PersonAndSiteList = service.GetFinishedPersonAndSite(false);
            PersonAndSiteGridControl.DataSource = PersonAndSiteList;
            PersonAndSiteGridControl.RefreshDataSource();
        }

        private void PersonAndSiteForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
            BindingLookUpEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(SiteNameLookUpEdit.EditValue) == 0 || SiteNameLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(SiteNameLookUpEdit, "Please fill Site Name!");
                    SiteNameLookUpEdit.Focus();
                    return;
                }

                if (Convert.ToInt32(PersonNameLookUpEdit.EditValue) == 0 || PersonNameLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(PersonNameLookUpEdit, "Please fill Person Name!");
                    PersonNameLookUpEdit.Focus();
                    return;
                }
                if (Convert.ToInt32(ResponsibilityLookUpEdit.EditValue) == 0 || ResponsibilityLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(ResponsibilityLookUpEdit, "Please fill Responsibility Type!");
                    ResponsibilityLookUpEdit.Focus();
                    return;
                }
                else if (PersonAndSiteList != null)
                {
                    //if (PersonAndSiteList.Where(x => x.SiteID == Convert.ToInt32(SiteNameLookUpEdit.EditValue) && x.PersonID == Convert.ToInt32(PersonNameLookUpEdit.EditValue) && x.ResponsibilityTypeID == Convert.ToInt32(ResponsibilityLookUpEdit.EditValue) && x.Finished==chkFinished.Checked).Any())
                    if (PersonAndSiteList.Where(x => x.SiteID == Convert.ToInt32(SiteNameLookUpEdit.EditValue) && x.ResponsibilityTypeID == Convert.ToInt32(ResponsibilityLookUpEdit.EditValue) && x.Finished == chkFinished.Checked && x.ID != selectedPersonAndSite.ID).Any())
                    {
                        SiteNameLookUpEdit.Focus();
                        SiteNameLookUpEdit.SelectAll();
                        throw new Exception("Entry Data is already exists!");
                    }
                }

                PersonAndSiteVO PersonNSiteVO = new PersonAndSiteVO();
                PersonNSiteVO.ID = selectedPersonAndSite.ID;
                PersonNSiteVO.SiteID = Convert.ToInt32(SiteNameLookUpEdit.EditValue);
                PersonNSiteVO.PersonID  = Convert.ToInt32(PersonNameLookUpEdit.EditValue);
                PersonNSiteVO.ResponsibilityTypeID  = Convert.ToInt32(ResponsibilityLookUpEdit.EditValue);
                PersonNSiteVO.Finished = chkFinished.Checked;
                PersonNSiteVO.ModifiedBy = currentUser.ID;
                PersonNSiteVO.ModifiedDate = DateTime.Now;
                if (selectedPersonAndSite.ID == 0)
                {
                    service.AddPersonAndSite(PersonNSiteVO);
                }
                else
                {
                    service.EditPersonAndSite(PersonNSiteVO);
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
            SiteNameLookUpEdit.EditValue = 0;
            ClearData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void PersonAndSiteGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = PersonAndSiteGridControl.FocusedView as GridView;
            this.selectedPersonAndSite = dgv.GetRow(dgv.FocusedRowHandle) as PersonAndSiteVO;
            if (this.selectedPersonAndSite != null)
            {
                SiteNameLookUpEdit.EditValue  = this.selectedPersonAndSite.SiteID;
                PersonNameLookUpEdit.EditValue = this.selectedPersonAndSite.PersonID;
                ResponsibilityLookUpEdit.EditValue = this.selectedPersonAndSite.ResponsibilityTypeID;
                chkFinished.Checked = this.selectedPersonAndSite.Finished ;
                SiteNameLookUpEdit.Focus();
            }
        }

        private void PersonAndSiteGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            //For Upper Dev version 13.2
            int rowHandle = PersonAndSiteGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }


        private void PersonNSite_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear(); 
        }

        private void NewSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;

            switch(button.Name)
            {
                case "NewSiteSimpleButton" :
                    SiteForm S = new SiteForm(service , currentUser);
                    S.ShowDialog();
                    BindingLookUpEdit();
                    break;   
                case "NewPersonSimpleButton":
                    PersonForm P = new PersonForm(service , currentUser);
                    P.ShowDialog();
                    BindingLookUpEdit();
                    break;
                default: break;
            }
        }

        private void chkFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFinished.Checked)
            {
                PersonAndSiteList = service.GetFinishedPersonAndSite(true);
                PersonAndSiteGridControl.DataSource = PersonAndSiteList;
                PersonAndSiteGridControl.RefreshDataSource();
            }
            else
            {
                BindingGrid();
            }
        }
    }
}