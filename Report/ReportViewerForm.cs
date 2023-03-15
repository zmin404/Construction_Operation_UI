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
using DevExpress.XtraNavBar;
using ISOServiceVO;
using ISOService_API;
using DevExpress.XtraReports.UI;
using System.ServiceModel;
using DevExpress.XtraPrinting;

namespace ISOFormat.Report
{
    public partial class ReportViewerForm : DevExpress.XtraEditors.XtraForm
    {
        UserVO currentUser;
        ISOIService service;
        String paramTitle = String.Empty;
        private string PleaseSelect;

        public string fromForm = "";

        XtraReport report = null;

        public DateTime fromDate = DateTime.Now;
        public DateTime toDate = DateTime.Now;

        public ReportViewerForm(ISOIService s, UserVO u)
        {
            InitializeComponent();
            this.currentUser = u;
            this.service = s;
            this.PleaseSelect = "--Please Select--"; 
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            SetNavBarGroupDefault();
        }

        private void SetNavBarGroupDefault()
        {
            for (int i = 0; i < ReportNavBarControl.Groups.Count; i++)
            {
                NavBarGroup group = ReportNavBarControl.Groups[i];
                group.Expanded = false;
            }
        }

        private void SetDisableAll()
        {
            SetDisableDateInfo();
            SetDisableMonthDateInfo();
            SetDisableSearchInfoGroupControl();
            MonthInfoGroupControl.Visible = false;
        }

        private void SetDisableDateInfo()
        {
            DateInfoGroupControl.Height = 20;
            DateInfoGroupControl.Visible = false;
            FromDateEdit.Enabled = false;
            ToDateEdit.Enabled = false;
        }

        private void SetEnableDateInfo()
        {
            DateInfoGroupControl.Location = new System.Drawing.Point(12, 3);
            DateInfoGroupControl.Height = 90;
            DateInfoGroupControl.Visible = true;
            FromDateEdit.Enabled = true;
            FromDateEdit.DateTime = DateTime.Now;
            ToDateEdit.Enabled = true;
            ToDateEdit.DateTime = DateTime.Now;
        }

        private void SetEnableDateInfo1() 
        {
            DateInfoGroupControl.Location = new System.Drawing.Point(12, 3);
            DateInfoGroupControl.Height = 90;
            DateInfoGroupControl.Visible = true;
            FromDateEdit.Enabled = true;
            FromDateEdit.DateTime = DateTime.Now;
            ToDateEdit.Enabled = false;
            ToDateEdit.DateTime = DateTime.Now;
        }

        private void SetDisableSearchInfoGroupControl()
        {
            SearchBySiteNameCheckEdit.Enabled = false;
            SearchByBuildingTypeCheckEdit.Enabled = false;
            SearchByOrderNoCheckEdit.Enabled = false;

            SearchByBuildingTypeCheckEdit.Visible = false;
            SearchBySiteNameCheckEdit.Visible = false;
            SearchByOrderNoCheckEdit.Visible = false;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.EditValue = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;
            SearchLookUpEdit.Visible = false;
            SearchLookUpEdit.Properties.ValueMember = "ID";
            SearchInfoGroupControl.Visible = false;
        }

        private void UncheckAllSearchCheckBox()
        {
            SearchBySiteNameCheckEdit.Checked = false;
            SearchByOrderNoCheckEdit.Checked = false;
            SearchByBuildingTypeCheckEdit.Checked = false;
        }


        private void SetEnableMonthDateInfo()
        {
            MonthInfoGroupControl.Location = new System.Drawing.Point(3, 3);
            MonthInfoGroupControl.Height = 70;
            MonthInfoGroupControl.Visible = true;
            SearchMonthDateEdit.Enabled = true;
        }

        private void SetDisableMonthDateInfo()   
        {
            MonthInfoGroupControl.Height = 20;
            MonthInfoGroupControl.Visible = false;
            SearchMonthDateEdit.Enabled = false;
        }

