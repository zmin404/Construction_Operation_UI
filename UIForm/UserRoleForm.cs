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
using ISOServiceVO;
using ISOService_API;
using DevExpress.XtraGrid.Views.Grid;

namespace ISOFormat.UIForm
{
    public partial class UserRoleForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        UserRoleVO selectedUserRole;
        List<UserRoleVO> UserRoleList;

        public UserRoleForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedUserRole = new UserRoleVO();
            this.UserRoleList = new List<UserRoleVO>();
        }


        private void ClearData()
        {
            this.selectedUserRole = new UserRoleVO();
            txtUserRole.Text = string.Empty;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtUserRole.Focus();
        }

        private void BindingGrid()
        {
            UserRoleList = service.GetActiveUserRole(true);
            UserRoleGridControl.DataSource = UserRoleList;
            UserRoleGridControl.RefreshDataSource();
        }

        private void UserRoleForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserRole.Text))
                {
                    errorProvider1.SetError(txtUserRole, "Please fill User Role!");
                    txtUserRole.Focus();
                    return;
                }
                else if (UserRoleList != null)
                {
                    if (UserRoleList.Where(x => x.RoleName == txtUserRole.Text.Trim() && x.ID != selectedUserRole.ID).Any())
                    {
                        txtUserRole.Focus(); txtUserRole.SelectAll();
                        throw new Exception("User Role Name is already exists!");
                    }
                }

                UserRoleVO userRoleVO = new UserRoleVO();
                userRoleVO.ID = selectedUserRole.ID;
                userRoleVO.RoleName =txtUserRole.Text.Trim();
                userRoleVO.IsActive = chkActive.Checked;
                if (selectedUserRole.ID == 0)
                {
                    service.AddUserRole(userRoleVO);
                }
                else
                {
                    service.EditUserRole(userRoleVO);
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

        private void UserRoleGridControl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = UserRoleGridControl.FocusedView as GridView;
            this.selectedUserRole = dgv.GetRow(dgv.FocusedRowHandle) as UserRoleVO;
            if(this.selectedUserRole != null)
            {
                txtUserRole.Text = this.selectedUserRole.RoleName;
                chkActive.Checked = this.selectedUserRole.IsActive;
                txtUserRole.Focus();
            }
        }

        private void UserRoleGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = UserRoleGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void txtUserRole_TextChanged(object sender, EventArgs e)
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
                UserRoleList = service.GetActiveUserRole(false);
                UserRoleGridControl.DataSource = UserRoleList;
                UserRoleGridControl.RefreshDataSource();
            }
        }
    }
}