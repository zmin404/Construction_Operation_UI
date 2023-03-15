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
using DevExpress.XtraBars.Ribbon;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using System.Security.AccessControl;

namespace ISOFormat.UIForm
{
    public partial class OperationOrderRegForm : DevExpress.XtraEditors.XtraForm
    {
        ISOIService service;
        UserVO currentUser;
        OperationOrderRegVO selectedOOR;
        SiteVO selectedSite;
        BuildingTypeVO selectedBuildingType;
        PersonVO selectedPerson;
        List<OperationOrderRegVO> OORList;
        List<SiteVO> SiteList;
        List<BuildingTypeVO> BuildingTypeList;
        List<PersonVO> PersonList;
        string PleaseSelect = "--Please Select--";

        private GalleryItemGroup MasterPDFgroup;
        private GalleryItemGroup ContractPDFgroup;
        string uploadlabel;
        bool? isupload;

        struct ftpsetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string fileName { get; set; }
            public string fullName { get; set; }
        }
        ftpsetting _inputParameter;

        public OperationOrderRegForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.service = s;
            this.currentUser = u;
            this.selectedOOR = new OperationOrderRegVO();
            this.selectedBuildingType = new BuildingTypeVO();
            this.BuildingTypeList = new List<BuildingTypeVO>();
            this.selectedSite = new SiteVO();
            this.OORList = new List<OperationOrderRegVO>();
            this.SiteList = new List<SiteVO>();
            this.selectedPerson = new PersonVO();
            this.PersonList = new List<PersonVO>();