        private void SetEnableSearchGroupBox(CheckEdit chk, GroupControl grp)
        {
            if (grp == null)
            {
                SearchInfoGroupControl.Location = new System.Drawing.Point(11, 2);
            }
            else
            {
                SearchInfoGroupControl.Top = grp.Bottom + 5;
            }

            chk.Checked = false;
            chk.Enabled = true;
            chk.Visible = true;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;
            SearchLookUpEdit.Visible = true;

            chk.Top = 31;
            SearchLookUpEdit.Top = chk.Bottom + 3;
            SearchLookUpEdit.Visible = true;

            SearchInfoGroupControl.Visible = true;
            SearchInfoGroupControl.Height = 91;
        }

        private void SetEnableSearchGroupBox(CheckEdit chk1, CheckEdit chk2, GroupControl grp)
        {
            if (grp == null)
            {
                SearchInfoGroupControl.Location = new System.Drawing.Point(11, 2);
            }
            else
            {
                SearchInfoGroupControl.Top = grp.Bottom + 5;
            }

            chk1.Checked = false;
            chk1.Enabled = true;
            chk1.Visible = true;

            chk2.Checked = false;
            chk2.Enabled = true;
            chk2.Visible = true;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;

            //chk1.Location = new System.Drawing.Point(30, 31);
            chk1.Top = 30;
            chk2.Top = chk1.Bottom + 3;
            SearchLookUpEdit.Top = chk2.Bottom + 3;
            SearchLookUpEdit.Visible = true;

            SearchInfoGroupControl.Visible = true;
            SearchInfoGroupControl.Height = 115;
        }

        private void SetEnableSearchGroupBox(CheckEdit chk1, CheckEdit chk2, CheckEdit chk3, GroupControl grp)
        {
            if (grp == null)
            {
                SearchInfoGroupControl.Location = new System.Drawing.Point(11, 2);
            }
            else
            {
                SearchInfoGroupControl.Top = grp.Bottom + 5;
            }

            chk1.Checked = false;
            chk1.Enabled = true;
            chk1.Visible = true;

            chk2.Checked = false;
            chk2.Enabled = true;
            chk2.Visible = true;

            chk3.Checked = false;
            chk3.Enabled = true;
            chk3.Visible = true;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;

            chk1.Top = 30;
            chk2.Top = chk1.Bottom + 3;
            chk3.Top = chk2.Bottom + 3;
            SearchLookUpEdit.Top = chk3.Bottom + 3;
            SearchLookUpEdit.Visible = true;

            SearchInfoGroupControl.Visible = true;
            SearchInfoGroupControl.Height = 140;
        }

        private void SetEnableSearchGroupBox(CheckEdit chk1, CheckEdit chk2, CheckEdit chk3, CheckEdit chk4, GroupControl grp)
        {
            if (grp == null)
            {
                SearchInfoGroupControl.Location = new System.Drawing.Point(11, 3);
            }
            else
            {
                SearchInfoGroupControl.Top = grp.Bottom + 5;
            }

            chk1.Checked = false;
            chk1.Enabled = true;
            chk1.Visible = true;

            chk2.Checked = false;
            chk2.Enabled = true;
            chk2.Visible = true;

            chk3.Checked = false;
            chk3.Enabled = true;
            chk3.Visible = true;

            chk4.Checked = false;
            chk4.Enabled = true;
            chk4.Visible = true;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;

            chk1.Top = 30;
            chk2.Top = chk1.Bottom + 3;
            chk3.Top = chk2.Bottom + 3;
            chk4.Top = chk3.Bottom + 3;
            SearchLookUpEdit.Top = chk4.Bottom + 3;
            SearchLookUpEdit.Visible = true;

            SearchInfoGroupControl.Visible = true;
            SearchInfoGroupControl.Height = 165;
        }

