namespace ISOFormat.UIForm
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.ProfilePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.PersonLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.personVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.UserRoleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.userRoleVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.UserGridContorl = new DevExpress.XtraGrid.GridControl();
            this.userVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserRoleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModifiedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridContorl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.UserGridContorl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1009, 505);
            this.splitContainerControl1.SplitterPosition = 346;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.ProfilePictureEdit);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.PersonLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.UserRoleLookUpEdit);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtLoginName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 505);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Info";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(53, 276);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 273;
            this.labelControl5.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(101, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(204, 26);
            this.txtEmail.TabIndex = 272;
            // 
            // ProfilePictureEdit
            // 
            this.ProfilePictureEdit.Location = new System.Drawing.Point(101, 33);
            this.ProfilePictureEdit.Name = "ProfilePictureEdit";
            this.ProfilePictureEdit.Properties.InitialImage = null;
            this.ProfilePictureEdit.Properties.NullText = "Click Me";
            this.ProfilePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ProfilePictureEdit.Size = new System.Drawing.Size(150, 98);
            this.ProfilePictureEdit.TabIndex = 271;
            this.ProfilePictureEdit.Click += new System.EventHandler(this.ProfilePictureEdit_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(47, 47);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(37, 13);
            this.labelControl13.TabIndex = 270;
            this.labelControl13.Text = "Profile :";
            // 
            // PersonLookUpEdit
            // 
            this.PersonLookUpEdit.EnterMoveNextControl = true;
            this.PersonLookUpEdit.Location = new System.Drawing.Point(101, 190);
            this.PersonLookUpEdit.Name = "PersonLookUpEdit";
            this.PersonLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.PersonLookUpEdit.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonLookUpEdit.Properties.AppearanceDropDown.Options.UseFont = true;
            this.PersonLookUpEdit.Properties.AutoHeight = false;
            this.PersonLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PersonLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonName", "Person Name")});
            this.PersonLookUpEdit.Properties.DataSource = this.personVOBindingSource;
            this.PersonLookUpEdit.Properties.DisplayMember = "PersonName";
            this.PersonLookUpEdit.Properties.NullText = "--Please Select--";
            this.PersonLookUpEdit.Properties.ValueMember = "PersonID";
            this.PersonLookUpEdit.Size = new System.Drawing.Size(204, 26);
            this.PersonLookUpEdit.TabIndex = 13;
            // 
            // personVOBindingSource
            // 
            this.personVOBindingSource.DataSource = typeof(ISOServiceVO.PersonVO);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 194);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Person :";
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(119, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(215, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(23, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserRoleLookUpEdit
            // 
            this.UserRoleLookUpEdit.EnterMoveNextControl = true;
            this.UserRoleLookUpEdit.Location = new System.Drawing.Point(101, 150);
            this.UserRoleLookUpEdit.Name = "UserRoleLookUpEdit";
            this.UserRoleLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.UserRoleLookUpEdit.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLookUpEdit.Properties.AppearanceDropDown.Options.UseFont = true;
            this.UserRoleLookUpEdit.Properties.AutoHeight = false;
            this.UserRoleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UserRoleLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "Role Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UserRoleLookUpEdit.Properties.DataSource = this.userRoleVOBindingSource;
            this.UserRoleLookUpEdit.Properties.DisplayMember = "RoleName";
            this.UserRoleLookUpEdit.Properties.NullText = "--Please Select--";
            this.UserRoleLookUpEdit.Properties.ValueMember = "ID";
            this.UserRoleLookUpEdit.Size = new System.Drawing.Size(204, 26);
            this.UserRoleLookUpEdit.TabIndex = 0;
            this.UserRoleLookUpEdit.TextChanged += new System.EventHandler(this.UserRole_TextChanged);
            // 
            // userRoleVOBindingSource
            // 
            this.userRoleVOBindingSource.DataSource = typeof(ISOServiceVO.UserRoleVO);
            // 
            // chkActive
            // 
            this.chkActive.EditValue = true;
            this.chkActive.Location = new System.Drawing.Point(99, 376);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.chkActive.Properties.Appearance.Options.UseForeColor = true;
            this.chkActive.Properties.Caption = "Active";
            this.chkActive.Size = new System.Drawing.Size(75, 19);
            this.chkActive.TabIndex = 8;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(101, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(204, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtLoginName
            // 
            this.txtLoginName.EnterMoveNextControl = true;
            this.txtLoginName.Location = new System.Drawing.Point(101, 232);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Properties.Appearance.Options.UseFont = true;
            this.txtLoginName.Size = new System.Drawing.Size(204, 26);
            this.txtLoginName.TabIndex = 2;
            this.txtLoginName.TextChanged += new System.EventHandler(this.UserRole_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 323);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Password :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 236);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Login Name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User Role :";
            // 
            // UserGridContorl
            // 
            this.UserGridContorl.DataSource = this.userVOBindingSource;
            this.UserGridContorl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridContorl.Location = new System.Drawing.Point(0, 0);
            this.UserGridContorl.MainView = this.UserGridView;
            this.UserGridContorl.Name = "UserGridContorl";
            this.UserGridContorl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.UserGridContorl.Size = new System.Drawing.Size(657, 505);
            this.UserGridContorl.TabIndex = 0;
            this.UserGridContorl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UserGridView});
            this.UserGridContorl.DoubleClick += new System.EventHandler(this.UserGridContorl_DoubleClick);
            // 
            // userVOBindingSource
            // 
            this.userVOBindingSource.DataSource = typeof(ISOServiceVO.UserVO);
            // 
            // UserGridView
            // 
            this.UserGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.UserGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.UserGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserGridView.Appearance.Row.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGridView.Appearance.Row.Options.UseFont = true;
            this.UserGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colUserRole,
            this.colPersonName,
            this.colLoginName,
            this.colEmail,
            this.colImage,
            this.colIsActive,
            this.colPassword,
            this.colID,
            this.colUserRoleID,
            this.colPersonID,
            this.colLastModifiedBy,
            this.colLastModifiedOn});
            this.UserGridView.GridControl = this.UserGridContorl;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.OptionsBehavior.Editable = false;
            this.UserGridView.OptionsBehavior.ReadOnly = true;
            this.UserGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.UserGridView.OptionsView.EnableAppearanceOddRow = true;
            this.UserGridView.RowHeight = 50;
            this.UserGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.UserGridView_CustomColumnDisplayText);
            // 
            // colNo
            // 
            this.colNo.Caption = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 50;
            // 
            // colUserRole
            // 
            this.colUserRole.Caption = "User Role";
            this.colUserRole.FieldName = "UserRole";
            this.colUserRole.Name = "colUserRole";
            this.colUserRole.Visible = true;
            this.colUserRole.VisibleIndex = 1;
            this.colUserRole.Width = 100;
            // 
            // colPersonName
            // 
            this.colPersonName.Caption = "Person Name";
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 2;
            this.colPersonName.Width = 120;
            // 
            // colLoginName
            // 
            this.colLoginName.FieldName = "LoginName";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 3;
            this.colLoginName.Width = 100;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 100;
            // 
            // colImage
            // 
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 5;
            this.colImage.Width = 100;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 6;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colUserRoleID
            // 
            this.colUserRoleID.FieldName = "UserRoleID";
            this.colUserRoleID.Name = "colUserRoleID";
            // 
            // colPersonID
            // 
            this.colPersonID.FieldName = "PersonID";
            this.colPersonID.Name = "colPersonID";
            // 
            // colLastModifiedBy
            // 
            this.colLastModifiedBy.FieldName = "LastModifiedBy";
            this.colLastModifiedBy.Name = "colLastModifiedBy";
            // 
            // colLastModifiedOn
            // 
            this.colLastModifiedOn.FieldName = "LastModifiedOn";
            this.colLastModifiedOn.Name = "colLastModifiedOn";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(307, 154);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(6, 13);
            this.labelControl6.TabIndex = 274;
            this.labelControl6.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(307, 236);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(6, 13);
            this.labelControl8.TabIndex = 276;
            this.labelControl8.Text = "*";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Location = new System.Drawing.Point(307, 323);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(6, 13);
            this.labelControl9.TabIndex = 277;
            this.labelControl9.Text = "*";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 505);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridContorl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit UserRoleLookUpEdit;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LookUpEdit PersonLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource userRoleVOBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.PictureEdit ProfilePictureEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.BindingSource personVOBindingSource;
        private DevExpress.XtraGrid.GridControl UserGridContorl;
        private System.Windows.Forms.BindingSource userVOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UserGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserRoleID;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonID;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModifiedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colUserRole;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}