            this.MasterPDFgroup = new GalleryItemGroup();
            this.ContractPDFgroup = new GalleryItemGroup();
            this.backgroundWorker1 = new BackgroundWorker();
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.WorkerReportsProgress = true;
            isupload = false;
        }

        private void ClearData()
        {
            this.selectedOOR = new OperationOrderRegVO();
            txtOrderNo.Text = string.Empty;
            OrderDateEdit.EditValue = DateTime.Now.Date;
            SiteLookUpEdit.EditValue = 0;
            BuildingTypeLookUpEdit.EditValue = 0;
            SiteEngineerLookUpEdit.EditValue = 0;
            SeniorInchargeLookUpEdit.EditValue = 0;
            StoreKeeperLookUpEdit.EditValue = 0;
            StartingDateEdit.EditValue = DateTime.Now.Date;
            RemarkRichTextBox.Text = string.Empty;
            errorProvider1.Clear();
            txtOrderNo.Focus();
            uploadlabel = string.Empty;

            MasterPDFgroup.Items.Clear();
            UploadSimpleButton.Enabled = true;
            MasterUploadlabel.Text = "Upload 0%";
            MasterUploadProgressBar.Value = 0;
            ContractPDFgroup.Items.Clear();
            UploadSimpleButton1.Enabled = true;
            ContractUploadlabel.Text = "Upload 0%";
            ContractUploadProgressBar.Value = 0;
            _inputParameter = new ftpsetting();
            //isupload = false;
        }

        private void BindingLookUpEdit()
        {
            List<SiteVO> SiteList = service.GetIsCompleteSite(false,true);
            if (SiteList != null)
            {
                SiteList.Add(new SiteVO() { SiteName = PleaseSelect });
                SiteLookUpEdit.Properties.DataSource = SiteList.OrderBy(x => x.SiteID);
            }

            List<BuildingTypeVO> BuildingTypeList = service.GetActiveBuildingType(true);
            if (BuildingTypeList != null)
            {
                BuildingTypeList.Add(new BuildingTypeVO() { BuildingType = PleaseSelect });
                BuildingTypeLookUpEdit.Properties.DataSource = BuildingTypeList.OrderBy(x => x.BuildingTypeID);
            }

            List<PersonVO> SiteEngineerList = service.GetActivePerson(true);
            if (SiteEngineerList != null)
            {
                SiteEngineerList.Add(new PersonVO() {PersonName = PleaseSelect });
                SiteEngineerLookUpEdit.Properties.DataSource = SiteEngineerList.OrderBy(x => x.PersonID);
            }

            List<PersonVO> SeniorInchargeList = service.GetActivePerson(true);
            if (SeniorInchargeList != null)
            {
                SeniorInchargeList.Add(new PersonVO() { PersonName = PleaseSelect });
                SeniorInchargeLookUpEdit.Properties.DataSource = SeniorInchargeList.OrderBy(x => x.PersonID);
            }

            List<PersonVO> StoreKeeperList = service.GetActivePerson(true);
            if (SiteList != null)
            {
                StoreKeeperList.Add(new PersonVO() { PersonName = PleaseSelect });
                StoreKeeperLookUpEdit.Properties.DataSource = StoreKeeperList.OrderBy(x => x.PersonID);
            }
        }

        private void BindingGrid()
        {
            OORList = service.GetAllOperationOrderReg();
            OORGridControl.DataSource = OORList;
            OORGridControl.RefreshDataSource();
        }

        private void OperationOrderRegForm_Load(object sender, EventArgs e)
        {
            ClearData();
            BindingGrid();
            BindingLookUpEdit();

            MasterPDFgroup.Caption = "Master PDF File";
            MasterPDFGalleryControl.Gallery.Groups.Add(MasterPDFgroup);

            ContractPDFgroup.Caption = "Contract PDF File";
            ContractPDFGalleryControl.Gallery.Groups.Add(ContractPDFgroup);

            #region Create ISOPDF Folder Path

            var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            string path = Path.Combine(windowsPath, "ISOPDFFile");
            DirectorySecurity securityRules = new DirectorySecurity();
            securityRules.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path, securityRules);
                Directory.SetAccessControl(path, securityRules);
            }

            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOrderNo.Text))
                {
                    errorProvider1.SetError(txtOrderNo, "Please fill Order No.!");
                    txtOrderNo.Focus();
                    return;
                }
                else if (OORList != null)
                {
                    if (OORList.Where(x => x.OrderNo == txtOrderNo.Text.Trim() && x.OORID != selectedOOR.OORID).Any())
                    {
                        txtOrderNo.Focus(); txtOrderNo.SelectAll();
                        throw new Exception("Order No. is already exists!");
                    }
                }
                if (Convert.ToInt32(SiteLookUpEdit.EditValue) == 0 || SiteLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(SiteLookUpEdit, "Please fill Site Name!");
                    SiteLookUpEdit.Focus();
                    return;
                }
                if (Convert.ToInt32(BuildingTypeLookUpEdit.EditValue) == 0 || BuildingTypeLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(BuildingTypeLookUpEdit, "Please fill Building Type!");
                    BuildingTypeLookUpEdit.Focus();
                    return;
                }
                if (Convert.ToInt32(SiteEngineerLookUpEdit.EditValue) == 0 || SiteEngineerLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(SiteEngineerLookUpEdit, "Please fill Site Engineer Name!");
                    SiteEngineerLookUpEdit.Focus();
                    return;
                }
                if (Convert.ToInt32(SeniorInchargeLookUpEdit.EditValue) == 0 || SeniorInchargeLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(SeniorInchargeLookUpEdit, "Please fill Senior Incharge Name!");
                    SeniorInchargeLookUpEdit.Focus();
                    return;
                }
                if (Convert.ToInt32(StoreKeeperLookUpEdit.EditValue) == 0 || StoreKeeperLookUpEdit.EditValue == null)
                {
                    errorProvider1.SetError(StoreKeeperLookUpEdit, "Please fill Store Keeper Name!");
                    StoreKeeperLookUpEdit.Focus();
                    return;
                }

                OperationOrderRegVO OORVO = new OperationOrderRegVO();
                OORVO.OORID = selectedOOR.OORID;
                OORVO.OrderNo = txtOrderNo.Text.Trim();
                OORVO.OrderDate = OrderDateEdit.DateTime.Date;
                OORVO.SiteID = Convert.ToInt32(SiteLookUpEdit.EditValue);
                OORVO.BuildingTypeId = Convert.ToInt32(BuildingTypeLookUpEdit.EditValue);
                OORVO.SiteEngineerID = Convert.ToInt32(SiteEngineerLookUpEdit.EditValue);
                OORVO.SeniorInchargeID = Convert.ToInt32(SeniorInchargeLookUpEdit.EditValue);
                OORVO.StoreKeeperID = Convert.ToInt32(StoreKeeperLookUpEdit.EditValue);
                OORVO.StartingDate = StartingDateEdit.DateTime.Date;
                OORVO.Remark = RemarkRichTextBox.Text;
                OORVO.ModifiedBy = currentUser.ID;
                OORVO.ModifiedDate = DateTime.Now;

                //Master Schedule PDF List
                if (MasterPDFgroup.Items.Count > 0)
                {
                    List<MasterSchedulePDFVO> list = new List<MasterSchedulePDFVO>();
                    foreach (GalleryItem item in MasterPDFgroup.Items)
                    {
                        list.Add(new MasterSchedulePDFVO() { MasterSchedulePDF = item.Caption, SiteID = OORVO.SiteID });
                    }
                    OORVO.MasterSchedulePDFList = list;
                }
                //Contract PDF List
                if (ContractPDFgroup.Items.Count > 0)
                {
                    List<ContractPDFVO> list = new List<ContractPDFVO>();
                    foreach (GalleryItem item in ContractPDFgroup.Items)
                    {
                        list.Add(new ContractPDFVO() { ContractPDF = item.Caption, SiteID = OORVO.SiteID });
                    }
                    OORVO.ContractPDFList = list;
                }
                if (selectedOOR.OORID == 0)
                {
                    service.AddOperationOrderReg(OORVO);
                }
                else
                {
                    service.EditOperationOrderReg(OORVO);
                }
                MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindingGrid();
                ClearData();
                isupload = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                 if (MasterPDFgroup.Items.Count > 0 || ContractPDFgroup.Items.Count > 0)
                 {
                        if (DialogResult.Yes == MessageBox.Show("Are you sure to clear?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            foreach (GalleryItem item in MasterPDFgroup.Items)
                            {
                                int count = selectedOOR.MasterSchedulePDFList.Where(x => x.MasterSchedulePDF == item.Caption).Count();
                                if (count > 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    uploadlabel = "Master";
                                    RemovePDFFile(item.Caption);
                                }
                            }
                            foreach (GalleryItem item in ContractPDFgroup.Items)
                            {
                                int count = selectedOOR.ContractPDFList.Where(x => x.ContractPDF == item.Caption).Count();
                                if (count > 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    uploadlabel = "Contract";
                                    RemovePDFFile(item.Caption);
                                }
                            }
                     }
                }
                 if (isupload == null)
                 {
                     throw new Exception("Please save to update selected order registration!");
                 }
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOOR_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void OORGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //For Upper Dev version 13.2
            int rowHandle = OORGridView.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colNo)
            {
                if (rowHandle >= 0)
                {
                    e.DisplayText = (rowHandle + 1).ToString();
                }
            }
        }

        private void NewSimpleButton_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;

            switch (button.Name)
            {
                case "NewSiteSimpleButton":
                    SiteForm S = new SiteForm(service, currentUser);
                    S.ShowDialog();
                    BindingLookUpEdit();
                    break;
                case "NewBuildingTypeSimpleButton":
                    BuildingTypeForm BT = new BuildingTypeForm(service, currentUser);
                    BT.ShowDialog();
                    BindingLookUpEdit();
                    break;
                case "NewSiteEngineerSimpleButton":
                    PersonForm SE = new PersonForm(service, currentUser);
                    SE.ShowDialog();
                    BindingLookUpEdit();
                    break;
                case "NewSeniorInchargeSimpleButton":
                    PersonForm SI = new PersonForm(service, currentUser);
                    SI.ShowDialog();
                    BindingLookUpEdit();
                    break;
                case "NewStoreKeeperSimpleButton":
                    PersonForm SK = new PersonForm(service, currentUser);
                    SK.ShowDialog();
                    BindingLookUpEdit();
                    break;
                default: break;
            }
        }

        private void SiteLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            int siteID = Convert.ToInt32(SiteLookUpEdit.EditValue);
             //int engineerID = Convert.ToInt32(SiteEngineerLookUpEdit.EditValue);
            if (siteID != 0)
            {
                SiteVO selectedSite = SiteLookUpEdit.GetSelectedDataRow() as SiteVO;
                if (selectedSite != null && selectedSite.PersonAndSitelist.Count > 0)
                {
                    SiteEngineerLookUpEdit.EditValue = selectedSite.PersonAndSitelist.Where(x => x.ResponsibilityTypeID == 2).ToList().Select(x=>x.PersonID).FirstOrDefault();
                    SeniorInchargeLookUpEdit.EditValue = selectedSite.PersonAndSitelist.Where(x => x.ResponsibilityTypeID == 1).ToList().Select(x => x.PersonID).FirstOrDefault();
                }
                txtOrderNo.Text = service.GetNewOrderNo(siteID);
            }
            //else  if (engineerID != 0 && siteID != 0)
            //{
            //    txtOrderNo.Text = service.GetNewOrderNo(siteID);
            //}
            else
            {
                SiteEngineerLookUpEdit.EditValue = null;
                SeniorInchargeLookUpEdit.EditValue = null;
                txtOrderNo.Text = string.Empty;
            }
        }

        private void SiteEngineerLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
               //int engineerID = Convert.ToInt32(SiteEngineerLookUpEdit.EditValue);
               //int siteID = Convert.ToInt32(SiteLookUpEdit.EditValue);
               //if (engineerID != 0 && siteID != 0)
               //{
               //    txtOrderNo.Text = service.GetNewOrderNo(siteID );
               //}
               //else
               //{
               //    txtOrderNo.Text = string.Empty;
               //}
        }

        #region Master Schedule PDF

        private void UploadSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton button = sender as SimpleButton;
                uploadlabel = (string)button.Tag;

                MasterUploadlabel.Text = "Upload 0%";
                MasterUploadProgressBar.Value = 0;

                ContractUploadlabel.Text = "Upload 0%";
                ContractUploadProgressBar.Value = 0;

                using (OpenFileDialog open = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "PDF file |*.pdf" })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(open.FileName);
                        if ((string)button.Tag == "Master")
                        {
                            _inputParameter.Server = @"ftp://13.76.132.123/ISOPDF/MasterSchedulePDF";
                        }
                        else if ((string)button.Tag == "Contract")
                        {
                            _inputParameter.Server = @"ftp://13.76.132.123/ISOPDF/ContractPDF";
                        }
                        _inputParameter.Username = "ftpuser";
                        _inputParameter.Password = "P@ssw0rd";

                        _inputParameter.fileName = fi.Name;
                        _inputParameter.fullName = fi.FullName;

                        backgroundWorker1.RunWorkerAsync();
                        isupload = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName = _inputParameter.fileName;
                string fullName = _inputParameter.fullName;
                string username = _inputParameter.Username;
                string password = _inputParameter.Password;
                string server = _inputParameter.Server;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = false;
                request.KeepAlive = true;
                Stream ftpstream = request.GetRequestStream();
                FileStream fs = File.OpenRead(fullName);
                byte[] buffer = new byte[1024];
                double total = (double)fs.Length;
                int byteRead = 0;
                double read = 0;
                do
                {
                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpstream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker1.ReportProgress((int)percentage);
                }
                while (byteRead != 0);
                fs.Close();
                ftpstream.Close();
                //string name = string.Format("{0}{1}.pdf", fileName.Split('.')[0], DateTime.Now.ToString("(dd-MM-yy hh-mm-ss)"));
                fileName = fileName.Split('.')[0];
                string fname = (fileName.Length > 10) ? fileName.Substring(0, 10) : fileName.Split('.')[0];
                string name = string.Format("{0}{1}.pdf", fname, DateTime.Now.ToString("(dd-MM-yy hh-mm-ss)"));
                RenameFile(fileName, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RenameFile(string currentFileNameAndPath, string newFileName)
        {
            try
            {
                FtpWebRequest ftpRequest = null;

                if (uploadlabel == "Master")
                {
                    ftpRequest = (FtpWebRequest)WebRequest.Create(@"ftp://13.76.132.123/ISOPDF/MasterSchedulePDF/" + _inputParameter.fileName);
                }
                else if (uploadlabel == "Contract")
                {
                    ftpRequest = (FtpWebRequest)WebRequest.Create(@"ftp://13.76.132.123/ISOPDF/ContractPDF/" + _inputParameter.fileName);
                }
                ftpRequest.Credentials = new NetworkCredential(_inputParameter.Username, _inputParameter.Password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = newFileName;
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpRequest = null;
                _inputParameter.fileName = newFileName;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (MasterUploadProgressBar.Value == 100 || ContractUploadProgressBar.Value == 100)
            {
                if (uploadlabel == "Master")
                {
                    MasterUploadlabel.Text = "upload completed !";
                }
                else if (uploadlabel == "Contract")
                {
                    ContractUploadlabel.Text = "upload completed !";
                }

                #region Download PDF Icon

                var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                //string path = Path.Combine(windowsPath, "TempPDFFile");
                string path = Path.Combine(windowsPath, "ISOPDFFile");
                string pdficon = Path.Combine(path, "pdf icon.png");
                if (!File.Exists(pdficon))
                {
                    DownloadFile(@"ftp://13.76.132.123/ISOPDF", "pdf icon.png", path);
                }
                Image img = Image.FromFile(pdficon);
                if (uploadlabel == "Master")
                {
                    MasterPDFgroup.Items.Add(new GalleryItem(ScaleImage(img, 350, 350), _inputParameter.fileName, null));
                    MessageBox.Show("Master Schedule PDF upload successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //UploadSimpleButton.Enabled = (MasterPDFgroup.Items.Count < 2) ? true : false;
                }
                else if (uploadlabel == "Contract")
                {
                    ContractPDFgroup.Items.Add(new GalleryItem(ScaleImage(img, 350, 350), _inputParameter.fileName, null));
                    MessageBox.Show("Contract PDF upload successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //UploadSimpleButton1.Enabled = (ContractPDFgroup.Items.Count < 2) ? true : false;
                }

                #endregion
            }
            else
            {
                MessageBox.Show("PDF upload unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (uploadlabel == "Master")
            {
                MasterUploadlabel.Text = "Uploaded " + (e.ProgressPercentage) + " %";
                MasterUploadProgressBar.Value = e.ProgressPercentage;
                MasterUploadProgressBar.Update();
            }
            else if (uploadlabel == "Contract")
            {
                ContractUploadlabel.Text = "Uploaded " + (e.ProgressPercentage) + " %";
                ContractUploadProgressBar.Value = e.ProgressPercentage;
                ContractUploadProgressBar.Update();
            }
        }

        public string DownloadFile(string FtpUrl, string FileNameToDownload, string tempDirPath)
        {
            string ResponseDescription = "";
            string PureFileName = new FileInfo(FileNameToDownload).Name;
            string DownloadedFilePath = tempDirPath + "/" + PureFileName;
            string downloadUrl = String.Format("{0}/{1}", FtpUrl, FileNameToDownload);

            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(downloadUrl);
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            req.Credentials = new NetworkCredential(_inputParameter.Username, _inputParameter.Password);
            req.UseBinary = true;
            req.UsePassive = false;
            req.Proxy = null;
            try
            {
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream fs = new FileStream(DownloadedFilePath, FileMode.Create);
                int ReadCount = stream.Read(buffer, 0, buffer.Length);
                while (ReadCount > 0)
                {
                    fs.Write(buffer, 0, ReadCount);
                    ReadCount = stream.Read(buffer, 0, buffer.Length);
                }
                ResponseDescription = response.StatusDescription;
                fs.Close();
                stream.Close();

                //File.Delete(tempDirPath + FileNameToDownload);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ResponseDescription;
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
            newImage.Save("img", ImageFormat.Png);

            return newImage;
        }

        private void RemoveSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton button = sender as SimpleButton;
                if (MasterPDFgroup.Items.Count > 0 || ContractPDFgroup.Items.Count > 0)
                {
                    if ((string)button.Tag == "Master")
                    {
                        foreach (GalleryItem item in MasterPDFgroup.Items)
                        {
                            if (item.Checked == true)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Are you sure to remove?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    uploadlabel = (string)button.Tag;
                                    RemovePDFFile(item.Caption);

                                    MasterUploadlabel.Text = "Upload 0%";
                                    MasterUploadProgressBar.Value = 0;
                                    MessageBox.Show("File remove successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    UploadSimpleButton.Enabled = true;
                                    MasterPDFgroup.Items.RemoveAt(MasterPDFgroup.Items.IndexOf(item));                         
                                    break;
                                }
                            }
                        }
                    }
                    else if ((string)button.Tag == "Contract")
                    {
                        foreach (GalleryItem item in ContractPDFgroup.Items)
                        {
                            if (item.Checked == true)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Are you sure to remove?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    uploadlabel = (string)button.Tag;
                                    RemovePDFFile(item.Caption);
                              
                                    ContractUploadlabel.Text = "Upload 0%";
                                    ContractUploadProgressBar.Value = 0;
                                    MessageBox.Show("File remove successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    UploadSimpleButton.Enabled = true;
                                    ContractPDFgroup.Items.RemoveAt(ContractPDFgroup.Items.IndexOf(item));
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("Please select PDF File!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private string RemovePDFFile(string filename)
        {
            try
            {
                //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://13.76.132.123/ISOPDF/MasterSchedulePDF/" + _inputParameter.fileName);
                FtpWebRequest request = null;
                if (uploadlabel == "Master")
                {
                    request = (FtpWebRequest)WebRequest.Create(@"ftp://13.76.132.123/ISOPDF/MasterSchedulePDF/" + filename);
                }
                else if (uploadlabel == "Contract")
                {
                    request = (FtpWebRequest)WebRequest.Create(@"ftp://13.76.132.123/ISOPDF/ContractPDF/" + filename);
                }
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential("ftpuser", "P@ssw0rd");
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    if (selectedOOR.OORID != 0)
                    {
                        isupload = null;
                    }
                    return response.StatusDescription;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ViewSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton button = sender as SimpleButton;
                if (MasterPDFgroup.Items.Count > 0 || ContractPDFgroup.Items.Count > 0)
                {
                    if ((string)button.Tag == "Master")
                    {
                        foreach (GalleryItem item in MasterPDFgroup.Items)
                        {
                            if (item.Checked == true)
                            {
                                var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                                string path = Path.Combine(windowsPath, "ISOPDFFile\\");                       
                                PDFViewerForm pdfViewer = new PDFViewerForm(@"ftp://13.76.132.123/ISOPDF/MasterSchedulePDF", item.Caption, path);
                                pdfViewer.ShowDialog();        
                            }
                        }
                     }
                    else if ((string)button.Tag == "Contract")
                    {
                        foreach (GalleryItem item in ContractPDFgroup.Items)
                        {
                            if (item.Checked == true)
                            {
                                var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                                string path = Path.Combine(windowsPath, "ISOPDFFile\\");
                                PDFViewerForm pdfViewer = new PDFViewerForm(@"ftp://13.76.132.123/ISOPDF/ContractPDF", item.Caption, path);
                                pdfViewer.ShowDialog();
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("Please select PDF File!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OORGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(isupload == null)
                {
                    throw new Exception("Please save to update selected order registration!");
                }
                ClearData();
                GridView dgv = OORGridControl.FocusedView as GridView;
                this.selectedOOR = dgv.GetRow(dgv.FocusedRowHandle) as OperationOrderRegVO;
                if (this.selectedOOR != null)
                {
                    OrderDateEdit.EditValue = this.selectedOOR.OrderDate;
                    SiteLookUpEdit.EditValue = this.selectedOOR.SiteID;
                    BuildingTypeLookUpEdit.EditValue = this.selectedOOR.BuildingTypeId;
                    SiteEngineerLookUpEdit.EditValue = this.selectedOOR.SiteEngineerID;
                    SeniorInchargeLookUpEdit.EditValue = this.selectedOOR.SeniorInchargeID;
                    StoreKeeperLookUpEdit.EditValue = this.selectedOOR.StoreKeeperID;
                    StartingDateEdit.EditValue = this.selectedOOR.StartingDate;
                    RemarkRichTextBox.Text = this.selectedOOR.Remark;
                    txtOrderNo.Text = this.selectedOOR.OrderNo;

                    #region Download PDF Icon

                    var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                    string path = Path.Combine(windowsPath, "ISOPDFFile");
                    string pdficon = Path.Combine(path, "pdf icon.png");
                    if (!File.Exists(pdficon))
                    {
                        DownloadFile(@"ftp://13.76.132.123/ISOPDF", "pdf icon.png", path);
                    }
                    Image img = Image.FromFile(pdficon);
                    foreach (MasterSchedulePDFVO item in this.selectedOOR.MasterSchedulePDFList)
                    {
                        MasterPDFgroup.Items.Add(new GalleryItem(ScaleImage(img, 350, 350), item.MasterSchedulePDF, null));
                    }
                    foreach (ContractPDFVO item in this.selectedOOR.ContractPDFList)
                    {
                        ContractPDFgroup.Items.Add(new GalleryItem(ScaleImage(img, 350, 350), item.ContractPDF, null));
                    }
                    isupload = true;

                    #endregion

                    txtOrderNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        private void OperationOrderRegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isupload == false)
                {
                    if (MasterPDFgroup.Items.Count > 0 || ContractPDFgroup.Items.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are you sure to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            foreach (GalleryItem item in MasterPDFgroup.Items)
                            {
                                int count = selectedOOR.MasterSchedulePDFList.Where(x => x.MasterSchedulePDF == item.Caption).Count();
                                if (count > 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    uploadlabel = "Master";
                                    RemovePDFFile(item.Caption);
                                }
                            }
                            foreach (GalleryItem item in ContractPDFgroup.Items)
                            {
                                int count = selectedOOR.ContractPDFList.Where(x => x.ContractPDF == item.Caption).Count();
                                if (count > 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    uploadlabel = "Contract";
                                    RemovePDFFile(item.Caption);
                                }
                            }
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }      
                }
                else if(isupload == null)
                {
                    throw new Exception("Please save to update selected order registration!");
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}