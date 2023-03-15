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
    public partial class OperationOrderForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        OperationOrderVO selectedOO;
        OperationOrderRegVO selectedOOR;
        List<OperationOrderVO> OOList;
        List<OperationOrderRegVO> OORList;
        string PleaseSelect = "--Please Select--";

        public OperationOrderForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedOO = new OperationOrderVO();
            this.selectedOOR = new OperationOrderRegVO();
            this.OOList = new List<OperationOrderVO>();
            this.OORList = new List<OperationOrderRegVO>();
        }

        private void LabelClear()
        {
            lblOODateLabelControl.Text = string.Empty;
            lblBuildingTypeLabelControl.Text = string.Empty;
            lblSiteNameLabelControl.Text = string.Empty;
            lblSiteEngineerLabelControl.Text = string.Empty;
            lblSeniorInchargeLabelControl.Text = string.Empty;
            lblStoreKeeperLabelControl.Text = string.Empty;

            lblOODateLabelControl.BackColor = System.Drawing.Color.Transparent;
            lblBuildingTypeLabelControl.BackColor = System.Drawing.Color.Transparent;
            lblSiteNameLabelControl.BackColor = System.Drawing.Color.Transparent;
            lblSiteEngineerLabelControl.BackColor = System.Drawing.Color.Transparent;
            lblSeniorInchargeLabelControl.BackColor = System.Drawing.Color.Transparent;
            lblStoreKeeperLabelControl.BackColor = System.Drawing.Color.Transparent;
        }

        private void ClearData()
        {
            this.selectedOO = new OperationOrderVO();
            OrderRegNoLookUpEdit.EditValue = 0;
            txtDurationTextEdit.Text = string.Empty;
            txtDetailInstructionRichTextBox.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void BindingLookUpEdit()
        {
            List<OperationOrderRegVO> OORList = service.GetAllOperationOrderReg();
            if (OORList != null)
            {
                OORList.Add(new OperationOrderRegVO() { OrderNo  = PleaseSelect });
                OrderRegNoLookUpEdit.Properties.DataSource = OORList.OrderBy(x => x.OORID);
            }

        }

        private void BindingGrid()
        {
            OOList = service.GetAllOperationOrder();
            OperationOrderGridControl.DataSource = OOList;
            OperationOrderGridControl.RefreshDataSource();
        }

        private void BindingGridCompletePrepare()
        {
            OOList = service.GetOperationOrderCompletePrepare();
            OperationOrderGridControl.DataSource = OOList;
            OperationOrderGridControl.RefreshDataSource();
        }

        private void BindingGridCompleteApprove() 
        {
            OOList = service.GetOperationOrderCompleteApprove();
            OperationOrderGridControl.DataSource = OOList;
            OperationOrderGridControl.RefreshDataSource();
        }

        private void OperationOrderForm_Load(object sender, EventArgs e)
        {
            RolePermission();
            ClearData();
            BindingLookUpEdit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(OrderRegNoLookUpEdit.EditValue) == 0 || OrderRegNoLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(OrderRegNoLookUpEdit, "Please select Order Reg No!");
                    OrderRegNoLookUpEdit.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDurationTextEdit.Text))
                {
                    errorProvider1.SetError(txtDurationTextEdit, "Please fill duration!");
                    txtDurationTextEdit.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDetailInstructionRichTextBox.Text))
                {
                    errorProvider1.SetError(txtDetailInstructionRichTextBox, "Please fill Detail Instruction");
                    txtDetailInstructionRichTextBox.Focus();
                    return;
                }

                OperationOrderVO OOVO = new OperationOrderVO();
                OOVO.OOID = selectedOO.OOID;
                OOVO.OORID = selectedOOR.OORID;
                OOVO.SiteID = selectedOOR.SiteID;
                OOVO.SiteEngineerID = selectedOOR.SiteEngineerID;
                OOVO.SeniorInchargeID = selectedOOR.SeniorInchargeID;
                OOVO.StoreKeeperID = selectedOOR.StoreKeeperID;
                OOVO.BuildingTypeID = selectedOOR.BuildingTypeId;
                OOVO.OODate = selectedOOR.OrderDate;
                OOVO.DetailInstruction = txtDetailInstructionRichTextBox.Text;
                OOVO.Duration = txtDurationTextEdit.Text;
                OOVO.CompleteApprove = chkCompleteApprove.Checked;
                OOVO.CompletePrepare = chkCompletePrepare.Checked;
                if (chkCompleteApprove.Checked = true && (this.currentUser.UserRoleID == 2 || this.currentUser.UserRoleID == 3))
                {
                    OOVO.ApprovedBy = this.currentUser.ID;
                }
                else
                {
                    OOVO.ApprovedBy = null;
                }
                OOVO.ModifiedBy = currentUser.ID;
                OOVO.ModifiedDate = DateTime.Now;
                if (selectedOO.OOID == 0)
                {
                    service.AddOperationOrder(OOVO);
                }
                else
                {
                    service.EditOperationOrder(OOVO);
                }
                MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindingGrid();
                ClearData();
                LabelClear();
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

        private void txtOOR_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void OperationOrderGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = OperationOrderGridControl.FocusedView as GridView;
            this.selectedOO = dgv.GetRow(dgv.FocusedRowHandle) as OperationOrderVO;

            if (this.selectedOO != null)
            {
                    OrderRegNoLookUpEdit.EditValue = this.selectedOO.OORID;
                    lblOODateLabelControl.Text = this.selectedOO.OODate.ToString("dd/MM/yyyy");
                    lblBuildingTypeLabelControl.Text = this.selectedOO.BuildingType;
                    lblSiteNameLabelControl.Text = this.selectedOO.Site;
                    lblSiteEngineerLabelControl.Text = this.selectedOO.SiteEngineer;
                    lblSeniorInchargeLabelControl.Text = this.selectedOO.SeniorIncharge;
                    lblStoreKeeperLabelControl.Text = this.selectedOO.StoreKeeper;
                    txtDurationTextEdit.Text = this.selectedOO.Duration;
                    txtDetailInstructionRichTextBox.Text = this.selectedOO.DetailInstruction;
                    chkCompleteApprove.Checked = (bool)this.selectedOO.CompleteApprove;
                    chkCompletePrepare.Checked = (bool)this.selectedOO.CompletePrepare;

                    RolePermission();
                    OrderRegNoLookUpEdit.Focus();
            } 
        }

        private void RolePermission()
        {
            if (this.currentUser.UserRoleID == 2 || this.currentUser.UserRoleID == 3)
            {
                chkCompleteApprove.Visible = true;
                OrderRegNoLookUpEdit.Enabled = false;
                txtDurationTextEdit.Enabled = false;
                txtDetailInstructionRichTextBox.Enabled = false;
                BindingGridCompletePrepare();
            }
            else if (this.currentUser.UserRoleID == 4)
            {
                OrderRegNoLookUpEdit.Enabled = false;
                txtDurationTextEdit.Enabled = false;
                txtDetailInstructionRichTextBox.Enabled = false;
                btnSave.Enabled = false;
                btnClear.Enabled = false;
                BindingGridCompleteApprove();
            }
            else if (this.currentUser.UserRoleID == 5)
            {
                chkCompletePrepare.Visible = true;
                BindingGrid();
                if (chkCompleteApprove.Checked == true)
                {
                    OrderRegNoLookUpEdit.Enabled = false;
                    txtDurationTextEdit.Enabled = false;
                    txtDetailInstructionRichTextBox.Enabled = false;
                    btnSave.Enabled = false;
                    btnClear.Enabled = false;
                }
                else
                {
                    OrderRegNoLookUpEdit.Enabled = true;
                    txtDurationTextEdit.Enabled = true;
                    txtDetailInstructionRichTextBox.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
            else
            {
                chkCompletePrepare.Visible = true;
                chkCompleteApprove.Visible = true;
                BindingGrid();
            }
        }

        private void OperationOrderGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = OperationOrderGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void OrderRegNoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.selectedOOR = new OperationOrderRegVO();
            int orderID = (Convert.ToInt32(OrderRegNoLookUpEdit.EditValue) != 0)?Convert.ToInt32(OrderRegNoLookUpEdit.EditValue): 0;
            if (orderID != 0)
            {
                this.selectedOOR = service.GetOperationOrderRegByOORID(orderID);
                lblOODateLabelControl.Text = this.selectedOOR.OrderDate.ToString("dd/MM/yyyy");
                lblBuildingTypeLabelControl.Text = this.selectedOOR.BuildingType;
                lblSiteNameLabelControl.Text = this.selectedOOR.Site;
                lblSiteEngineerLabelControl.Text = this.selectedOOR.SiteEngineer;
                lblSeniorInchargeLabelControl.Text = this.selectedOOR.SeniorIncharge;
                lblStoreKeeperLabelControl.Text = this.selectedOOR.StoreKeeper;

                lblOODateLabelControl.BackColor = Color.Lavender;
                lblBuildingTypeLabelControl.BackColor = Color.Lavender;
                lblSiteNameLabelControl.BackColor = Color.Lavender;
                lblSiteEngineerLabelControl.BackColor = Color.Lavender;
                lblSeniorInchargeLabelControl.BackColor = Color.Lavender;
                lblStoreKeeperLabelControl.BackColor = Color.Lavender;

            }
            else
            {
                LabelClear();
            }
        }

    }
}