        private void SetEnableSearchGroupBox(CheckEdit chk1, CheckEdit chk2, CheckEdit chk3, CheckEdit chk4, CheckEdit chk5, GroupControl grp)
        {
            if (grp == null)
            {
                SearchInfoGroupControl.Location = new System.Drawing.Point(11, 2);
            }
            else
            {
                SearchInfoGroupControl.Top = grp.Bottom + 5;
            }

            chk1.Checked = false;
            chk1.Enabled = true;
            chk1.Visible = true;

            chk2.Checked = false;
            chk2.Enabled = true;
            chk2.Visible = true;

            chk3.Checked = false;
            chk3.Enabled = true;
            chk3.Visible = true;

            chk4.Checked = false;
            chk4.Enabled = true;
            chk4.Visible = true;

            chk5.Checked = false;
            chk5.Enabled = true;
            chk5.Visible = true;

            SearchLookUpEdit.Properties.DataSource = null;
            SearchLookUpEdit.Text = "";
            SearchLookUpEdit.Enabled = false;

            chk1.Top = 30;
            chk2.Top = chk1.Bottom + 3;
            chk3.Top = chk2.Bottom + 3;
            chk4.Top = chk3.Bottom + 3;
            chk5.Top = chk4.Bottom + 3;
            SearchLookUpEdit.Top = chk5.Bottom + 3;
            SearchLookUpEdit.Visible = true;

            SearchInfoGroupControl.Visible = true;
            SearchInfoGroupControl.Height = 180;
        }

