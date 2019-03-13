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
            this.lotInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.lotId_textBox = new System.Windows.Forms.TextBox();
            this.lotId_label = new System.Windows.Forms.Label();
            this.package_groupBox = new System.Windows.Forms.GroupBox();
            this.Attachment_imageUpload = new ImageUpload.ImageUpload();
            this.attach_label = new System.Windows.Forms.Label();
            this.PackageType_imageUpload = new ImageUpload.ImageUpload();
            this.package_label = new System.Windows.Forms.Label();
            this.ShipLabel_imageUpload = new ImageUpload.ImageUpload();
            this.ship_label = new System.Windows.Forms.Label();
            this.Fosb_imageUpload = new ImageUpload.ImageUpload();
            this.fosb_label = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.lotInfo_groupBox.SuspendLayout();
            this.package_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(663, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(463, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Size = new System.Drawing.Size(72, 32);
            this.btnCreate.Visible = false;
            // 
            // btnEdite
            // 
            this.btnEdite.Location = new System.Drawing.Point(563, 10);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdite.Size = new System.Drawing.Size(72, 32);
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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
            this.lotInfo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotInfo_groupBox.Location = new System.Drawing.Point(0, 0);
            this.lotInfo_groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lotInfo_groupBox.Name = "lotInfo_groupBox";
            this.lotInfo_groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lotInfo_groupBox.Size = new System.Drawing.Size(750, 80);
            this.lotInfo_groupBox.TabIndex = 1;
            this.lotInfo_groupBox.TabStop = false;
            this.lotInfo_groupBox.Text = "Lot Information";
            // 
            // lotId_textBox
            // 
            this.lotId_textBox.Location = new System.Drawing.Point(85, 36);
            this.lotId_textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lotId_textBox.Name = "lotId_textBox";
            this.lotId_textBox.Size = new System.Drawing.Size(190, 21);
            this.lotId_textBox.TabIndex = 1;
            this.lotId_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lotId_textBox_KeyPress);
            // 
            // lotId_label
            // 
            this.lotId_label.AutoSize = true;
            this.lotId_label.Location = new System.Drawing.Point(30, 38);
            this.lotId_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lotId_label.Name = "lotId_label";
            this.lotId_label.Size = new System.Drawing.Size(42, 15);
            this.lotId_label.TabIndex = 0;
            this.lotId_label.Text = "Lot ID:";
            // 
            // package_groupBox
            // 
            this.package_groupBox.Controls.Add(this.Attachment_imageUpload);
            this.package_groupBox.Controls.Add(this.attach_label);
            this.package_groupBox.Controls.Add(this.PackageType_imageUpload);
            this.package_groupBox.Controls.Add(this.package_label);
            this.package_groupBox.Controls.Add(this.ShipLabel_imageUpload);
            this.package_groupBox.Controls.Add(this.ship_label);
            this.package_groupBox.Controls.Add(this.Fosb_imageUpload);
            this.package_groupBox.Controls.Add(this.fosb_label);
            this.package_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.package_groupBox.Location = new System.Drawing.Point(0, 80);
            this.package_groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.package_groupBox.Name = "package_groupBox";
            this.package_groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.package_groupBox.Size = new System.Drawing.Size(750, 450);
            this.package_groupBox.TabIndex = 2;
            this.package_groupBox.TabStop = false;
            this.package_groupBox.Text = "Wafer Package";
            // 
            // Attachment_imageUpload
            // 
            this.Attachment_imageUpload.Location = new System.Drawing.Point(256, 184);
            this.Attachment_imageUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Attachment_imageUpload.Name = "Attachment_imageUpload";
            this.Attachment_imageUpload.PicStream = null;
            this.Attachment_imageUpload.Size = new System.Drawing.Size(350, 42);
            this.Attachment_imageUpload.TabIndex = 1;
            // 
            // attach_label
            // 
            this.attach_label.AutoSize = true;
            this.attach_label.Location = new System.Drawing.Point(30, 197);
            this.attach_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attach_label.Name = "attach_label";
            this.attach_label.Size = new System.Drawing.Size(68, 15);
            this.attach_label.TabIndex = 0;
            this.attach_label.Text = "Attachment";
            // 
            // PackageType_imageUpload
            // 
            this.PackageType_imageUpload.Location = new System.Drawing.Point(256, 135);
            this.PackageType_imageUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PackageType_imageUpload.Name = "PackageType_imageUpload";
            this.PackageType_imageUpload.PicStream = null;
            this.PackageType_imageUpload.Size = new System.Drawing.Size(350, 42);
            this.PackageType_imageUpload.TabIndex = 1;
            // 
            // package_label
            // 
            this.package_label.AutoSize = true;
            this.package_label.Location = new System.Drawing.Point(30, 146);
            this.package_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.package_label.Name = "package_label";
            this.package_label.Size = new System.Drawing.Size(80, 15);
            this.package_label.TabIndex = 0;
            this.package_label.Text = "Package type";
            // 
            // ShipLabel_imageUpload
            // 
            this.ShipLabel_imageUpload.Location = new System.Drawing.Point(256, 84);
            this.ShipLabel_imageUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ShipLabel_imageUpload.Name = "ShipLabel_imageUpload";
            this.ShipLabel_imageUpload.PicStream = null;
            this.ShipLabel_imageUpload.Size = new System.Drawing.Size(350, 42);
            this.ShipLabel_imageUpload.TabIndex = 1;
            // 
            // ship_label
            // 
            this.ship_label.AutoSize = true;
            this.ship_label.Location = new System.Drawing.Point(30, 95);
            this.ship_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ship_label.Name = "ship_label";
            this.ship_label.Size = new System.Drawing.Size(136, 15);
            this.ship_label.TabIndex = 0;
            this.ship_label.Text = "Shipping label attached";
            // 
            // Fosb_imageUpload
            // 
            this.Fosb_imageUpload.Location = new System.Drawing.Point(256, 32);
            this.Fosb_imageUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Fosb_imageUpload.Name = "Fosb_imageUpload";
            this.Fosb_imageUpload.PicStream = null;
            this.Fosb_imageUpload.Size = new System.Drawing.Size(350, 42);
            this.Fosb_imageUpload.TabIndex = 1;
            // 
            // fosb_label
            // 
            this.fosb_label.AutoSize = true;
            this.fosb_label.Location = new System.Drawing.Point(30, 44);
            this.fosb_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fosb_label.Name = "fosb_label";
            this.fosb_label.Size = new System.Drawing.Size(209, 15);
            this.fosb_label.TabIndex = 0;
            this.fosb_label.Text = "No chipping,crack and cross in FOSB";
            // 
            // FrmLotPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 580);
            this.Controls.Add(this.package_groupBox);
            this.Controls.Add(this.lotInfo_groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLotPackage";
            this.Text = "Lot Package";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.lotInfo_groupBox, 0);
            this.Controls.SetChildIndex(this.package_groupBox, 0);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.lotInfo_groupBox.ResumeLayout(false);
            this.lotInfo_groupBox.PerformLayout();
            this.package_groupBox.ResumeLayout(false);
            this.package_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lotInfo_groupBox;
        private System.Windows.Forms.TextBox lotId_textBox;
        private System.Windows.Forms.Label lotId_label;
        private System.Windows.Forms.GroupBox package_groupBox;
        private ImageUpload.ImageUpload Fosb_imageUpload;
        private System.Windows.Forms.Label fosb_label;
        private ImageUpload.ImageUpload Attachment_imageUpload;
        private System.Windows.Forms.Label attach_label;
        private ImageUpload.ImageUpload PackageType_imageUpload;
        private System.Windows.Forms.Label package_label;
        private ImageUpload.ImageUpload ShipLabel_imageUpload;
        private System.Windows.Forms.Label ship_label;
    }
}