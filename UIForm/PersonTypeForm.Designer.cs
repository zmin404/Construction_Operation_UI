namespace ISOFormat.UIForm
{
    partial class PersonTypeForm     
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonTypeForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtPersonType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.PersonTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.personTypeVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buildingTypeVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtPersonType);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(399, 623);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Info";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(338, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "*";
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(150, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(246, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(54, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.EditValue = true;
            this.chkActive.EnterMoveNextControl = true;
            this.chkActive.Location = new System.Drawing.Point(130, 188);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.chkActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 1;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtPersonType
            // 
            this.txtPersonType.EnterMoveNextControl = true;
            this.txtPersonType.Location = new System.Drawing.Point(132, 102);
            this.txtPersonType.Name = "txtPersonType";
            this.txtPersonType.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonType.Properties.Appearance.Options.UseFont = true;
            this.txtPersonType.Size = new System.Drawing.Size(204, 26);
            this.txtPersonType.TabIndex = 0;
            this.txtPersonType.TextChanged += new System.EventHandler(this.txtPersonType_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Person Type :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.PersonTypeGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(591, 623);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "List";
            // 
            // PersonTypeGridControl
            // 
            this.PersonTypeGridControl.DataSource = this.personTypeVOBindingSource;
            this.PersonTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonTypeGridControl.Location = new System.Drawing.Point(2, 21);
            this.PersonTypeGridControl.MainView = this.PersonTypeGridView;
            this.PersonTypeGridControl.Name = "PersonTypeGridControl";
            this.PersonTypeGridControl.Size = new System.Drawing.Size(587, 600);
            this.PersonTypeGridControl.TabIndex = 0;
            this.PersonTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonTypeGridView});
            this.PersonTypeGridControl.DoubleClick += new System.EventHandler(this.PersonTypeGridControl_DoubleClick);
            // 
            // PersonTypeGridView
            // 
            this.PersonTypeGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonTypeGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.PersonTypeGridView.Appearance.Row.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonTypeGridView.Appearance.Row.Options.UseFont = true;
            this.PersonTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colPersonType,
            this.colActive,
            this.colPersonTypeID,
            this.colModifiedBy,
            this.colModifiedDate});
            this.PersonTypeGridView.GridControl = this.PersonTypeGridControl;
            this.PersonTypeGridView.Name = "PersonTypeGridView";
            this.PersonTypeGridView.OptionsBehavior.Editable = false;
            this.PersonTypeGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.PersonTypeGridView.OptionsView.EnableAppearanceOddRow = true;
            this.PersonTypeGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PersonTypeGridView_CustomColumnDisplayText);
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNo.AppearanceCell.Options.UseFont = true;
            this.colNo.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNo.AppearanceHeader.Options.UseFont = true;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 50;
            // 
            // colPersonType
            // 
            this.colPersonType.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonType.AppearanceCell.Options.UseFont = true;
            this.colPersonType.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonType.AppearanceHeader.Options.UseFont = true;
            this.colPersonType.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonType.FieldName = "PersonType";
            this.colPersonType.Name = "colPersonType";
            this.colPersonType.Visible = true;
            this.colPersonType.VisibleIndex = 1;
            this.colPersonType.Width = 260;
            // 
            // colActive
            // 
            this.colActive.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colActive.AppearanceCell.Options.UseFont = true;
            this.colActive.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colActive.AppearanceHeader.Options.UseFont = true;
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 50;
            // 
            // colPersonTypeID
            // 
            this.colPersonTypeID.FieldName = "PersonTypeID";
            this.colPersonTypeID.Name = "colPersonTypeID";
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
            // buildingTypeVOBindingSource
            // 
            this.buildingTypeVOBindingSource.DataSource = typeof(ISOServiceVO.BuildingTypeVO);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(995, 623);
            this.splitContainerControl1.SplitterPosition = 399;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // PersonTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 623);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PersonTypeForm";
            this.Text = "Person Type";
            this.Load += new System.EventHandler(this.PersonTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingTypeVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource buildingTypeVOBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtPersonType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl PersonTypeGridControl;
        private System.Windows.Forms.BindingSource personTypeVOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonType;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
    }
}