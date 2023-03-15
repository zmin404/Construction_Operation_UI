namespace ISOFormat.UIForm
{
    partial class MasterSchedulePDFForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterSchedulePDFForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ViewSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Uploadlabel = new System.Windows.Forms.Label();
            this.UploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.RemoveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.UploadSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.PDFGalleryControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.CloseSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ClearSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CustomerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFGalleryControl)).BeginInit();
            this.PDFGalleryControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ViewSimpleButton);
            this.groupControl1.Controls.Add(this.Uploadlabel);
            this.groupControl1.Controls.Add(this.UploadProgressBar);
            this.groupControl1.Controls.Add(this.RemoveSimpleButton);
            this.groupControl1.Controls.Add(this.UploadSimpleButton);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.PDFGalleryControl);
            this.groupControl1.Controls.Add(this.CloseSimpleButton);
            this.groupControl1.Controls.Add(this.ClearSimpleButton);
            this.groupControl1.Controls.Add(this.SaveSimpleButton);
            this.groupControl1.Controls.Add(this.CustomerLookUpEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 540);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Info";
            // 
            // ViewSimpleButton
            // 
            this.ViewSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.ViewSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewSimpleButton.Image")));
            this.ViewSimpleButton.Location = new System.Drawing.Point(694, 130);
            this.ViewSimpleButton.Name = "ViewSimpleButton";
            this.ViewSimpleButton.Size = new System.Drawing.Size(69, 35);
            this.ViewSimpleButton.TabIndex = 126;
            this.ViewSimpleButton.Text = "View";
            // 
            // Uploadlabel
            // 
            this.Uploadlabel.AutoSize = true;
            this.Uploadlabel.Location = new System.Drawing.Point(540, 336);
            this.Uploadlabel.Name = "Uploadlabel";
            this.Uploadlabel.Size = new System.Drawing.Size(60, 13);
            this.Uploadlabel.TabIndex = 125;
            this.Uploadlabel.Text = "Upload 0%";
            // 
            // UploadProgressBar
            // 
            this.UploadProgressBar.Location = new System.Drawing.Point(468, 313);
            this.UploadProgressBar.Name = "UploadProgressBar";
            this.UploadProgressBar.Size = new System.Drawing.Size(213, 20);
            this.UploadProgressBar.TabIndex = 124;
            // 
            // RemoveSimpleButton
            // 
            this.RemoveSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.RemoveSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveSimpleButton.Image")));
            this.RemoveSimpleButton.Location = new System.Drawing.Point(694, 89);
            this.RemoveSimpleButton.Name = "RemoveSimpleButton";
            this.RemoveSimpleButton.Size = new System.Drawing.Size(69, 35);
            this.RemoveSimpleButton.TabIndex = 123;
            this.RemoveSimpleButton.Text = "Remove";
            // 
            // UploadSimpleButton
            // 
            this.UploadSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.UploadSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadSimpleButton.Image")));
            this.UploadSimpleButton.Location = new System.Drawing.Point(694, 43);
            this.UploadSimpleButton.Name = "UploadSimpleButton";
            this.UploadSimpleButton.Size = new System.Drawing.Size(69, 40);
            this.UploadSimpleButton.TabIndex = 122;
            this.UploadSimpleButton.Text = "Upload";
            this.UploadSimpleButton.Click += new System.EventHandler(this.UploadSimpleButton_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(414, 43);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(44, 13);
            this.labelControl16.TabIndex = 121;
            this.labelControl16.Text = "BOQ PDF";
            // 
            // PDFGalleryControl
            // 
            this.PDFGalleryControl.Controls.Add(this.galleryControlClient1);
            this.PDFGalleryControl.DesignGalleryGroupIndex = 0;
            this.PDFGalleryControl.DesignGalleryItemIndex = 0;
            this.PDFGalleryControl.Location = new System.Drawing.Point(466, 41);
            this.PDFGalleryControl.Name = "PDFGalleryControl";
            this.PDFGalleryControl.Size = new System.Drawing.Size(215, 266);
            this.PDFGalleryControl.TabIndex = 120;
            this.PDFGalleryControl.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.PDFGalleryControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(194, 262);
            // 
            // CloseSimpleButton
            // 
            this.CloseSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.CloseSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseSimpleButton.Image")));
            this.CloseSimpleButton.Location = new System.Drawing.Point(663, 427);
            this.CloseSimpleButton.Name = "CloseSimpleButton";
            this.CloseSimpleButton.Size = new System.Drawing.Size(100, 60);
            this.CloseSimpleButton.TabIndex = 115;
            this.CloseSimpleButton.Text = "Close";
            // 
            // ClearSimpleButton
            // 
            this.ClearSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.ClearSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearSimpleButton.Image")));
            this.ClearSimpleButton.Location = new System.Drawing.Point(547, 427);
            this.ClearSimpleButton.Name = "ClearSimpleButton";
            this.ClearSimpleButton.Size = new System.Drawing.Size(100, 60);
            this.ClearSimpleButton.TabIndex = 114;
            this.ClearSimpleButton.Text = "Clear";
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.SaveSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveSimpleButton.Image")));
            this.SaveSimpleButton.Location = new System.Drawing.Point(428, 427);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(100, 60);
            this.SaveSimpleButton.TabIndex = 4;
            this.SaveSimpleButton.Text = "Save";
            // 
            // CustomerLookUpEdit
            // 
            this.CustomerLookUpEdit.EnterMoveNextControl = true;
            this.CustomerLookUpEdit.Location = new System.Drawing.Point(118, 89);
            this.CustomerLookUpEdit.Name = "CustomerLookUpEdit";
            this.CustomerLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.CustomerLookUpEdit.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLookUpEdit.Properties.AppearanceDropDown.Options.UseFont = true;
            this.CustomerLookUpEdit.Properties.AutoHeight = false;
            this.CustomerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerCode", "Customer Code", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CustomerLookUpEdit.Properties.DisplayMember = "CustomerCode";
            this.CustomerLookUpEdit.Properties.NullText = "<<Please Select One>>";
            this.CustomerLookUpEdit.Properties.ValueMember = "ID";
            this.CustomerLookUpEdit.Size = new System.Drawing.Size(255, 25);
            this.CustomerLookUpEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 93;
            this.labelControl1.Text = "Customer Code";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // MasterSchedulePDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 540);
            this.Controls.Add(this.groupControl1);
            this.Name = "MasterSchedulePDFForm";
            this.Text = "MasterSchedulePDFForm";
            this.Load += new System.EventHandler(this.MasterSchedulePDFForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFGalleryControl)).EndInit();
            this.PDFGalleryControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ViewSimpleButton;
        private System.Windows.Forms.Label Uploadlabel;
        private System.Windows.Forms.ProgressBar UploadProgressBar;
        private DevExpress.XtraEditors.SimpleButton RemoveSimpleButton;
        private DevExpress.XtraEditors.SimpleButton UploadSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraBars.Ribbon.GalleryControl PDFGalleryControl;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraEditors.SimpleButton CloseSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ClearSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraEditors.LookUpEdit CustomerLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}