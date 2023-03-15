namespace ISOFormat.UIForm
{
    partial class NameOfWorkForm   
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameOfWorkForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.OPTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.oPTypeVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtNameOfWorkActivities = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.NOWAGridControl = new DevExpress.XtraGrid.GridControl();
            this.nameOfWorkVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NOWAGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameofWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPTypeVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOfWorkActivities.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NOWAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOfWorkVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOWAGridView)).BeginInit();
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
            this.groupControl1.Controls.Add(this.OPTypeLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtNameOfWorkActivities);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(458, 623);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Info";
            // 
            // OPTypeLookUpEdit
            // 
            this.OPTypeLookUpEdit.EnterMoveNextControl = true;
            this.OPTypeLookUpEdit.Location = new System.Drawing.Point(161, 65);
            this.OPTypeLookUpEdit.Name = "OPTypeLookUpEdit";
            this.OPTypeLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTypeLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.OPTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OPTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OperationPlan", "Operation Plan")});
            this.OPTypeLookUpEdit.Properties.DataSource = this.oPTypeVOBindingSource;
            this.OPTypeLookUpEdit.Properties.DisplayMember = "OperationPlan";
            this.OPTypeLookUpEdit.Properties.NullText = "--Please Select--";
            this.OPTypeLookUpEdit.Properties.ValueMember = "OPTypeID";
            this.OPTypeLookUpEdit.Size = new System.Drawing.Size(204, 28);
            this.OPTypeLookUpEdit.TabIndex = 0;
            this.OPTypeLookUpEdit.TextChanged += new System.EventHandler(this.txtNOWA_TextChanged);
            // 
            // oPTypeVOBindingSource
            // 
            this.oPTypeVOBindingSource.DataSource = typeof(ISOServiceVO.OPTypeVO);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Location = new System.Drawing.Point(367, 74);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(6, 13);
            this.labelControl11.TabIndex = 69;
            this.labelControl11.Text = "*";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 68;
            this.labelControl3.Text = "OP Type  :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(367, 139);
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
            this.chkActive.Location = new System.Drawing.Point(159, 199);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.chkActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 1;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtNameOfWorkActivities
            // 
            this.txtNameOfWorkActivities.EnterMoveNextControl = true;
            this.txtNameOfWorkActivities.Location = new System.Drawing.Point(161, 132);
            this.txtNameOfWorkActivities.Name = "txtNameOfWorkActivities";
            this.txtNameOfWorkActivities.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfWorkActivities.Properties.Appearance.Options.UseFont = true;
            this.txtNameOfWorkActivities.Size = new System.Drawing.Size(204, 26);
            this.txtNameOfWorkActivities.TabIndex = 1;
            this.txtNameOfWorkActivities.TextChanged += new System.EventHandler(this.txtNOWA_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Name Of Work Activities  :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.NOWAGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(652, 623);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "List";
            // 
            // NOWAGridControl
            // 
            this.NOWAGridControl.DataSource = this.nameOfWorkVOBindingSource;
            this.NOWAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOWAGridControl.Location = new System.Drawing.Point(2, 21);
            this.NOWAGridControl.MainView = this.NOWAGridView;
            this.NOWAGridControl.Name = "NOWAGridControl";
            this.NOWAGridControl.Size = new System.Drawing.Size(648, 600);
            this.NOWAGridControl.TabIndex = 0;
            this.NOWAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.NOWAGridView});
            this.NOWAGridControl.DoubleClick += new System.EventHandler(this.NOWAGridControl_DoubleClick);
            // 
            // nameOfWorkVOBindingSource
            // 
            this.nameOfWorkVOBindingSource.DataSource = typeof(ISOServiceVO.NameOfWorkVO);
            // 
            // NOWAGridView
            // 
            this.NOWAGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOWAGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.NOWAGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.NOWAGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NOWAGridView.Appearance.Row.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOWAGridView.Appearance.Row.Options.UseFont = true;
            this.NOWAGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colOPType,
            this.colNameofWork,
            this.colActive,
            this.colModifiedBy,
            this.colModifiedDate,
            this.colID,
            this.colOPTypeID});
            this.NOWAGridView.GridControl = this.NOWAGridControl;
            this.NOWAGridView.Name = "NOWAGridView";
            this.NOWAGridView.OptionsBehavior.Editable = false;
            this.NOWAGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.NOWAGridView.OptionsView.EnableAppearanceOddRow = true;
            this.NOWAGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.NOWAGridView_CustomColumnDisplayText);
            // 
            // colNo
            // 
            this.colNo.Caption = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 50;
            // 
            // colOPType
            // 
            this.colOPType.Caption = "OP Type";
            this.colOPType.FieldName = "OPTypeName";
            this.colOPType.Name = "colOPType";
            this.colOPType.Visible = true;
            this.colOPType.VisibleIndex = 1;
            this.colOPType.Width = 150;
            // 
            // colNameofWork
            // 
            this.colNameofWork.FieldName = "NameofWork";
            this.colNameofWork.Name = "colNameofWork";
            this.colNameofWork.Visible = true;
            this.colNameofWork.VisibleIndex = 2;
            this.colNameofWork.Width = 200;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 50;
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
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colOPTypeID
            // 
            this.colOPTypeID.FieldName = "OPTypeID";
            this.colOPTypeID.Name = "colOPTypeID";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1115, 623);
            this.splitContainerControl1.SplitterPosition = 458;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // NameOfWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 623);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "NameOfWorkForm";
            this.Text = "Name Of Work";
            this.Load += new System.EventHandler(this.NameOfWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OPTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPTypeVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOfWorkActivities.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NOWAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOfWorkVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOWAGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtNameOfWorkActivities;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit OPTypeLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource oPTypeVOBindingSource;
        private DevExpress.XtraGrid.GridControl NOWAGridControl;
        private System.Windows.Forms.BindingSource nameOfWorkVOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView NOWAGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOPType;
        private DevExpress.XtraGrid.Columns.GridColumn colNameofWork;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPTypeID;
    }
}