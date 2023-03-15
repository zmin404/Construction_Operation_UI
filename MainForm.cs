using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ISOServiceVO;
using System.ServiceModel;
using System.Diagnostics;
using ISOCloudSystem;
using ISOFormat.UIForm;
using DevExpress.XtraEditors;
using ISOFormat.Report;
using ISOService_API;

namespace ISOFormat
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ISOIService PChannel;
        public UserVO currentUser;
        ChannelFactory<ISOIService> channelFactory;

        public MainForm()
        {
            InitializeComponent();
            this.currentUser = new UserVO();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChannelFactory cf = new ChannelFactory();
            this.channelFactory = cf.factory;
            this.PChannel = cf.Channel;

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            //POSRibbonControl.Enabled = false;

            LogInForm loginForm = new LogInForm(this.PChannel);
            loginForm.ShowDialog();
            this.PChannel = loginForm.PChannel;
            this.currentUser = loginForm.CurrentUser;
            //POSRibbonControl.Enabled = true;

            if (loginForm.CurrentUser == null)
            {
                if (this.channelFactory != null)
                {
                    this.channelFactory.Abort();
                }
                this.Close();
            }
            else
            {
                //LogInToolStripStatusLabel.Text = (this.currentUser != null) ? string.Format("Welcome {0}!!!   Your role is {1}   Version {2} ", this.currentUser.LoginName, this.currentUser.UserRole, version) : string.Empty;
                BorttonBarStaticItem.Caption = (this.currentUser != null) ? string.Format("Welcome {0}!!!   Your role is {1}   Version {2} ", this.currentUser.LoginName, this.currentUser.UserRole, version) : string.Empty;
                //BindUserPermission();

                //App.Config = PChannel.GetAllConfig();
            }
        }


        private void ViewChildForm(XtraForm form)
        {
            if (IsformActived(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private bool IsformActived(XtraForm form)
        {
            bool isopened = true;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        XtraTabbedMdiManager.Pages[item].MdiChild.Activate();
                        isopened = false;
                    }
                }
            }
            return isopened;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.currentUser != null && this.currentUser.ID != 0)
            {
                PChannel.EditUser(currentUser);
            }
        }

        private void CloseBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void BuildingTypeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuildingTypeForm form = new BuildingTypeForm(PChannel, currentUser);
            ViewChildForm(form);
        }

        private void SiteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SiteForm form = new SiteForm(PChannel, currentUser);
            ViewChildForm(form);
        }

        private void PersonBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonForm form = new PersonForm(PChannel, currentUser);
            ViewChildForm(form);
        }

        private void PersonAndSiteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonAndSiteForm form = new PersonAndSiteForm(PChannel, currentUser);
            ViewChildForm(form);
        }
        
        private void PersonTypeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonTypeForm form = new PersonTypeForm(PChannel, currentUser);
            ViewChildForm(form);
        }

        private void OperationOrderRegBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperationOrderRegForm form = new OperationOrderRegForm(PChannel, currentUser);
            ViewChildForm(form);
        }

        private void OperatonOrderBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperationOrderForm form = new OperationOrderForm(PChannel , currentUser);
            ViewChildForm(form);
        }

        private void ReportBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportViewerForm form = new ReportViewerForm(PChannel, currentUser);
            form.ShowDialog();
        }

        private void NameOfWorkBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            NameOfWorkForm form = new NameOfWorkForm(PChannel , currentUser);
            ViewChildForm(form);
        }

        private void UserRoleBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserRoleForm form = new UserRoleForm(PChannel ,currentUser);
            ViewChildForm(form);
        }

        private void UserBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserForm form = new UserForm(PChannel, currentUser);
            ViewChildForm(form);
        }

    }
}