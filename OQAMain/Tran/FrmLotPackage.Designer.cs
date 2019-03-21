namespace OQAMain
{
    partial class FrmLotPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotPackage));
            this.lotInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.lotId_textBox = new System.Windows.Forms.TextBox();
            this.lotId_label = new System.Windows.Forms.Label();
            this.fosb_label = new System.Windows.Forms.Label();
            this.Fosb_imageUpload = new ImageUpload.ImageUpload();
            this.ship_label = new System.Windows.Forms.Label();
            this.ShipLabel_imageUpload = new ImageUpload.ImageUpload();
            this.package_label = new System.Windows.Forms.Label();
            this.PackageType_imageUpload = new ImageUpload.ImageUpload();
            this.attach_label = new System.Windows.Forms.Label();
            this.Attachment_imageUpload = new ImageUpload.ImageUpload();
            this.package_groupBox = new System.Windows.Forms.GroupBox();
            this.pic_groupBox = new System.Windows.Forms.GroupBox();
            this.pictureView = new OQA_Core.Controls.PictureView();
            this.pnlMenu.SuspendLayout();
            this.lotInfo_groupBox.SuspendLayout();
            this.package_groupBox.SuspendLayout();
            this.pic_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1186, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Size = new System.Drawing.Size(62, 26);
            this.btnClose.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(996, 8);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Size = new System.Drawing.Size(62, 26);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(1091, 8);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdite.Size = new System.Drawing.Size(62, 26);
            this.btnEdite.TabIndex = 5;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 726);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlMenu.Size = new System.Drawing.Size(1272, 40);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            // 
            // lblSucessMsg
            // 
            this.lblSucessMsg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // lotInfo_groupBox
            // 
            this.lotInfo_groupBox.Controls.Add(this.lotId_textBox);
            this.lotInfo_groupBox.Controls.Add(this.lotId_label);
            this.lotInfo_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lotInfo_groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lotInfo_groupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotInfo_groupBox.Location = new System.Drawing.Point(0, 0);
            this.lotInfo_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.lotInfo_groupBox.Name = "lotInfo_groupBox";
            this.lotInfo_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.lotInfo_groupBox.Size = new System.Drawing.Size(1272, 64);
            this.lotInfo_groupBox.TabIndex = 1;
            this.lotInfo_groupBox.TabStop = false;
            this.lotInfo_groupBox.Text = "Lot Information";
            // 
            // lotId_textBox
            // 
            this.lotId_textBox.Location = new System.Drawing.Point(72, 28);
            this.lotId_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.lotId_textBox.Name = "lotId_textBox";
            this.lotId_textBox.Size = new System.Drawing.Size(163, 21);
            this.lotId_textBox.TabIndex = 0;
            this.lotId_textBox.Click += new System.EventHandler(this.lotId_textBox_Click);
            this.lotId_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lotId_textBox_KeyPress);
            // 
            // lotId_label
            // 
            this.lotId_label.AutoSize = true;
            this.lotId_label.Location = new System.Drawing.Point(25, 32);
            this.lotId_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lotId_label.Name = "lotId_label";
            this.lotId_label.Size = new System.Drawing.Size(47, 12);
            this.lotId_label.TabIndex = 1;
            this.lotId_label.Text = "Lot ID:";
            // 
            // fosb_label
            // 
            this.fosb_label.AutoSize = true;
            this.fosb_label.Location = new System.Drawing.Point(28, 41);
            this.fosb_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fosb_label.Name = "fosb_label";
            this.fosb_label.Size = new System.Drawing.Size(215, 12);
            this.fosb_label.TabIndex = 1;
            this.fosb_label.Text = "No shipping,crack and cross in FOSB";
            // 
            // Fosb_imageUpload
            // 
            this.Fosb_imageUpload.Enabled = false;
            this.Fosb_imageUpload.Location = new System.Drawing.Point(270, 32);
            this.Fosb_imageUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fosb_imageUpload.Name = "Fosb_imageUpload";
            this.Fosb_imageUpload.PicStream = null;
            this.Fosb_imageUpload.Size = new System.Drawing.Size(380, 34);
            this.Fosb_imageUpload.TabIndex = 1;
            this.Fosb_imageUpload.UpLoadByArea = null;
            this.Fosb_imageUpload.UpLoadByLot = null;
            this.Fosb_imageUpload.UpLoadBySide = null;
            this.Fosb_imageUpload.UpLoadByWafer = null;
            this.Fosb_imageUpload.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.Fosb_imageUpload_btnUploadClicked);
            this.Fosb_imageUpload.PreviewLableClicked += new ImageUpload.ImageUpload.PreViewClickHandle(this.Fosb_imageUpload_PreviewLableClicked);
            // 
            // ship_label
            // 
            this.ship_label.AutoSize = true;
            this.ship_label.Location = new System.Drawing.Point(28, 82);
            this.ship_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ship_label.Name = "ship_label";
            this.ship_label.Size = new System.Drawing.Size(143, 12);
            this.ship_label.TabIndex = 1;
            this.ship_label.Text = "Shipping label attached";
            // 
            // ShipLabel_imageUpload
            // 
            this.ShipLabel_imageUpload.Enabled = false;
            this.ShipLabel_imageUpload.Location = new System.Drawing.Point(270, 73);
            this.ShipLabel_imageUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShipLabel_imageUpload.Name = "ShipLabel_imageUpload";
            this.ShipLabel_imageUpload.PicStream = null;
            this.ShipLabel_imageUpload.Size = new System.Drawing.Size(380, 34);
            this.ShipLabel_imageUpload.TabIndex = 2;
            this.ShipLabel_imageUpload.UpLoadByArea = null;
            this.ShipLabel_imageUpload.UpLoadByLot = null;
            this.ShipLabel_imageUpload.UpLoadBySide = null;
            this.ShipLabel_imageUpload.UpLoadByWafer = null;
            this.ShipLabel_imageUpload.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.ShipLabel_imageUpload_btnUploadClicked);
            this.ShipLabel_imageUpload.PreviewLableClicked += new ImageUpload.ImageUpload.PreViewClickHandle(this.ShipLabel_imageUpload_PreviewLableClicked);
            // 
            // package_label
            // 
            this.package_label.AutoSize = true;
            this.package_label.Location = new System.Drawing.Point(28, 123);
            this.package_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.package_label.Name = "package_label";
            this.package_label.Size = new System.Drawing.Size(77, 12);
            this.package_label.TabIndex = 1;
            this.package_label.Text = "Package type";
            // 
            // PackageType_imageUpload
            // 
            this.PackageType_imageUpload.Enabled = false;
            this.PackageType_imageUpload.Location = new System.Drawing.Point(270, 113);
            this.PackageType_imageUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PackageType_imageUpload.Name = "PackageType_imageUpload";
            this.PackageType_imageUpload.PicStream = null;
            this.PackageType_imageUpload.Size = new System.Drawing.Size(380, 34);
            this.PackageType_imageUpload.TabIndex = 3;
            this.PackageType_imageUpload.UpLoadByArea = null;
            this.PackageType_imageUpload.UpLoadByLot = null;
            this.PackageType_imageUpload.UpLoadBySide = null;
            this.PackageType_imageUpload.UpLoadByWafer = null;
            this.PackageType_imageUpload.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.PackageType_imageUpload_btnUploadClicked);
            this.PackageType_imageUpload.PreviewLableClicked += new ImageUpload.ImageUpload.PreViewClickHandle(this.PackageType_imageUpload_PreviewLableClicked);
            // 
            // attach_label
            // 
            this.attach_label.AutoSize = true;
            this.attach_label.Location = new System.Drawing.Point(28, 164);
            this.attach_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attach_label.Name = "attach_label";
            this.attach_label.Size = new System.Drawing.Size(65, 12);
            this.attach_label.TabIndex = 1;
            this.attach_label.Text = "Attachment";
            // 
            // Attachment_imageUpload
            // 
            this.Attachment_imageUpload.Enabled = false;
            this.Attachment_imageUpload.Location = new System.Drawing.Point(270, 153);
            this.Attachment_imageUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Attachment_imageUpload.Name = "Attachment_imageUpload";
            this.Attachment_imageUpload.PicStream = null;
            this.Attachment_imageUpload.Size = new System.Drawing.Size(380, 34);
            this.Attachment_imageUpload.TabIndex = 4;
            this.Attachment_imageUpload.UpLoadByArea = null;
            this.Attachment_imageUpload.UpLoadByLot = null;
            this.Attachment_imageUpload.UpLoadBySide = null;
            this.Attachment_imageUpload.UpLoadByWafer = null;
            this.Attachment_imageUpload.btnUploadClicked += new ImageUpload.ImageUpload.BtnClickHandle(this.Attachment_imageUpload_btnUploadClicked);
            this.Attachment_imageUpload.PreviewLableClicked += new ImageUpload.ImageUpload.PreViewClickHandle(this.Attachment_imageUpload_PreviewLableClicked);
            // 
            // package_groupBox
            // 
            this.package_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.package_groupBox.Controls.Add(this.Attachment_imageUpload);
            this.package_groupBox.Controls.Add(this.attach_label);
            this.package_groupBox.Controls.Add(this.PackageType_imageUpload);
            this.package_groupBox.Controls.Add(this.package_label);
            this.package_groupBox.Controls.Add(this.ShipLabel_imageUpload);
            this.package_groupBox.Controls.Add(this.ship_label);
            this.package_groupBox.Controls.Add(this.Fosb_imageUpload);
            this.package_groupBox.Controls.Add(this.fosb_label);
            this.package_groupBox.Location = new System.Drawing.Point(0, 65);
            this.package_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Name = "package_groupBox";
            this.package_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.package_groupBox.Size = new System.Drawing.Size(715, 660);
            this.package_groupBox.TabIndex = 2;
            this.package_groupBox.TabStop = false;
            this.package_groupBox.Text = "Wafer Package";
            // 
            // pic_groupBox
            // 
            this.pic_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_groupBox.Controls.Add(this.pictureView);
            this.pic_groupBox.Location = new System.Drawing.Point(722, 65);
            this.pic_groupBox.Name = "pic_groupBox";
            this.pic_groupBox.Size = new System.Drawing.Size(550, 660);
            this.pic_groupBox.TabIndex = 3;
            this.pic_groupBox.TabStop = false;
            this.pic_groupBox.Text = "Preview";
            // 
            // pictureView
            // 
            this.pictureView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureView.Location = new System.Drawing.Point(3, 17);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(544, 640);
            this.pictureView.TabIndex = 0;
            // 
            // FrmLotPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1272, 766);
            this.Controls.Add(this.pic_groupBox);
            this.Controls.Add(this.package_groupBox);
            this.Controls.Add(this.lotInfo_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLotPackage";
            this.Text = "Lot Package";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.lotInfo_groupBox, 0);
            this.Controls.SetChildIndex(this.package_groupBox, 0);
            this.Controls.SetChildIndex(this.pic_groupBox, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.lotInfo_groupBox.ResumeLayout(false);
            this.lotInfo_groupBox.PerformLayout();
            this.package_groupBox.ResumeLayout(false);
            this.package_groupBox.PerformLayout();
            this.pic_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lotInfo_groupBox;
        private System.Windows.Forms.TextBox lotId_textBox;
        private System.Windows.Forms.Label lotId_label;
        private System.Windows.Forms.Label fosb_label;
        private ImageUpload.ImageUpload Fosb_imageUpload;
        private System.Windows.Forms.Label ship_label;
        private ImageUpload.ImageUpload ShipLabel_imageUpload;
        private System.Windows.Forms.Label package_label;
        private ImageUpload.ImageUpload PackageType_imageUpload;
        private System.Windows.Forms.Label attach_label;
        private ImageUpload.ImageUpload Attachment_imageUpload;
        private System.Windows.Forms.GroupBox package_groupBox;
        private System.Windows.Forms.GroupBox pic_groupBox;
        private OQA_Core.Controls.PictureView pictureView;
    }
}