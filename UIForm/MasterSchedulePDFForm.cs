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
using System.IO;
using System.Security.AccessControl;
using DevExpress.XtraBars.Ribbon;

namespace ISOFormat.UIForm
{
    public partial class MasterSchedulePDFForm : DevExpress.XtraEditors.XtraForm
    {
        private GalleryItemGroup PDFgroup;

        public MasterSchedulePDFForm()
        {
            InitializeComponent();
            this.PDFgroup = new GalleryItemGroup();
            this.backgroundWorker1 = new BackgroundWorker();
            //this.backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.WorkerReportsProgress = true;
        }

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        //string fileName = _inputParameter.fileName;
        //        //string fullName = _inputParameter.fullName;
        //        //string username = _inputParameter.Username;
        //        //string password = _inputParameter.Password;
        //        //string server = _inputParameter.Server;
        //        //FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
        //        //request.Method = WebRequestMethods.Ftp.UploadFile;
        //        //request.Credentials = new NetworkCredential(username, password);
        //        //request.UsePassive = false;
        //        //request.KeepAlive = true;
        //        Stream ftpstream = request.GetRequestStream();
        //        FileStream fs = File.OpenRead(fullName);
        //        byte[] buffer = new byte[1024];
        //        double total = (double)fs.Length;
        //        int byteRead = 0;
        //        double read = 0;
        //        do
        //        {
        //            //if (backgroundWorker1.CancellationPending)
        //            //{
        //            byteRead = fs.Read(buffer, 0, 1024);
        //            ftpstream.Write(buffer, 0, byteRead);
        //            read += (double)byteRead;
        //            double percentage = read / total * 100;
        //            backgroundWorker1.ReportProgress((int)percentage);
        //            //}
        //        }
        //        while (byteRead != 0);
        //        fs.Close();
        //        ftpstream.Close();
        //        string name = string.Format("{0}{1}.pdf", fileName.Split('.')[0], DateTime.Now.ToString("(dd-MM-yy hh-mm-ss)"));
        //        //RenameFile(fileName, name);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Uploadlabel.Text = "Uploaded " + (e.ProgressPercentage) + " %";
            UploadProgressBar.Value = e.ProgressPercentage;
            UploadProgressBar.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (UploadProgressBar.Value == 100)
            {
                Uploadlabel.Text = "upload completed !";

                //#region Download PDF Icon

                //var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                //string path = Path.Combine(windowsPath, "TempPDFFile");
                //string pdficon = Path.Combine(path, "pdf icon.png");
                //if (!File.Exists(pdficon))
                //{
                //    DownloadFile(@"ftp://13.76.132.123/ContractPDF", "pdf icon.png", path);
                //}
                //Image img = Image.FromFile(pdficon);
                //PDFgroup.Items.Add(new GalleryItem(ScaleImage(img, 350, 350), _inputParameter.fileName, null));

                //#endregion

                MessageBox.Show("Upload successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UploadSimpleButton.Enabled = (PDFgroup.Items.Count < 2) ? true : false;
            }
            else
            {
                MessageBox.Show("BOQPDF upload unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UploadSimpleButton_Click(object sender, EventArgs e)
        {
            #region Create Folder Path

            //var windowsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows); 
            var windowsPath = @"D:\";   
            string path = Path.Combine(windowsPath, "ISOPDFFile");
            DirectorySecurity securityRules = new DirectorySecurity();
            securityRules.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path, securityRules);
                Directory.SetAccessControl(path, securityRules);
            }

            #endregion

            OpenFileDialog result = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "PDF file |*.pdf" };
            if (result.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(result.FileName);
                string destFile = System.IO.Path.Combine(path, file.Name);
                File.Copy(result.FileName, destFile);
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void MasterSchedulePDFForm_Load(object sender, EventArgs e)
        {

        }
    }
}