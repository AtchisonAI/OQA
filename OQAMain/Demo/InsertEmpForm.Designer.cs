namespace OQAMain
{
    partial class InsertEmpForm
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.id_tbx = new System.Windows.Forms.TextBox();
            this.ename_tbx = new System.Windows.Forms.TextBox();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_tbx = new System.Windows.Forms.TextBox();
            this.deptname_tbx = new System.Windows.Forms.TextBox();
            this.deptcode_tbx = new System.Windows.Forms.TextBox();
            this.Emp_groupBox = new System.Windows.Forms.GroupBox();
            this.Rms_groupBox = new System.Windows.Forms.GroupBox();
            this.RDept_textBox = new System.Windows.Forms.TextBox();
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.UserId_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Emp_groupBox.SuspendLayout();
            this.Rms_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(112, 320);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(56, 22);
            this.insert_btn.TabIndex = 0;
            this.insert_btn.Text = "插入";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(226, 320);
            this.cancle_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(56, 22);
            this.cancle_btn.TabIndex = 0;
            this.cancle_btn.Text = "取消";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_Click);
            // 
            // id_tbx
            // 
            this.id_tbx.Location = new System.Drawing.Point(56, 28);
            this.id_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(79, 21);
            this.id_tbx.TabIndex = 0;
            // 
            // ename_tbx
            // 
            this.ename_tbx.Location = new System.Drawing.Point(56, 136);
            this.ename_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ename_tbx.Name = "ename_tbx";
            this.ename_tbx.Size = new System.Drawing.Size(79, 21);
            this.ename_tbx.TabIndex = 4;
            // 
            // name_tbx
            // 
            this.name_tbx.Location = new System.Drawing.Point(56, 80);
            this.name_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_tbx.Name = "name_tbx";
            this.name_tbx.Size = new System.Drawing.Size(79, 21);
            this.name_tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "EName：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "DepatCode：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "DepatName：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email：";
            // 
            // email_tbx
            // 
            this.email_tbx.Location = new System.Drawing.Point(205, 136);
            this.email_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_tbx.Name = "email_tbx";
            this.email_tbx.Size = new System.Drawing.Size(174, 21);
            this.email_tbx.TabIndex = 5;
            // 
            // deptname_tbx
            // 
            this.deptname_tbx.Location = new System.Drawing.Point(230, 79);
            this.deptname_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deptname_tbx.Name = "deptname_tbx";
            this.deptname_tbx.Size = new System.Drawing.Size(79, 21);
            this.deptname_tbx.TabIndex = 3;
            // 
            // deptcode_tbx
            // 
            this.deptcode_tbx.Location = new System.Drawing.Point(230, 28);
            this.deptcode_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deptcode_tbx.Name = "deptcode_tbx";
            this.deptcode_tbx.Size = new System.Drawing.Size(79, 21);
            this.deptcode_tbx.TabIndex = 1;
            // 
            // Emp_groupBox
            // 
            this.Emp_groupBox.Controls.Add(this.label5);
            this.Emp_groupBox.Controls.Add(this.label6);
            this.Emp_groupBox.Controls.Add(this.id_tbx);
            this.Emp_groupBox.Controls.Add(this.label3);
            this.Emp_groupBox.Controls.Add(this.ename_tbx);
            this.Emp_groupBox.Controls.Add(this.label2);
            this.Emp_groupBox.Controls.Add(this.email_tbx);
            this.Emp_groupBox.Controls.Add(this.name_tbx);
            this.Emp_groupBox.Controls.Add(this.label4);
            this.Emp_groupBox.Controls.Add(this.deptname_tbx);
            this.Emp_groupBox.Controls.Add(this.label1);
            this.Emp_groupBox.Controls.Add(this.deptcode_tbx);
            this.Emp_groupBox.Location = new System.Drawing.Point(9, 10);
            this.Emp_groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Emp_groupBox.Name = "Emp_groupBox";
            this.Emp_groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Emp_groupBox.Size = new System.Drawing.Size(386, 174);
            this.Emp_groupBox.TabIndex = 5;
            this.Emp_groupBox.TabStop = false;
            this.Emp_groupBox.Text = "EMP";
            // 
            // Rms_groupBox
            // 
            this.Rms_groupBox.Controls.Add(this.RDept_textBox);
            this.Rms_groupBox.Controls.Add(this.Passwd_textBox);
            this.Rms_groupBox.Controls.Add(this.Username_textBox);
            this.Rms_groupBox.Controls.Add(this.UserId_textBox);
            this.Rms_groupBox.Controls.Add(this.label8);
            this.Rms_groupBox.Controls.Add(this.label10);
            this.Rms_groupBox.Controls.Add(this.label9);
            this.Rms_groupBox.Controls.Add(this.label7);
            this.Rms_groupBox.Location = new System.Drawing.Point(9, 201);
            this.Rms_groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rms_groupBox.Name = "Rms_groupBox";
            this.Rms_groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Rms_groupBox.Size = new System.Drawing.Size(386, 114);
            this.Rms_groupBox.TabIndex = 6;
            this.Rms_groupBox.TabStop = false;
            this.Rms_groupBox.Text = "RMS";
            // 
            // RDept_textBox
            // 
            this.RDept_textBox.Location = new System.Drawing.Point(218, 73);
            this.RDept_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDept_textBox.Name = "RDept_textBox";
            this.RDept_textBox.Size = new System.Drawing.Size(79, 21);
            this.RDept_textBox.TabIndex = 1;
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.Location = new System.Drawing.Point(218, 20);
            this.Passwd_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.Size = new System.Drawing.Size(79, 21);
            this.Passwd_textBox.TabIndex = 1;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(69, 73);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(79, 21);
            this.Username_textBox.TabIndex = 1;
            // 
            // UserId_textBox
            // 
            this.UserId_textBox.Location = new System.Drawing.Point(56, 20);
            this.UserId_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserId_textBox.Name = "UserId_textBox";
            this.UserId_textBox.Size = new System.Drawing.Size(79, 21);
            this.UserId_textBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dept:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "UserName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "UserId:";
            // 
            // InsertEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 353);
            this.Controls.Add(this.Rms_groupBox);
            this.Controls.Add(this.Emp_groupBox);
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.insert_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InsertEmpForm";
            this.Text = "2";
            this.Emp_groupBox.ResumeLayout(false);
            this.Emp_groupBox.PerformLayout();
            this.Rms_groupBox.ResumeLayout(false);
            this.Rms_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button cancle_btn;
        private System.Windows.Forms.TextBox id_tbx;
        private System.Windows.Forms.TextBox ename_tbx;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_tbx;
        private System.Windows.Forms.TextBox deptname_tbx;
        private System.Windows.Forms.TextBox deptcode_tbx;
        private System.Windows.Forms.GroupBox Emp_groupBox;
        private System.Windows.Forms.GroupBox Rms_groupBox;
        private System.Windows.Forms.TextBox RDept_textBox;
        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox UserId_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}