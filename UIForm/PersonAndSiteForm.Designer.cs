namespace ISOFormat.UIForm
{
    partial class PersonAndSiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonAndSiteForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.NewPersonSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NewSiteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ResponsibilityLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.responsibilityTypeVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SiteNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.siteVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.PersonNameLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.personVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkFinished = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.PersonAndSiteGridControl = new DevExpress.XtraGrid.GridControl();
            this.PersonAndSiteGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsibilityType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsibilityTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personAndSiteVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibilityLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilityTypeVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonNameLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFinished.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonAndSiteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonAndSiteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAndSiteVOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1169, 533);
            this.splitContainerControl1.SplitterPosition = 367;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.NewPersonSimpleButton);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.NewSiteSimpleButton);
            this.groupControl1.Controls.Add(this.ResponsibilityLookUpEdit);
            this.groupControl1.Controls.Add(this.SiteNameLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.PersonNameLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.chkFinished);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(367, 533);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Info";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(294, 190);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "*";
            // 
            // NewPersonSimpleButton
            // 
            this.NewPersonSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("NewPersonSimpleButton.Image")));
            this.NewPersonSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.NewPersonSimpleButton.Location = new System.Drawing.Point(294, 120);
            this.NewPersonSimpleButton.Name = "NewPersonSimpleButton";
            this.NewPersonSimpleButton.Size = new System.Drawing.Size(25, 24);
            this.NewPersonSimpleButton.TabIndex = 47;
            this.NewPersonSimpleButton.Click += new System.EventHandler(this.NewSimpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(321, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 13);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "*";
            // 
            // NewSiteSimpleButton
            // 
            this.NewSiteSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("NewSiteSimpleButton.Image")));
            this.NewSiteSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.NewSiteSimpleButton.Location = new System.Drawing.Point(294, 59);
            this.NewSiteSimpleButton.Name = "NewSiteSimpleButton";
            this.NewSiteSimpleButton.Size = new System.Drawing.Size(25, 24);
            this.NewSiteSimpleButton.TabIndex = 45;
            this.NewSiteSimpleButton.Click += new System.EventHandler(this.NewSimpleButton_Click);
            // 
            // ResponsibilityLookUpEdit
            // 
            this.ResponsibilityLookUpEdit.EnterMoveNextControl = true;
            this.ResponsibilityLookUpEdit.Location = new System.Drawing.Point(111, 181);
            this.ResponsibilityLookUpEdit.Name = "ResponsibilityLookUpEdit";
            this.ResponsibilityLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsibilityLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.ResponsibilityLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ResponsibilityLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type")});
            this.ResponsibilityLookUpEdit.Properties.DataSource = this.responsibilityTypeVOBindingSource;
            this.ResponsibilityLookUpEdit.Properties.DisplayMember = "Type";
            this.ResponsibilityLookUpEdit.Properties.NullText = "--Please Select--";
            this.ResponsibilityLookUpEdit.Properties.ValueMember = "ID";
            this.ResponsibilityLookUpEdit.Size = new System.Drawing.Size(181, 28);
            this.ResponsibilityLookUpEdit.TabIndex = 44;
            this.ResponsibilityLookUpEdit.TextChanged += new System.EventHandler(this.PersonNSite_TextChanged);
            // 
            // SiteNameLookUpEdit
            // 
            this.SiteNameLookUpEdit.EnterMoveNextControl = true;
            this.SiteNameLookUpEdit.Location = new System.Drawing.Point(111, 59);
            this.SiteNameLookUpEdit.Name = "SiteNameLookUpEdit";
            this.SiteNameLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteNameLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.SiteNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SiteNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SiteName", "Site Name")});
            this.SiteNameLookUpEdit.Properties.DataSource = this.siteVOBindingSource;
            this.SiteNameLookUpEdit.Properties.DisplayMember = "SiteName";
            this.SiteNameLookUpEdit.Properties.NullText = "--Please Select--";
            this.SiteNameLookUpEdit.Properties.ValueMember = "SiteID";
            this.SiteNameLookUpEdit.Size = new System.Drawing.Size(181, 28);
            this.SiteNameLookUpEdit.TabIndex = 41;
            this.SiteNameLookUpEdit.TextChanged += new System.EventHandler(this.PersonNSite_TextChanged);
            // 
            // siteVOBindingSource
            // 
            this.siteVOBindingSource.DataSource = typeof(ISOServiceVO.SiteVO);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Site Name  :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(321, 65);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 13);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "*";
            // 
            // PersonNameLookUpEdit
            // 
            this.PersonNameLookUpEdit.EnterMoveNextControl = true;
            this.PersonNameLookUpEdit.Location = new System.Drawing.Point(111, 120);
            this.PersonNameLookUpEdit.Name = "PersonNameLookUpEdit";
            this.PersonNameLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonNameLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.PersonNameLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PersonNameLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonName", "Peresnon Name")});
            this.PersonNameLookUpEdit.Properties.DataSource = this.personVOBindingSource;
            this.PersonNameLookUpEdit.Properties.DisplayMember = "PersonName";
            this.PersonNameLookUpEdit.Properties.NullText = "--Please Select--";
            this.PersonNameLookUpEdit.Properties.ValueMember = "PersonID";
            this.PersonNameLookUpEdit.Size = new System.Drawing.Size(181, 28);
            this.PersonNameLookUpEdit.TabIndex = 35;
            this.PersonNameLookUpEdit.TextChanged += new System.EventHandler(this.PersonNSite_TextChanged);
            // 
            // personVOBindingSource
            // 
            this.personVOBindingSource.DataSource = typeof(ISOServiceVO.PersonVO);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Responsibility :";
            // 
            // chkFinished
            // 
            this.chkFinished.EnterMoveNextControl = true;
            this.chkFinished.Location = new System.Drawing.Point(109, 258);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.chkFinished.Properties.Appearance.Options.UseForeColor = true;
            this.chkFinished.Properties.Caption = "Finished";
            this.chkFinished.Size = new System.Drawing.Size(75, 19);
            this.chkFinished.TabIndex = 36;
            this.chkFinished.CheckedChanged += new System.EventHandler(this.chkFinished_CheckedChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 125);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 13);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "Person Name  :";
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(135, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(231, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 50);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(39, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 50);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.PersonAndSiteGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(797, 533);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "List";
            // 
            // PersonAndSiteGridControl
            // 
            this.PersonAndSiteGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonAndSiteGridControl.Location = new System.Drawing.Point(2, 21);
            this.PersonAndSiteGridControl.MainView = this.PersonAndSiteGridView;
            this.PersonAndSiteGridControl.Name = "PersonAndSiteGridControl";
            this.PersonAndSiteGridControl.Size = new System.Drawing.Size(793, 510);
            this.PersonAndSiteGridControl.TabIndex = 1;
            this.PersonAndSiteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonAndSiteGridView});
            this.PersonAndSiteGridControl.DoubleClick += new System.EventHandler(this.PersonAndSiteGridControl_DoubleClick);
            // 
            // PersonAndSiteGridView
            // 
            this.PersonAndSiteGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonAndSiteGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.PersonAndSiteGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.PersonAndSiteGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonAndSiteGridView.Appearance.Row.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonAndSiteGridView.Appearance.Row.Options.UseFont = true;
            this.PersonAndSiteGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colSiteName,
            this.colPersonName,
            this.colResponsibilityType,
            this.colFinished,
            this.colSiteID,
            this.colPersonID,
            this.colID,
            this.colResponsibilityTypeID,
            this.colModifiedBy,
            this.colModifiedDate});
            this.PersonAndSiteGridView.GridControl = this.PersonAndSiteGridControl;
            this.PersonAndSiteGridView.Name = "PersonAndSiteGridView";
            this.PersonAndSiteGridView.OptionsBehavior.Editable = false;
            this.PersonAndSiteGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.PersonAndSiteGridView.OptionsView.EnableAppearanceOddRow = true;
            this.PersonAndSiteGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PersonAndSiteGridView_CustomColumnDisplayText);
            // 
            // colNo
            // 
            this.colNo.Caption = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 50;
            // 
            // colSiteName
            // 
            this.colSiteName.Caption = "Site Name";
            this.colSiteName.FieldName = "SiteName";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.Visible = true;
            this.colSiteName.VisibleIndex = 1;
            this.colSiteName.Width = 150;
            // 
            // colPersonName
            // 
            this.colPersonName.Caption = "Person Name";
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 2;
            this.colPersonName.Width = 150;
            // 
            // colResponsibilityType
            // 
            this.colResponsibilityType.Caption = "Responsibility Type";
            this.colResponsibilityType.FieldName = "ResponsibilityType";
            this.colResponsibilityType.Name = "colResponsibilityType";
            this.colResponsibilityType.Visible = true;
            this.colResponsibilityType.VisibleIndex = 3;
            this.colResponsibilityType.Width = 150;
            // 
            // colFinished
            // 
            this.colFinished.FieldName = "Finished";
            this.colFinished.Name = "colFinished";
            this.colFinished.Visible = true;
            this.colFinished.VisibleIndex = 4;
            this.colFinished.Width = 50;
            // 
            // colSiteID
            // 
            this.colSiteID.FieldName = "SiteID";
            this.colSiteID.Name = "colSiteID";
            // 
            // colPersonID
            // 
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colResponsibilityTypeID
            // 
            this.colResponsibilityTypeID.FieldName = "ResponsibilityTypeID";
            this.colResponsibilityTypeID.Name = "colResponsibilityTypeID";
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // personAndSiteVOBindingSource
            // 
            this.personAndSiteVOBindingSource.DataSource = typeof(ISOServiceVO.PersonAndSiteVO);
            // 
            // PersonAndSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 533);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PersonAndSiteForm";
            this.Text = "Person And Site";
            this.Load += new System.EventHandler(this.PersonAndSiteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibilityLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilityTypeVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiteNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonNameLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFinished.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonAndSiteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonAndSiteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAndSiteVOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl PersonAndSiteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonAndSiteGridView;
        private System.Windows.Forms.BindingSource personVOBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit ResponsibilityLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit SiteNameLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit PersonNameLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkFinished;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.BindingSource responsibilityTypeVOBindingSource;
        private System.Windows.Forms.BindingSource siteVOBindingSource;
        private System.Windows.Forms.BindingSource personAndSiteVOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteID;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsibilityTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFinished;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsibilityType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton NewPersonSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton NewSiteSimpleButton;
    }
}