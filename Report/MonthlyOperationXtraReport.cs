using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ISOServiceVO;
using System.Linq;

namespace ISOFormat.Report
{
    public partial class MonthlyOperationXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
         public MonthlyOperationXtraReport()
        {
            InitializeComponent();
        }

        //private void MonthlyOperationXtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    //var report = sender as XtraReport;
        //    //List<XRTableRow> tablelist = report.AllControls<XRTableRow>().Select(x => x).ToList();

        //    //XRTableRow tableRow = report.AllControls<XRTableRow>().Where(x => x.Tag == "Row3").Select(x => x).FirstOrDefault();
        //    //XRTableRow table1 = tablelist.Where(x => x.Tag == "Row3").FirstOrDefault();
        //    //List<XRTableCell> celllist = table1.AllControls<XRTableCell>().Select(x => x).ToList();
        //    //XRTableRow table2 = tablelist.Where(x => x.Tag == "Row7").FirstOrDefault();
        //    //List<XRTableRow> rowlist = table.AllControls<XRTableRow>().Where(x => x.Name == "Table3").Select(x => x)
        //    //xrTable3.InsertRowBelow(xrTable3.Rows[i]);
        //    //List<DateTime> dateList = Enumerable.Range(0, 19 + 1).Select(x => DateTime.Now.AddDays(x)).ToList();
        //    //dateList = dateList.OrderBy(x => x.Day).ToList();
        //    //dateList.RemoveAt(3);
        //    //Console.WriteLine(dateList);
        //    //Plan_BeforePrint(cell, e);
        //    //if (cell != null && plan.Date.Day == Convert.ToInt32(cell.Tag) && plan.MPDID == detail.MOPDID && plan.NameOfWork == detail.NameOfWork)
        //    //    cell.BackColor = Color.Black;
        //}

        //private void MonthlyOperationXtraReport_AfterPrint(object sender, EventArgs e)
        //{
        //    //List<XRTableRow> rowlist = xrTable3.AllControls<XRTableRow>().Where(x => x.Table.Name == "xrTable3").ToList();
        //    ////int count = rowlist.Count;

        //    //int i = 1;
        //    //foreach (MonthlyPlanSummaryVO detail in selectedlist)
        //    //{
        //    //    foreach (PlanDateVO plan in detail.PlanDateList)
        //    //    {
        //    //        string name = string.Format("P{0}", plan.Date.Day);
        //    //        XRTableRow row = xrTable3.Rows[i];
        //    //        List<XRTableCell> celllist = xrTable3.Rows[i].AllControls<XRTableCell>().Select(x => x).ToList();
        //    //        XRTableCell cell = celllist.Where(x => x.Text == name).FirstOrDefault();
        //    //        if (cell != null)
        //    //            Actual_BeforePrint(cell, e as System.Drawing.Printing.PrintEventArgs);
        //    //    }
        //    //    i++;
        //        //foreach (ActualDateVO actual in detail.ActualDateList)
        //        //{
        //        //    string name = string.Format("A{0}", actual.Date.Day);
        //        //    XRTableRow row = xrTable3.Rows[i];
        //        //    List<XRTableCell> celllist = xrTable3.Rows[i].AllControls<XRTableCell>().Select(x => x).ToList();
        //        //    XRTableCell cell = celllist.Where(x => x.Text == name).FirstOrDefault();
        //        //    if (cell != null)
        //        //     xrTable3.Rows[i].Cells[actual.Date.Day].BackColor = Color.Black;
        //        //}
        //    //}
        //}

         //private void Date_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
         //{
         //    XRTableCell cell = sender as XRTableCell;
         //    string name = cell.Name;
         //    if (!string.IsNullOrEmpty(cell.Text) && cell.Text == "True") cell.BackColor = Color.Red;
         //    else cell.BackColor = Color.Transparent;
         //}

        private void PlanDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            string name = cell.Name;
            if (!string.IsNullOrEmpty(cell.Text) && cell.Text == "True") cell.BackColor = Color.Green;
            else cell.BackColor = Color.Transparent;
        }

        private void ActualDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = sender as XRTableCell;
            string name = cell.Name;
            if (!string.IsNullOrEmpty(cell.Text) && cell.Text == "True") cell.BackColor = Color.Gray;
            else cell.BackColor = Color.Transparent;
        }
    }
}
