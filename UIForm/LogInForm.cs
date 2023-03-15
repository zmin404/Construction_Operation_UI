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
using System.ServiceModel;
using ISOService_API;
using ISOServiceVO;
//using ProductKeyHandler;

namespace ISOCloudSystem
{
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm
    {
        public UserVO CurrentUser { get; set; }
        public ISOIService PChannel { get; set; }
        //MainForm mainForm;

        public LogInForm(ISOIService s)  
        {
            InitializeComponent();
            this.PChannel = s;

#if DEBUG

            txtUserName.Text = "admin";
            txtPassword.Text = "admin";
#endif
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            //txtUserName.Focus(); txtUserName.SelectAll();
            //try
            //{
            //    short appID = 8;
            //    ClientKeyHandler handler = new ClientKeyHandler(appID);

            //    if (handler.IsActivate == false)
            //    {
            //        Application.Exit();
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Exit();
            //    return;
            //}
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    txtUserName.Focus(); txtUserName.SelectAll();
                    errorProvider1.SetError(txtUserName,"Please enter user name!");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Focus(); txtPassword.SelectAll();
                    errorProvider1.SetError(txtPassword, "Please enter password!");
                    return;
                }
                this.CurrentUser = this.PChannel.GetUser(txtUserName.Text, txtPassword.Text);
                if (this.CurrentUser == null)
                {
                    MessageBox.Show("Wrong user name or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus(); txtUserName.SelectAll();
                    return;
                }
                else
                {
                    this.Hide();
                }
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FaultException<ServerSvcFault> ex)
            {
                MessageBox.Show(string.Format("Reason: {0}! Message: {1}", ex.Message, ex.Detail.FaultMessage), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (CommunicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.SelectAll();
        }

    }
}