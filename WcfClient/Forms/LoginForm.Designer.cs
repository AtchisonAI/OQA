namespace WcfClient
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logInBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.userNameTbx = new System.Windows.Forms.TextBox();
            this.passwdTbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_label = new System.Windows.Forms.Label();
            this.pd_label = new System.Windows.Forms.Label();
            this.tile_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.logInBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInBtn.Font = new System.Drawing.Font("华文行楷", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(243, 253);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(70, 32);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "登陆";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancleBtn.Font = new System.Drawing.Font("华文行楷", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancleBtn.ForeColor = System.Drawing.Color.White;
            this.cancleBtn.Location = new System.Drawing.Point(371, 253);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(70, 32);
            this.cancleBtn.TabIndex = 3;
            this.cancleBtn.Text = "退出";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(257, 140);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(191, 25);
            this.userNameTbx.TabIndex = 0;
            this.userNameTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTbx_KeyPress);
            // 
            // passwdTbx
            // 
            this.passwdTbx.Location = new System.Drawing.Point(257, 195);
            this.passwdTbx.Name = "passwdTbx";
            this.passwdTbx.PasswordChar = '*';
            this.passwdTbx.Size = new System.Drawing.Size(191, 25);
            this.passwdTbx.TabIndex = 1;
            this.passwdTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdTbx_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 52);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.Transparent;
            this.id_label.Font = new System.Drawing.Font("华文新魏", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.id_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.id_label.Location = new System.Drawing.Point(195, 143);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(53, 19);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "账号:";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pd_label
            // 
            this.pd_label.AutoSize = true;
            this.pd_label.BackColor = System.Drawing.Color.Transparent;
            this.pd_label.Font = new System.Drawing.Font("华文新魏", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pd_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.pd_label.Location = new System.Drawing.Point(195, 198);
            this.pd_label.Name = "pd_label";
            this.pd_label.Size = new System.Drawing.Size(53, 19);
            this.pd_label.TabIndex = 7;
            this.pd_label.Text = "密码:";
            this.pd_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile_label
            // 
            this.tile_label.BackColor = System.Drawing.Color.Transparent;
            this.tile_label.Font = new System.Drawing.Font("华文彩云", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tile_label.ForeColor = System.Drawing.Color.White;
            this.tile_label.Location = new System.Drawing.Point(2, 56);
            this.tile_label.Name = "tile_label";
            this.tile_label.Size = new System.Drawing.Size(467, 64);
            this.tile_label.TabIndex = 8;
            this.tile_label.Text = "OQA检验系统";
            this.tile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 310);
            this.Controls.Add(this.tile_label);
            this.Controls.Add(this.pd_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwdTbx);
            this.Controls.Add(this.userNameTbx);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.logInBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.TextBox passwdTbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pd_label;
        private System.Windows.Forms.Label tile_label;
    }
}