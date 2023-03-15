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
using System.IO;
using System.Configuration;

namespace ISOFormat.UIForm
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO selectedUser;
        List<UserVO> UserList;
        string PleaseSelect = "--Please Select--";
        UserVO currentUser;
        string ImgPath = ConfigurationManager.AppSettings["ImgPath"];  

        public UserForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedUser = u;
            this.selectedUser = new UserVO();
            this.UserList = new List<UserVO>();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
            BindingLookUpEdit();
        }
        private void ClearData()
        {
            this.selectedUser = new UserVO();
            txtLoginName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            ProfilePictureEdit.Image = null;
            UserRoleLookUpEdit.EditValue = 0;
            PersonLookUpEdit.EditValue = 0;
            chkActive.Checked = true;
            errorProvider1.Clear();
            txtLoginName.Focus();
        }

        private void BindingGrid()
        {
            UserList = service.GetActiveUser(true);
            UserGridContorl.DataSource = UserList;
            UserGridContorl.RefreshDataSource();
        }

        private void BindingLookUpEdit() 
        {
            List<UserRoleVO> UserRoleList = service.GetActiveUserRole(true);
            if (UserRoleList != null)
            {
                UserRoleList.Add(new UserRoleVO() { RoleName = PleaseSelect });
                UserRoleLookUpEdit.Properties.DataSource = UserRoleList.OrderBy(x => x.ID);
            }
            List<PersonVO> PersonList = service.GetActivePerson(true);
            if (PersonList != null)
            {
                PersonList.Add(new PersonVO() { PersonName = PleaseSelect });
                PersonLookUpEdit.Properties.DataSource = PersonList.OrderBy(x => x.PersonID);
            }
            //List<PersonAndSiteVO> PersonNSiteList = service.GetFinishedPersonAndSite(false);
            //if (PersonNSiteList != null)
            //{
            //    PersonNSiteList.Add(new PersonAndSiteVO() { PersonName = PleaseSelect });
            //    PersonLookUpEdit.Properties.DataSource = PersonNSiteList.OrderBy(x => x.ID);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if(Convert.ToInt32(UserRoleLookUpEdit.EditValue)==0)
                {
                    errorProvider1.SetError(UserRoleLookUpEdit, "Please select User Role!");
                    UserRoleLookUpEdit.Focus();
                    return;
                }
                //else if (Convert.ToInt32(PersonLookUpEdit.EditValue) == 0)
                //{
                //    errorProvider1.SetError(PersonLookUpEdit, "Please select Person Name!");
                //    PersonLookUpEdit.Focus();
                //    return;
                //}
                
               else if (string.IsNullOrWhiteSpace(txtLoginName.Text))
                {
                    errorProvider1.SetError(txtLoginName, "Please fill User!");
                    txtLoginName.Focus();
                    return;
                }
                //else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                //{
                //    errorProvider1.SetError(txtPassword, "Please fill password!");
                //    txtPassword.Focus();
                //    return;
                //}
                else if (UserList != null)
                {
                    if (UserList.Where(x => x.LoginName == txtLoginName.Text.Trim() && x.ID != selectedUser.ID).Any())
                    {
                        txtLoginName.Focus(); txtLoginName.SelectAll();
                        throw new Exception("User is already exists!");
                    }
                }
              

                UserVO userVO = new UserVO();
                userVO.ID = selectedUser.ID;
                userVO.UserRoleID = Convert.ToInt32(UserRoleLookUpEdit.EditValue);
                userVO.LoginName = txtLoginName.Text.Trim();
                userVO.PersonID = Convert.ToInt32(PersonLookUpEdit.EditValue);
                //userVO.Email = txtEmail.Text.Trim();
                if (string.IsNullOrEmpty(txtEmail.Text)){userVO.Email = " @gmail.com";}
                else{userVO.Email = txtEmail.Text.Trim();}
                //userVO.Image = (ProfilePictureEdit.Image != null) ? imageToByteArray(ProfilePictureEdit.Image) : null;
                //var path = new System.IO.DirectoryInfo(@"C:\Program Files (x86)\Asia Brightway\ISO\NoImage.jpg");
                if(ProfilePictureEdit.Image == null)
                {
                    var path = new System.IO.DirectoryInfo(ImgPath);
                    Image img = Image.FromFile(path.ToString());
                    userVO.Image = imageToByteArray(img);
                }
                else
                {
                    userVO.Image = imageToByteArray(ProfilePictureEdit.Image);
                }
                userVO.Password = (string.IsNullOrEmpty(txtPassword.Text)) ? selectedUser.Password : Utils.HashPassword(txtPassword.Text.Trim()); 
                userVO.IsActive = chkActive.Checked;
                userVO.LastModifiedBy=currentUser.ID;
                userVO.LastModifiedOn = DateTime.Now;
                if (selectedUser.ID == 0)
                {
                    service.AddUser(userVO);
                }
                else
                {
                    service.EditUser(userVO);
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

        private void UserGridContorl_DoubleClick(object sender, EventArgs e)
        {
            GridView dgv = UserGridContorl.FocusedView as GridView;
            this.selectedUser = dgv.GetRow(dgv.FocusedRowHandle) as UserVO;
            if (this.selectedUser != null)
            {
                txtLoginName.Text = this.selectedUser.LoginName;
                UserRoleLookUpEdit.EditValue = this.selectedUser.UserRoleID;
                PersonLookUpEdit.EditValue = this.selectedUser.PersonID;
                txtEmail.Text = this.selectedUser.Email;
                ProfilePictureEdit.EditValue = this.selectedUser.Image;
                chkActive.Checked = this.selectedUser.IsActive;
                txtLoginName.Focus();
            }
        }

        private void UserGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = UserGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void UserRole_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ProfilePictureEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();

            Dlg.Filter = "";

            Dlg.Title = "Select image";

            if (Dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(Dlg.FileName);
                ProfilePictureEdit.Image = ScaleImage(img, 500, 500);
            }  
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                BindingGrid();
            }
            else
            {
                UserList = service.GetActiveUser(false);
                UserGridContorl.DataSource = UserList;
                UserGridContorl.RefreshDataSource();
            }
        }
    }
}