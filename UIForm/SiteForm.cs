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
    public partial class SiteForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        SiteVO selectedSite;
        List<SiteVO> SiteList;

        public SiteForm(ISOIService s , UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedSite = new SiteVO();
            this.SiteList = new List<SiteVO>();
        }

        private void ClearData()
        {
            this.selectedSite = new SiteVO();
            txtSideCode.Text = service.GetNewSiteCode();
            txtSiteName.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            chkActive.Checked = true;
            chkIsComplete.Checked = false;
            errorProvider1.Clear();
            txtSiteName.Focus();
        }

        private void BindingGrid() 
        {
            SiteList = service.GetIsCompleteSite(false, true);
            SiteGridControl.DataSource = SiteList;
            SiteGridControl.RefreshDataSource();
        }

        private void SiteForm_Load(object sender, EventArgs e) 
        {
            ClearData();
            BindingGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrWhiteSpace(txtSideCode.Text))
                //{
                //    errorProvider1.SetError(txtSideCode, "Please fill Site Code!");
                //    txtSideCode.Focus();
                //    return;
                //}
                //else if (SiteList != null)
                //{
                //    if (SiteList.Where(x => x.SiteCode == txtSideCode.Text.Trim() && x.SiteID != selectedSite.SiteID).Any())
                //    {
                //        txtSideCode.Focus(); txtSideCode.SelectAll();
                //        throw new Exception("Site Code is already exists!");
                //    }
                //}
                if (string.IsNullOrWhiteSpace(txtSiteName.Text))
                {
                    errorProvider1.SetError(txtSiteName, "Please fill Site Name!");
                    txtSiteName.Focus();
                    return;
                }
                else if (SiteList != null)
                {
                    if (SiteList.Where(x => x.SiteName == txtSiteName.Text.Trim() && x.SiteID != selectedSite.SiteID).Any())
                    {
                        txtSiteName.Focus(); txtSiteName.SelectAll();
                        throw new Exception("Site Name is already exists!");
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    errorProvider1.SetError(txtCustomerName, "Please fill Customer Name!");
                    txtCustomerName.Focus();
                    return;
                }

                SiteVO SiteVO = new SiteVO();
                SiteVO.SiteID = selectedSite.SiteID;
                SiteVO.SiteCode = txtSideCode.Text.Trim();
                SiteVO.SiteName = txtSiteName.Text;
                SiteVO.CustomerName = txtCustomerName.Text;
                SiteVO.Active = chkActive.Checked;
                SiteVO.IsComplete = chkIsComplete.Checked;
                SiteVO.ModifiedBy = currentUser.ID;
                SiteVO.ModifiedDate = DateTime.Now;
                if (selectedSite.SiteID == 0)
                {
                    service.AddSite(SiteVO);
                }
                else
                {
                    service.EditSite(SiteVO);
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

        private void SiteGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = SiteGridControl.FocusedView as GridView;
            this.selectedSite = dgv.GetRow(dgv.FocusedRowHandle) as SiteVO;
            if (this.selectedSite != null)
            {
                txtSideCode.Text = this.selectedSite.SiteCode;
                txtSiteName.Text = this.selectedSite.SiteName;
                txtCustomerName.Text = this.selectedSite.CustomerName;
                chkActive.Checked = this.selectedSite.Active;
                chkIsComplete.Checked = this.selectedSite.IsComplete;
                txtSiteName.Focus();
            }
        }

        private void SiteGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = SiteGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void chkIsComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsComplete.Checked)
            {
                SiteList = service.GetIsCompleteSite(true,true);
                SiteGridControl.DataSource = SiteList;
                SiteGridControl.RefreshDataSource();
            }
            else
            {
                BindingGrid();
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked == true && chkIsComplete.Checked == false )
            {
                BindingGrid();
            }
            else
            {
                SiteList = service.GetActiveSite(false);
                SiteGridControl.DataSource = SiteList;
                SiteGridControl.RefreshDataSource();
            }
        }

    }
}