using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ISOServiceVO;
using System.Collections.Generic;
using System.Linq;

namespace ISOFormat.Report
{
    public partial class WeeklyOperationXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public WeeklyOperationXtraReport()
        {
            InitializeComponent();
        }

        public WeeklyOperationXtraReport(DateTime from)
        {
            InitializeComponent();
            var number = (from.Day)/8 +1;
            string week = weekname(number);
            //TitleWeekParam.Value = string.Format("of {0}-Month",from.ToString("MMM"));
            TitleWeekParam.Value = string.Format("{0} Week of {1}-Month", week, from.ToString("MMM"));
            FromDate.Value = from;
            ToDate.Value = from.AddDays(6);
        }

        string weekname(int n)
        {
            switch (n)
            {
                case 1: return n + "st";
                case 2: return n + "nd";
                case 3: return n + "rd";
                default: return n + "th";
            }
        }

        private void PlanDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            string name = cell.Name;
            if (!string.IsNullOrEmpty(cell.Text) && cell.Text != "0") cell.BackColor = Color.Red;
            else if (cell.Text == "0")
            {
                cell.BackColor = Color.Red;
                cell.ForeColor = Color.Transparent;
            }
            else cell.BackColor = Color.Transparent;
        }

        private void ActualDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)         
        {
            XRTableCell cell = sender as XRTableCell;
            string name = cell.Name;
            if (!string.IsNullOrEmpty(cell.Text) && cell.Text != "0") cell.BackColor = Color.Red;
            else if (cell.Text == "0")
            {
                cell.BackColor = Color.Red;
                cell.ForeColor = Color.Transparent;
            }
            else cell.BackColor = Color.Transparent;
        }

    }
}
