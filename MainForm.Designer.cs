namespace ISOFormat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BuildingTypeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SiteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PersonBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PersonAndSiteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CloseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.BorttonBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.PersonTypeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.OperationOrderRegBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.OperatonOrderBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NameOfWorkBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.UserRoleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.UserBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CloseRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ReportRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.XtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.BuildingTypeBarButtonItem,
            this.SiteBarButtonItem,
            this.PersonBarButtonItem,
            this.PersonAndSiteBarButtonItem,
            this.CloseBarButtonItem,
            this.barStaticItem,
            this.BorttonBarStaticItem,
            this.PersonTypeBarButtonItem,
            this.OperationOrderRegBarButtonItem,
            this.OperatonOrderBarButtonItem,
            this.ReportBarButtonItem,
            this.NameOfWorkBarButtonItem,
            this.UserRoleBarButtonItem,
            this.UserBarButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ReportRibbonPage});
            this.ribbon.Size = new System.Drawing.Size(925, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BuildingTypeBarButtonItem
            // 
            this.BuildingTypeBarButtonItem.Caption = "Building Type";
            this.BuildingTypeBarButtonItem.Id = 1;
            this.BuildingTypeBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("BuildingTypeBarButtonItem.LargeGlyph")));
            this.BuildingTypeBarButtonItem.Name = "BuildingTypeBarButtonItem";
            this.BuildingTypeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuildingTypeBarButtonItem_ItemClick);
            // 
            // SiteBarButtonItem
            // 
            this.SiteBarButtonItem.Caption = "Site";
            this.SiteBarButtonItem.Id = 2;
            this.SiteBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("SiteBarButtonItem.LargeGlyph")));
            this.SiteBarButtonItem.Name = "SiteBarButtonItem";
            this.SiteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SiteBarButtonItem_ItemClick);
            // 
            // PersonBarButtonItem
            // 
            this.PersonBarButtonItem.Caption = "Person";
            this.PersonBarButtonItem.Id = 3;
            this.PersonBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PersonBarButtonItem.LargeGlyph")));
            this.PersonBarButtonItem.Name = "PersonBarButtonItem";
            this.PersonBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PersonBarButtonItem_ItemClick);
            // 
            // PersonAndSiteBarButtonItem
            // 
            this.PersonAndSiteBarButtonItem.Caption = "Person And  Site";
            this.PersonAndSiteBarButtonItem.Id = 4;
            this.PersonAndSiteBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PersonAndSiteBarButtonItem.LargeGlyph")));
            this.PersonAndSiteBarButtonItem.Name = "PersonAndSiteBarButtonItem";
            this.PersonAndSiteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PersonAndSiteBarButtonItem_ItemClick);
            // 
            // CloseBarButtonItem
            // 
            this.CloseBarButtonItem.Caption = "Close";
            this.CloseBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("CloseBarButtonItem.Glyph")));
            this.CloseBarButtonItem.Id = 5;
            this.CloseBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("CloseBarButtonItem.LargeGlyph")));
            this.CloseBarButtonItem.Name = "CloseBarButtonItem";
            this.CloseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBarButtonItem_ItemClick);
            // 
            // barStaticItem
            // 
            this.barStaticItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem.Caption = "Developed By Asia Brightway IT Co., Ltd";
            this.barStaticItem.Id = 6;
            this.barStaticItem.Name = "barStaticItem";
            this.barStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // BorttonBarStaticItem
            // 
            this.BorttonBarStaticItem.Id = 8;
            this.BorttonBarStaticItem.Name = "BorttonBarStaticItem";
            this.BorttonBarStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // PersonTypeBarButtonItem
            // 
            this.PersonTypeBarButtonItem.Caption = "Person Type";
            this.PersonTypeBarButtonItem.Id = 9;
            this.PersonTypeBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("PersonTypeBarButtonItem.LargeGlyph")));
            this.PersonTypeBarButtonItem.Name = "PersonTypeBarButtonItem";
            this.PersonTypeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PersonTypeBarButtonItem_ItemClick);
            // 
            // OperationOrderRegBarButtonItem
            // 
            this.OperationOrderRegBarButtonItem.Caption = "Operation Order Reg";
            this.OperationOrderRegBarButtonItem.Id = 10;
            this.OperationOrderRegBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("OperationOrderRegBarButtonItem.LargeGlyph")));
            this.OperationOrderRegBarButtonItem.Name = "OperationOrderRegBarButtonItem";
            this.OperationOrderRegBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OperationOrderRegBarButtonItem_ItemClick);
            // 
            // OperatonOrderBarButtonItem
            // 
            this.OperatonOrderBarButtonItem.Caption = "Operation Order";
            this.OperatonOrderBarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("OperatonOrderBarButtonItem.Glyph")));
            this.OperatonOrderBarButtonItem.Id = 11;
            this.OperatonOrderBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("OperatonOrderBarButtonItem.LargeGlyph")));
            this.OperatonOrderBarButtonItem.Name = "OperatonOrderBarButtonItem";
            this.OperatonOrderBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OperatonOrderBarButtonItem_ItemClick);
            // 
            // ReportBarButtonItem
            // 
            this.ReportBarButtonItem.Caption = "Report";
            this.ReportBarButtonItem.Id = 12;
            this.ReportBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ReportBarButtonItem.LargeGlyph")));
            this.ReportBarButtonItem.Name = "ReportBarButtonItem";
            this.ReportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReportBarButtonItem_ItemClick);
            // 
            // NameOfWorkBarButtonItem
            // 
            this.NameOfWorkBarButtonItem.Caption = "Name Of Work";
            this.NameOfWorkBarButtonItem.Id = 13;
            this.NameOfWorkBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("NameOfWorkBarButtonItem.LargeGlyph")));
            this.NameOfWorkBarButtonItem.Name = "NameOfWorkBarButtonItem";
            this.NameOfWorkBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NameOfWorkBarButtonItem_ItemClick);
            // 
            // UserRoleBarButtonItem
            // 
            this.UserRoleBarButtonItem.Caption = "User Role";
            this.UserRoleBarButtonItem.Id = 15;
            this.UserRoleBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UserRoleBarButtonItem.LargeGlyph")));
            this.UserRoleBarButtonItem.Name = "UserRoleBarButtonItem";
            this.UserRoleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserRoleBarButtonItem_ItemClick);
            // 
            // UserBarButtonItem
            // 
            this.UserBarButtonItem.Caption = "User";
            this.UserBarButtonItem.Id = 16;
            this.UserBarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("UserBarButtonItem.LargeGlyph")));
            this.UserBarButtonItem.Name = "UserBarButtonItem";
            this.UserBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.UserRibbonPageGroup,
            this.CloseRibbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Setup";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BuildingTypeBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.SiteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.PersonTypeBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.PersonBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.PersonAndSiteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.OperationOrderRegBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.OperatonOrderBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.NameOfWorkBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Configuration";
            // 
            // UserRibbonPageGroup
            // 
            this.UserRibbonPageGroup.ItemLinks.Add(this.UserRoleBarButtonItem);
            this.UserRibbonPageGroup.ItemLinks.Add(this.UserBarButtonItem);
            this.UserRibbonPageGroup.Name = "UserRibbonPageGroup";
            this.UserRibbonPageGroup.Text = "User";
            // 
            // CloseRibbonPageGroup
            // 
            this.CloseRibbonPageGroup.ItemLinks.Add(this.CloseBarButtonItem);
            this.CloseRibbonPageGroup.Name = "CloseRibbonPageGroup";
            // 
            // ReportRibbonPage
            // 
            this.ReportRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ReportRibbonPageGroup});
            this.ReportRibbonPage.Name = "ReportRibbonPage";
            this.ReportRibbonPage.Text = "Report";
            // 
            // ReportRibbonPageGroup
            // 
            this.ReportRibbonPageGroup.ItemLinks.Add(this.ReportBarButtonItem);
            this.ReportRibbonPageGroup.Name = "ReportRibbonPageGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem);
            this.ribbonStatusBar.ItemLinks.Add(this.BorttonBarStaticItem);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 548);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(925, 32);
            // 
            // XtraTabbedMdiManager
            // 
            this.XtraTabbedMdiManager.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("XtraTabbedMdiManager.Appearance.Image")));
            this.XtraTabbedMdiManager.Appearance.Options.UseImage = true;
            this.XtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.XtraTabbedMdiManager.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 580);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager XtraTabbedMdiManager;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.BarButtonItem BuildingTypeBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem SiteBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem PersonBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem PersonAndSiteBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem CloseBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CloseRibbonPageGroup;
        private DevExpress.XtraBars.BarStaticItem barStaticItem;
        private DevExpress.XtraBars.BarStaticItem BorttonBarStaticItem;
        private DevExpress.XtraBars.BarButtonItem PersonTypeBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem OperationOrderRegBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem OperatonOrderBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ReportBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReportRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ReportRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem NameOfWorkBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem UserRoleBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem UserBarButtonItem;
    }
}