namespace ImageUpload
{
    partial class ImageUpload
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSts = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtPicName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSts);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowser);
            this.panel1.Controls.Add(this.txtPicName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 32);
            this.panel1.TabIndex = 2;
            // 
            // lblSts
            // 
            this.lblSts.AutoSize = true;
            this.lblSts.Location = new System.Drawing.Point(7, 10);
            this.lblSts.Name = "lblSts";
            this.lblSts.Size = new System.Drawing.Size(29, 12);
            this.lblSts.TabIndex = 59;
            this.lblSts.Text = "未传";
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpload.Location = new System.Drawing.Point(240, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 21);
            this.btnUpload.TabIndex = 58;
            this.btnUpload.Text = "Save";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(205, 6);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(32, 21);
            this.btnBrowser.TabIndex = 57;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtPicName
            // 
            this.txtPicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPicName.Location = new System.Drawing.Point(39, 6);
            this.txtPicName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPicName.Name = "txtPicName";
            this.txtPicName.Size = new System.Drawing.Size(164, 21);
            this.txtPicName.TabIndex = 0;
            // 
            // ImageUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ImageUpload";
            this.Size = new System.Drawing.Size(337, 32);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtPicName;
        public System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSts;
    }
}
