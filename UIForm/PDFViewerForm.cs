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
using System.Net;

namespace ISOFormat.UIForm
{
    public partial class PDFViewerForm : DevExpress.XtraEditors.XtraForm
    {
        public PDFViewerForm(string FtpUrl, string FileNameToDownload, string tempDirPath)
        {
            InitializeComponent();

            #region Download

            string ResponseDescription = "";
            string PureFileName = new FileInfo(FileNameToDownload).Name;
            string DownloadedFilePath = tempDirPath + "/" + PureFileName;
            string downloadUrl = String.Format("{0}/{1}", FtpUrl, FileNameToDownload);

            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(downloadUrl);
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            req.Credentials = new NetworkCredential("ftpuser", "P@ssw0rd");
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
                pdfViewer1.LoadDocument(fs);
                fs.Close();
                stream.Close();

                File.Delete(tempDirPath + FileNameToDownload);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //return ResponseDescription;

            #endregion
        }
    }
}