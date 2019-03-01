namespace OQAMain
{
    partial class EmpForm
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
            this.sfScrollFrame1 = new Syncfusion.WinForms.Controls.SfScrollFrame();
            this.page_label = new System.Windows.Forms.Label();
            this.emp_sfDataPager = new Syncfusion.WinForms.DataPager.SfDataPager();
            this.page_sfComboBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.delete_sfButton = new Syncfusion.WinForms.Controls.SfButton();
            this.dept_label = new System.Windows.Forms.Label();
            this.dept_textBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.update_sfButton = new Syncfusion.WinForms.Controls.SfButton();
            this.empIdlabel = new System.Windows.Forms.Label();
            this.emp_sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.empId_textBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.insert_sfButton = new Syncfusion.WinForms.Controls.SfButton();
            this.reset_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.search_btn = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // page_label
            // 
            this.page_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(711, 519);
            this.page_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(59, 12);
            this.page_label.TabIndex = 10;
            this.page_label.Text = "PageSize:";
            // 
            // emp_sfDataPager
            // 
            this.emp_sfDataPager.AccessibleName = "DataPager";
            this.emp_sfDataPager.AllowOnDemandPaging = true;
            this.emp_sfDataPager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emp_sfDataPager.Enabled = false;
            this.emp_sfDataPager.Location = new System.Drawing.Point(426, 503);
            this.emp_sfDataPager.Margin = new System.Windows.Forms.Padding(2);
            this.emp_sfDataPager.Name = "emp_sfDataPager";
            this.emp_sfDataPager.PageCount = 1;
            this.emp_sfDataPager.Size = new System.Drawing.Size(272, 28);
            this.emp_sfDataPager.TabIndex = 0;
            this.emp_sfDataPager.Tag = "474:37:352:428";
            this.emp_sfDataPager.Text = "emp_sfDataPager";
            this.emp_sfDataPager.PageIndexChanged += new System.EventHandler<Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs>(this.emp_sfDataPager_PageIndexChanged);
            // 
            // page_sfComboBox
            // 
            this.page_sfComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_sfComboBox.Location = new System.Drawing.Point(774, 511);
            this.page_sfComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.page_sfComboBox.Name = "page_sfComboBox";
            this.page_sfComboBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.page_sfComboBox.Size = new System.Drawing.Size(54, 20);
            this.page_sfComboBox.TabIndex = 7;
            this.page_sfComboBox.Tag = "50:25:883:433";
            this.page_sfComboBox.ValueMember = "5,10,20,50";
            this.page_sfComboBox.SelectedIndexChanged += new System.EventHandler(this.page_sfComboBox_SelectedIndexChanged);
            // 
            // delete_sfButton
            // 
            this.delete_sfButton.AccessibleName = "Button";
            this.delete_sfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_sfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.delete_sfButton.Location = new System.Drawing.Point(648, 616);
            this.delete_sfButton.Margin = new System.Windows.Forms.Padding(2);
            this.delete_sfButton.Name = "delete_sfButton";
            this.delete_sfButton.Size = new System.Drawing.Size(50, 23);
            this.delete_sfButton.TabIndex = 9;
            this.delete_sfButton.Text = "删除";
            this.delete_sfButton.Click += new System.EventHandler(this.delete_sfButton_Click);
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(196, 24);
            this.dept_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(41, 12);
            this.dept_label.TabIndex = 2;
            this.dept_label.Tag = "52:15:346:18";
            this.dept_label.Text = "部门：";
            // 
            // dept_textBoxExt
            // 
            this.dept_textBoxExt.BeforeTouchSize = new System.Drawing.Size(112, 21);
            this.dept_textBoxExt.Location = new System.Drawing.Point(237, 20);
            this.dept_textBoxExt.Margin = new System.Windows.Forms.Padding(2);
            this.dept_textBoxExt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dept_textBoxExt.Name = "dept_textBoxExt";
            this.dept_textBoxExt.Size = new System.Drawing.Size(112, 21);
            this.dept_textBoxExt.TabIndex = 3;
            this.dept_textBoxExt.Tag = "137:25:401:14";
            // 
            // update_sfButton
            // 
            this.update_sfButton.AccessibleName = "Button";
            this.update_sfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_sfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.update_sfButton.Location = new System.Drawing.Point(720, 616);
            this.update_sfButton.Margin = new System.Windows.Forms.Padding(2);
            this.update_sfButton.Name = "update_sfButton";
            this.update_sfButton.Size = new System.Drawing.Size(50, 23);
            this.update_sfButton.TabIndex = 9;
            this.update_sfButton.Text = "更新";
            this.update_sfButton.Click += new System.EventHandler(this.update_sfButton_Click);
            // 
            // empIdlabel
            // 
            this.empIdlabel.AutoSize = true;
            this.empIdlabel.Location = new System.Drawing.Point(25, 26);
            this.empIdlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empIdlabel.Name = "empIdlabel";
            this.empIdlabel.Size = new System.Drawing.Size(41, 12);
            this.empIdlabel.TabIndex = 2;
            this.empIdlabel.Tag = "52:15:75:18";
            this.empIdlabel.Text = "工号：";
            // 
            // emp_sfDataGrid
            // 
            this.emp_sfDataGrid.AccessibleName = "Table";
            this.emp_sfDataGrid.AllowDraggingColumns = true;
            this.emp_sfDataGrid.AllowResizingColumns = true;
            this.emp_sfDataGrid.AllowResizingHiddenColumns = true;
            this.emp_sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_sfDataGrid.Location = new System.Drawing.Point(27, 61);
            this.emp_sfDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.emp_sfDataGrid.Name = "emp_sfDataGrid";
            this.emp_sfDataGrid.SerializationController = null;
            this.emp_sfDataGrid.Size = new System.Drawing.Size(1010, 349);
            this.emp_sfDataGrid.TabIndex = 1;
            this.emp_sfDataGrid.Tag = "1233:368:17:54";
            this.emp_sfDataGrid.Text = "emp_sfDataGrid";
            // 
            // empId_textBoxExt
            // 
            this.empId_textBoxExt.BeforeTouchSize = new System.Drawing.Size(112, 21);
            this.empId_textBoxExt.Location = new System.Drawing.Point(68, 21);
            this.empId_textBoxExt.Margin = new System.Windows.Forms.Padding(2);
            this.empId_textBoxExt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.empId_textBoxExt.Name = "empId_textBoxExt";
            this.empId_textBoxExt.Size = new System.Drawing.Size(112, 21);
            this.empId_textBoxExt.TabIndex = 3;
            this.empId_textBoxExt.Tag = "137:25:134:14";
            // 
            // insert_sfButton
            // 
            this.insert_sfButton.AccessibleName = "Button";
            this.insert_sfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_sfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.insert_sfButton.Location = new System.Drawing.Point(793, 616);
            this.insert_sfButton.Margin = new System.Windows.Forms.Padding(2);
            this.insert_sfButton.Name = "insert_sfButton";
            this.insert_sfButton.Size = new System.Drawing.Size(50, 23);
            this.insert_sfButton.TabIndex = 9;
            this.insert_sfButton.Text = "插入";
            this.insert_sfButton.Click += new System.EventHandler(this.insert_sfButton_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.AccessibleName = "Button";
            this.reset_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.reset_btn.Location = new System.Drawing.Point(964, 616);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(50, 23);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Tag = "66:29:1125:9";
            this.reset_btn.Text = "重置";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.AccessibleName = "Button";
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.search_btn.Location = new System.Drawing.Point(864, 616);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(50, 23);
            this.search_btn.TabIndex = 6;
            this.search_btn.Tag = "66:29:1032:10";
            this.search_btn.Text = "搜索";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.page_label);
            this.panel1.Controls.Add(this.emp_sfDataPager);
            this.panel1.Controls.Add(this.page_sfComboBox);
            this.panel1.Controls.Add(this.delete_sfButton);
            this.panel1.Controls.Add(this.dept_label);
            this.panel1.Controls.Add(this.dept_textBoxExt);
            this.panel1.Controls.Add(this.update_sfButton);
            this.panel1.Controls.Add(this.empIdlabel);
            this.panel1.Controls.Add(this.emp_sfDataGrid);
            this.panel1.Controls.Add(this.empId_textBoxExt);
            this.panel1.Controls.Add(this.insert_sfButton);
            this.panel1.Controls.Add(this.reset_btn);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 696);
            this.panel1.TabIndex = 0;
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 696);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(562, 464);
            this.Name = "EmpForm";
            this.Tag = "1283:881:0:0";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.EmpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private System.Windows.Forms.Label page_label;
        private Syncfusion.WinForms.DataPager.SfDataPager emp_sfDataPager;
        private Syncfusion.WinForms.ListView.SfComboBox page_sfComboBox;
        private Syncfusion.WinForms.Controls.SfButton delete_sfButton;
        private System.Windows.Forms.Label dept_label;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt dept_textBoxExt;
        private Syncfusion.WinForms.Controls.SfButton update_sfButton;
        private System.Windows.Forms.Label empIdlabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid emp_sfDataGrid;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt empId_textBoxExt;
        private Syncfusion.WinForms.Controls.SfButton insert_sfButton;
        private Syncfusion.WinForms.Controls.SfButton reset_btn;
        private Syncfusion.WinForms.Controls.SfButton search_btn;
        private System.Windows.Forms.Panel panel1;
    }
}