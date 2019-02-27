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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(207, 242);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(72, 30);
            this.logInBtn.TabIndex = 0;
            this.logInBtn.Text = "登陆";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleBtn.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancleBtn.ForeColor = System.Drawing.Color.White;
            this.cancleBtn.Location = new System.Drawing.Point(360, 242);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(72, 30);
            this.cancleBtn.TabIndex = 1;
            this.cancleBtn.Text = "退出";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(257, 130);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(177, 25);
            this.userNameTbx.TabIndex = 2;
            // 
            // passwdTbx
            // 
            this.passwdTbx.Location = new System.Drawing.Point(257, 185);
            this.passwdTbx.Name = "passwdTbx";
            this.passwdTbx.PasswordChar = '*';
            this.passwdTbx.Size = new System.Drawing.Size(176, 25);
            this.passwdTbx.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 45);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(189, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 294);
            this.Controls.Add(this.label1);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
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
        private System.Windows.Forms.Label label1;
    }
}