        private void ReportNavBarControl_MouseClick(object sender, MouseEventArgs e)
        {
            var hitInfo = ReportNavBarControl.CalcHitInfo(e.Location);


            if (hitInfo.InGroupCaption)
            {
                foreach (NavBarGroup group in ReportNavBarControl.Groups)
                {
                    group.Appearance.ForeColor = Color.Black;
                    group.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                if (hitInfo.Group.Expanded)
                {
                    hitInfo.Group.Appearance.ForeColor = Color.Blue;
                    hitInfo.Group.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private void ReportNavBarControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NavBarControl navBar = sender as NavBarControl;
                NavBarHitInfo hitInfo = navBar.CalcHitInfo(new Point(e.X, e.Y));
                if (hitInfo.InGroupCaption && !hitInfo.InGroupButton)
                    hitInfo.Group.Expanded = !hitInfo.Group.Expanded;
            }
        }

        private void ReportNavBarControl_CustomDrawLink(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e)
        {
            DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs info = e.ObjectInfo as DevExpress.XtraNavBar.ViewInfo.NavLinkInfoArgs;
            if (info.State == DevExpress.Utils.Drawing.ObjectState.Selected | info.State == DevExpress.Utils.Drawing.ObjectState.Pressed)
            {
                e.Graphics.FillRectangle(Brushes.Orange, e.ObjectInfo.Bounds);
                if (e.Image != null)
                    e.Graphics.DrawImage(e.Image, info.ImageRectangle);
                e.Appearance.DrawString(e.Cache, info.Link.Caption, info.CaptionRectangle);
                e.Handled = true;
            }
        }

        public void NavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                NavBarItem item = sender as NavBarItem;
                SearchTitleIDLabelControl.Text = item.Name.ToString();

                SetDisableAll();

                switch (item.Name.ToString())
                {
                    case "OORNavBarItem":
                        SetEnableDateInfo();
                        SetEnableSearchGroupBox(SearchByBuildingTypeCheckEdit, SearchByOrderNoCheckEdit, SearchBySiteNameCheckEdit, DateInfoGroupControl);
                        break;
                    case "OONavBarItem":
                        SetDisableDateInfo();
                        SetEnableSearchGroupBox(SearchByOrderNoCheckEdit, null);
                        break;
                    case "MonthlyOperationPlanReportNavBarItem":
                        SetEnableMonthDateInfo();
                        //SetDisableMonthDateInfo();
                        SetEnableSearchGroupBox(SearchBySiteNameCheckEdit,MonthInfoGroupControl);
                        break;
                    case "WeeklyOperationInstructionReportNavBarItem":
                        SetEnableDateInfo1();
                        SetEnableSearchGroupBox(SearchBySiteNameCheckEdit, DateInfoGroupControl);
                        break;
                    case "DailyJobAssignmentReportNavBarItem":
                        SetEnableDateInfo1();
                        SetEnableSearchGroupBox(SearchBySiteNameCheckEdit, DateInfoGroupControl);
                        break;
                    case "DailyJobActualAssignmentReportNavBarItem":
                        SetEnableDateInfo1();
                        SetEnableSearchGroupBox(SearchBySiteNameCheckEdit, DateInfoGroupControl);
                        break;
                    default:
                        break;
                }
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(string.Format("Timeout exception! Message: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException<ServerSvcFault> ex)
            {
                MessageBox.Show(string.Format("Reason: {0}! Message: {1}", ex.Message, ex.Detail.FaultMessage), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FaultException ex)
            {
                MessageBox.Show(string.Format("Unknown Fault! Message: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CommunicationException)
            {
                MessageBox.Show("Failed to connect to server! Please exit the application and sign in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Unknown exception! {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private XtraReport ShowReportPreview(XtraReport report)
        {
            DisableReportToolbarButton(report);

            return report;
        }

        private void DisableReportToolbarButton(DevExpress.XtraReports.IReport report)
        {
            ReportPrintTool printTool = new ReportPrintTool(report);
            PrintingSystemBase printSystem = printTool.PrintingSystem;

            //Hide toolbar button, and also menu item.

            printSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.PageSetup, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.ExportFile, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.SendFile, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.View, CommandVisibility.None);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None);

            //printTool.PreviewForm.MainMenuStrip.Hide();
        }

        private void EnableReportToolbarButton(DevExpress.XtraReports.IReport report) 
        {
            ReportPrintTool printTool = new ReportPrintTool(report);
            PrintingSystemBase printSystem = printTool.PrintingSystem;

            //Hide toolbar button, and also menu item.

            printSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.PageSetup, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Scale, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.ExportFile, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.SendFile, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.View, CommandVisibility.All);
            printSystem.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.All);

            //printTool.PreviewForm.MainMenuStrip.Hide();
        }

         private void CloseSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void SearchSimpleButton_Click(object sender, EventArgs e)
         {
             try
             {
                 paramTitle = "";
                 string search = SearchTitleIDLabelControl.Text;

                 switch (search)
                 {
                     case "OORNavBarItem":
                         SearchOperationOrderReg();
                         break;

                     case "OONavBarItem":
                        if (SearchByOrderNoCheckEdit.Checked == false )
                        {
                            MessageBox.Show("Please Select Order No. !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (Convert.ToInt32(SearchLookUpEdit.EditValue) == 0)
                            {
                                MessageBox.Show("Please Select Order No!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        SearchOperationOrder();
                         break;

                     case "MonthlyOperationPlanReportNavBarItem":
                         if (SearchMonthDateEdit.EditValue == null)
                         {
                             MessageBox.Show("Please Select Month & Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             return;
                         }
                        else
                        {
                            if (Convert.ToInt32(SearchLookUpEdit.EditValue) == 0)
                            {
                                MessageBox.Show("Please Select Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        SearchByMonthlyOperation(); break;
                     case "WeeklyOperationInstructionReportNavBarItem":
                         if (FromDateEdit.DateTime == DateTime.MinValue)
                         {
                             MessageBox.Show("Please Select From Date & Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             return;
                         }
                        else
                        {
                            if (Convert.ToInt32(SearchLookUpEdit.EditValue) == 0)
                            {
                                MessageBox.Show("Please Select Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                         SearchByWeeklyOperation();
                         break;
                     case "DailyJobAssignmentReportNavBarItem":
                         if (FromDateEdit.DateTime == DateTime.MinValue)
                         {
                             MessageBox.Show("Please Select Date & Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             return;
                         }
                         else
                         {
                             if (Convert.ToInt32(SearchLookUpEdit.EditValue) == 0)
                             {
                                 MessageBox.Show("Please Select Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                 return;
                             }
                         }
                          SearchByDailyOperation();
                         break;
                    case "DailyJobActualAssignmentReportNavBarItem":
                        if (FromDateEdit.DateTime == DateTime.MinValue)
                        {
                            MessageBox.Show("Please Select Date & Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (Convert.ToInt32(SearchLookUpEdit.EditValue) == 0)
                            {
                                MessageBox.Show("Please Select Site Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        SearchByDailyActualOperation();
                        break;
                    default:
                         MessageBox.Show("Please Select one report title !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                 }

                 if (report != null)
                 {
                     report = ShowReportPreview(report) as XtraReport;
                     report.CreateDocument();
                     ReportDocumentViewer.DocumentSource = report;
                 }
             }
             catch (TimeoutException ex)
             {
                 MessageBox.Show(string.Format("Timeout exception! Message: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (FaultException<ServerSvcFault> ex)
             {
                 MessageBox.Show(string.Format("Reason: {0}! Message: {1}", ex.Message, ex.Detail.FaultMessage), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (FaultException ex)
             {
                 MessageBox.Show(string.Format("Unknown Fault! Message: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (CommunicationException)
             {
                 MessageBox.Show("Failed to connect to server! Please exit the application and sign in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(string.Format("Unknown exception! {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        #region SearchFunction

         private void SearchOperationOrderReg()
         {
             DateTime from = FromDateEdit.DateTime;
             DateTime to = ToDateEdit.DateTime;

             int siteID = 0, buildingTypeID = 0;
             string orderNo = null;
             List<OperationOrderRegVO> list = new List<OperationOrderRegVO>();
             if(SearchBySiteNameCheckEdit.Checked)
                 siteID = Convert.ToInt32(SearchLookUpEdit.EditValue);
             else if(SearchByOrderNoCheckEdit.Checked)
                 orderNo = SearchLookUpEdit.Text;
             else if(SearchByBuildingTypeCheckEdit.Checked)
                 buildingTypeID = Convert.ToInt32(SearchLookUpEdit.EditValue);

             list = this.service.GetOORListByFilter(from, to, siteID, buildingTypeID, orderNo);

             OORXtraReport creport = new OORXtraReport();
             creport.FromDateParam.Value = FromDateEdit.DateTime;
             creport.ToDateParam.Value = ToDateEdit.DateTime;
             creport.PrintDateParam.Value = DateTime.Now;
             creport.TitleParam.Value = (SearchLookUpEdit.Text != this.PleaseSelect) ? SearchLookUpEdit.Text : null;
             creport.DataSource = list;
             report = creport;
         }

         private void SearchOperationOrder() 
         {
             //int OORID = 0;
             string orderNo = null;
             List<OperationOrderVO> list = new List<OperationOrderVO>();
            if (SearchByOrderNoCheckEdit.Checked)
                 orderNo = SearchLookUpEdit.Text;

            list = this.service.GetOOListByFilter(orderNo);

            OperationOrderXtraReport creport = new OperationOrderXtraReport();
             creport.PrintDateParam.Value = DateTime.Now;
             creport.TitleParam.Value = (SearchLookUpEdit.Text != this.PleaseSelect) ? SearchLookUpEdit.Text : null;
             creport.DataSource = list;
             report = creport;
         }

         private void SearchByMonthlyOperation()
         {
             int siteID = 0;
             if (MonthDateCheckEdit.Checked && SearchBySiteNameCheckEdit.Checked)
             {
                 DateTime date = SearchMonthDateEdit.DateTime;
                 if (SearchBySiteNameCheckEdit.Checked)
                 {
                     siteID = Convert.ToInt32(SearchLookUpEdit.EditValue);
                 }
                 List<MonthlyPlanSummaryVO> list = new List<MonthlyPlanSummaryVO>();
                 list = service.GetMonthlyPlanByFilter(date,siteID);
                 #region
                 //List<MonthlyPlanSummaryVO> list1 = new List<MonthlyPlanSummaryVO>();
                 //if (list != null)
                 //{
                 //    list.GroupBy(x => new { x.NameOfWork }).ToList().ForEach(z => list1.Add(new MonthlyPlanSummaryVO()
                 //    {
                 //        FortheMonth = z.Select(u => u.FortheMonth).FirstOrDefault(),
                 //        Date = z.Select(u => u.Date).FirstOrDefault(),
                 //        SiteName = z.Select(u => u.SiteName).FirstOrDefault(),
                 //        SiteCode = z.Select(u => u.SiteCode).FirstOrDefault(),
                 //        PreparedByName = z.Select(u => u.PreparedByName).FirstOrDefault(),
                 //        CheckedByName = z.Select(u => u.CheckedByName).FirstOrDefault(),
                 //        ApprovedByName = z.Select(u => u.ApprovedByName).FirstOrDefault(),
                 //        a = z.Select(u => u.a).LastOrDefault(),
                 //        b = z.Select(u => u.b).LastOrDefault(),
                 //        c = z.Select(u => u.c).LastOrDefault(),
                 //        d = z.Select(u => u.d).LastOrDefault(),
                 //        e = z.Select(u => u.e).LastOrDefault(),
                 //        f = z.Select(u => u.f).LastOrDefault(),
                 //        PlanFromDate = z.Select(u => u.PlanFromDate).FirstOrDefault(),
                 //        PlanToDate = z.Select(u => u.PlanToDate).FirstOrDefault(),
                 //        ActualFromDate = z.Select(u => u.ActualFromDate).FirstOrDefault(),
                 //        ActualToDate = z.Select(u => u.ActualToDate).FirstOrDefault(),
                 //        NameOfWork = z.Key.NameOfWork
                 //    }));
                 //}
                 #endregion
                 MonthlyOperationXtraReport creport = new MonthlyOperationXtraReport();
                 creport.DataSource = list;
                 report = creport;
             }
         }

         private void SearchByWeeklyOperation()  
         {
             int siteID = 0;
             if (FromDateEdit.DateTime != DateTime.MinValue && SearchBySiteNameCheckEdit.Checked)
             {
                 DateTime date = FromDateEdit.DateTime;
                 if (SearchBySiteNameCheckEdit.Checked)
                 {
                     siteID = Convert.ToInt32(SearchLookUpEdit.EditValue);
                 }
                 List<WeeklyPlanDetailVO> list = new List<WeeklyPlanDetailVO>();
                 list = service.GetWeeklyPlanByFilter(date, siteID);
                 WeeklyOperationXtraReport creport = new WeeklyOperationXtraReport(date);
                 creport.DataSource = list;
                 report = creport;
             }
         }

         private void SearchByDailyOperation()  
         {
             int siteID = 0;
             if (FromDateEdit.DateTime != DateTime.MinValue && SearchBySiteNameCheckEdit.Checked)
             {
                 DateTime date = FromDateEdit.DateTime;
                 if (SearchBySiteNameCheckEdit.Checked)
                 {
                     siteID = Convert.ToInt32(SearchLookUpEdit.EditValue);
                 }
                 List<DailyPlanDetailVO> list = new List<DailyPlanDetailVO>();
                 //list = service.GetDailyPlanByFilter(date, siteID);
                 DailyJobAssignmentXtraReport1 creport = new DailyJobAssignmentXtraReport1();
                 //creport.DateParam.Value = date;
                 creport.DataSource = list;
                 report = creport;
             }
         }

        private void SearchByDailyActualOperation()   
        {
            int siteID = 0;
            if (FromDateEdit.DateTime != DateTime.MinValue && SearchBySiteNameCheckEdit.Checked)
            {
                DateTime date = FromDateEdit.DateTime;
                if (SearchBySiteNameCheckEdit.Checked)
                {
                    siteID = Convert.ToInt32(SearchLookUpEdit.EditValue);
                }
                List<DailyPlanDetailVO> list = new List<DailyPlanDetailVO>();
                list = service.GetDailyPlanByFilter(date, siteID);
                DailyJobActualAssignmentXtraReport creport = new DailyJobActualAssignmentXtraReport();
                creport.DateParam.Value = date;
                creport.DataSource = list;
                report = creport;
            }
        }

        #endregion

        #region SearchBindingCombo

        private void BindSite(LookUpEdit SearchLookUpEdit)
         {
             List<PairVO> pairs = new List<PairVO>();
             List<SiteVO> list = this.service.GetActiveSite(true);
             if (list != null)
             {
                 list.ForEach(x => pairs.Add(new PairVO() { ID = x.SiteID, Value = x.SiteName}));
             }
             pairs.Add(new PairVO() { ID = 0, Value = this.PleaseSelect });
             SearchLookUpEdit.Properties.DataSource = pairs.OrderBy(x => x.ID);
             SearchLookUpEdit.RefreshEditValue();
             SearchLookUpEdit.Enabled = true;
         }

         private void BindBuildingType(LookUpEdit SearchLookUpEdit)
         {
             List<PairVO> pairs = new List<PairVO>();
             List<BuildingTypeVO> list = this.service.GetActiveBuildingType (true);
             if (list != null)
             {
                 list.ForEach(x => pairs.Add(new PairVO() { ID = x.BuildingTypeID , Value = x.BuildingType  }));
             }
             pairs.Add(new PairVO() { ID = 0, Value = this.PleaseSelect });
             SearchLookUpEdit.Properties.DataSource = pairs.OrderBy(x => x.ID);
             SearchLookUpEdit.RefreshEditValue();
             SearchLookUpEdit.Enabled = true;
         }

         private void BindOrderNo(LookUpEdit SearchLookUpEdit)
         {
             List<PairVO> pairs = new List<PairVO>();
             List<OperationOrderRegVO> list = this.service.GetAllOperationOrderReg();
             if (list != null)
             {
                 list.ForEach(x => pairs.Add(new PairVO() { ID = x.OORID, Value = x.OrderNo }));
             }
             pairs.Add(new PairVO() { ID = 0, Value = this.PleaseSelect });
             SearchLookUpEdit.Properties.DataSource = pairs.OrderBy(x => x.ID);
             SearchLookUpEdit.RefreshEditValue();
             SearchLookUpEdit.Enabled = true;
         }

        #endregion

         private void SearchByCheckEdit_CheckedChanged(object sender, EventArgs e)
         {
             CheckEdit chk = sender as CheckEdit;

             if (chk != null)
             {
                 if (chk.Checked)
                 {
                     switch (chk.Name)
                     {
                         case "SearchBySiteNameCheckEdit":
                             SearchBySiteNameCheckEdit.Checked = true;
                             SearchByBuildingTypeCheckEdit.Checked=false;
                             SearchByOrderNoCheckEdit.Checked = false;
                             BindSite(SearchLookUpEdit);
                             break;
                         case "SearchByBuildingTypeCheckEdit":
                             SearchByBuildingTypeCheckEdit.Checked = true;
                             SearchBySiteNameCheckEdit.Checked = false;
                             SearchByOrderNoCheckEdit.Checked = false;
                             BindBuildingType(SearchLookUpEdit);
                             break;
                         case "SearchByOrderNoCheckEdit":
                             SearchByOrderNoCheckEdit.Checked = true;
                             SearchBySiteNameCheckEdit.Checked = false;
                             SearchByBuildingTypeCheckEdit.Checked = false;
                             BindOrderNo(SearchLookUpEdit);
                             break;
                         case "MonthDateCheckEdit":
                             SearchBySiteNameCheckEdit.Checked = true;
                             break;
                     }
                 }
                 else
                 {
                     SearchLookUpEdit.Properties.ValueMember = "ID";
                     SearchLookUpEdit.Properties.DataSource = null;
                     SearchLookUpEdit.Refresh();
                     SearchLookUpEdit.Enabled = false;
                 }
             }
         }

         private void FromDateEdit_EditValueChanged(object sender, EventArgs e)
         {
             if (SearchTitleIDLabelControl.Text == "WeeklyOperationInstructionReportNavBarItem" && FromDateEdit.DateTime != DateTime.MinValue)
             {
                 ToDateEdit.DateTime = FromDateEdit.DateTime.AddDays(6);
             }
             else
             {
                 ToDateEdit.DateTime = DateTime.Now;
             }
         }
    }
}