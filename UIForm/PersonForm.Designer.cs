namespace ISOFormat.UIForm
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.NewPersonTypeSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PersonTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.personTypeVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.PersonGridControl = new DevExpress.XtraGrid.GridControl();
            this.personVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
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
            this.splitContainerControl1.SplitterPosition = 390;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.NewPersonTypeSimpleButton);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.PersonTypeLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtPerson);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(390, 533);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Info";
            // 
            // NewPersonTypeSimpleButton
            // 
            this.NewPersonTypeSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("NewPersonTypeSimpleButton.Image")));
            this.NewPersonTypeSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.NewPersonTypeSimpleButton.Location = new System.Drawing.Point(310, 64);
            this.NewPersonTypeSimpleButton.Name = "NewPersonTypeSimpleButton";
            this.NewPersonTypeSimpleButton.Size = new System.Drawing.Size(25, 24);
            this.NewPersonTypeSimpleButton.TabIndex = 42;
            this.NewPersonTypeSimpleButton.Click += new System.EventHandler(this.NewPersonTypeSimpleButton_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(339, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(315, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "*";
            // 
            // PersonTypeLookUpEdit
            // 
            this.PersonTypeLookUpEdit.EnterMoveNextControl = true;
            this.PersonTypeLookUpEdit.Location = new System.Drawing.Point(128, 64);
            this.PersonTypeLookUpEdit.Name = "PersonTypeLookUpEdit";
            this.PersonTypeLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonTypeLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.PersonTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PersonTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonType", "Person Type")});
            this.PersonTypeLookUpEdit.Properties.DataSource = this.personTypeVOBindingSource;
            this.PersonTypeLookUpEdit.Properties.DisplayMember = "PersonType";
            this.PersonTypeLookUpEdit.Properties.NullText = "--Please Select--";
            this.PersonTypeLookUpEdit.Properties.ValueMember = "PersonTypeID";
            this.PersonTypeLookUpEdit.Size = new System.Drawing.Size(181, 28);
            this.PersonTypeLookUpEdit.TabIndex = 35;
            this.PersonTypeLookUpEdit.TextChanged += new System.EventHandler(this.PersonType_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(35, 67);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Person Type  :";
            // 
            // chkActive
            // 
            this.chkActive.EditValue = true;
            this.chkActive.EnterMoveNextControl = true;
            this.chkActive.Location = new System.Drawing.Point(126, 191);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.chkActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 37;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtPerson
            // 
            this.txtPerson.EnterMoveNextControl = true;
            this.txtPerson.Location = new System.Drawing.Point(128, 117);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerson.Properties.Appearance.Options.UseFont = true;
            this.txtPerson.Size = new System.Drawing.Size(181, 26);
            this.txtPerson.TabIndex = 36;
            this.txtPerson.TextChanged += new System.EventHandler(this.PersonType_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(32, 120);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Person Name  :";
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(150, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 4;
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
            this.btnClose.TabIndex = 5;
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
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.PersonGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(774, 533);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "List";
            // 
            // PersonGridControl
            // 
            this.PersonGridControl.DataSource = this.personVOBindingSource;
            this.PersonGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonGridControl.Location = new System.Drawing.Point(2, 21);
            this.PersonGridControl.MainView = this.PersonGridView;
            this.PersonGridControl.Name = "PersonGridControl";
            this.PersonGridControl.Size = new System.Drawing.Size(770, 510);
            this.PersonGridControl.TabIndex = 1;
            this.PersonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonGridView});
            this.PersonGridControl.DoubleClick += new System.EventHandler(this.PersonGridControl_DoubleClick);
            // 
            // personVOBindingSource
            // 
            this.personVOBindingSource.DataSource = typeof(ISOServiceVO.PersonVO);
            // 
            // PersonGridView
            // 
            this.PersonGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.PersonGridView.Appearance.Row.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonGridView.Appearance.Row.Options.UseFont = true;
            this.PersonGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colPersonType,
            this.colPersonName,
            this.colActive,
            this.colPersonID,
            this.colPersonTypeID,
            this.colModifiedBy,
            this.colModifiedDate});
            this.PersonGridView.GridControl = this.PersonGridControl;
            this.PersonGridView.Name = "PersonGridView";
            this.PersonGridView.OptionsBehavior.Editable = false;
            this.PersonGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.PersonGridView.OptionsView.EnableAppearanceOddRow = true;
            this.PersonGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.PersonGridView_CustomColumnDisplayText);
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
            this.colNo.Width = 91;
            // 
            // colPersonType
            // 
            this.colPersonType.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonType.AppearanceCell.Options.UseFont = true;
            this.colPersonType.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonType.AppearanceHeader.Options.UseFont = true;
            this.colPersonType.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonType.Caption = "Person Type";
            this.colPersonType.FieldName = "PersonType";
            this.colPersonType.Name = "colPersonType";
            this.colPersonType.Visible = true;
            this.colPersonType.VisibleIndex = 1;
            this.colPersonType.Width = 275;
            // 
            // colPersonName
            // 
            this.colPersonName.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonName.AppearanceCell.Options.UseFont = true;
            this.colPersonName.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonName.AppearanceHeader.Options.UseFont = true;
            this.colPersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 2;
            this.colPersonName.Width = 150;
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
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 50;
            // 
            // colPersonID
            // 
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            // 
            // colPersonTypeID
            // 
            this.colPersonTypeID.AppearanceCell.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonTypeID.AppearanceCell.Options.UseFont = true;
            this.colPersonTypeID.AppearanceHeader.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPersonTypeID.AppearanceHeader.Options.UseFont = true;
            this.colPersonTypeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonTypeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonTypeID.FieldName = "PersonTypeID";
            this.colPersonTypeID.Name = "colPersonTypeID";
            this.colPersonTypeID.Width = 242;
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
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 533);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "PersonForm";
            this.Text = "Person";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTypeVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource personTypeVOBindingSource;
        private DevExpress.XtraGrid.GridControl PersonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonGridView;
        private System.Windows.Forms.BindingSource personVOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonType;
        private DevExpress.XtraEditors.LookUpEdit PersonTypeLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton NewPersonTypeSimpleButton;
    }
}