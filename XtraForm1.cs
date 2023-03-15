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
using ISOFormat.Service_ISO;

namespace ISOFormat
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        SOIServiceClient service;

        public XtraForm1()
        {
            InitializeComponent();
            this.service = new SOIServiceClient();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            var temp = service.GetAllUser();
            Console.WriteLine(temp);
        }
    }
}