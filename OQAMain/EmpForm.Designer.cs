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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.page_label);
            this.splitContainer1.Panel1.Controls.Add(this.emp_sfDataPager);
            this.splitContainer1.Panel1.Controls.Add(this.page_sfComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.delete_sfButton);
            this.splitContainer1.Panel1.Controls.Add(this.dept_label);
            this.splitContainer1.Panel1.Controls.Add(this.dept_textBoxExt);
            this.splitContainer1.Panel1.Controls.Add(this.update_sfButton);
            this.splitContainer1.Panel1.Controls.Add(this.empIdlabel);
            this.splitContainer1.Panel1.Controls.Add(this.emp_sfDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.empId_textBoxExt);
            this.splitContainer1.Panel1.Controls.Add(this.insert_sfButton);
            this.splitContainer1.Panel1.Controls.Add(this.reset_btn);
            this.splitContainer1.Panel1.Controls.Add(this.search_btn);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 686);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 13;
            // 
            // page_label
            // 
            this.page_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(537, 322);
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
            this.emp_sfDataPager.Location = new System.Drawing.Point(255, 313);
            this.emp_sfDataPager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.page_sfComboBox.Location = new System.Drawing.Point(602, 318);
            this.page_sfComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.delete_sfButton.Location = new System.Drawing.Point(810, 6);
            this.delete_sfButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_sfButton.Name = "delete_sfButton";
            this.delete_sfButton.Size = new System.Drawing.Size(50, 23);
            this.delete_sfButton.TabIndex = 9;
            this.delete_sfButton.Text = "删除";
            this.delete_sfButton.Click += new System.EventHandler(this.delete_sfButton_Click);
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(218, 10);
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
            this.dept_textBoxExt.Location = new System.Drawing.Point(261, 6);
            this.dept_textBoxExt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.update_sfButton.Location = new System.Drawing.Point(754, 6);
            this.update_sfButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_sfButton.Name = "update_sfButton";
            this.update_sfButton.Size = new System.Drawing.Size(50, 23);
            this.update_sfButton.TabIndex = 9;
            this.update_sfButton.Text = "更新";
            this.update_sfButton.Click += new System.EventHandler(this.update_sfButton_Click);
            // 
            // empIdlabel
            // 
            this.empIdlabel.AutoSize = true;
            this.empIdlabel.Location = new System.Drawing.Point(8, 10);
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
            this.emp_sfDataGrid.Location = new System.Drawing.Point(6, 31);
            this.emp_sfDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_sfDataGrid.Name = "emp_sfDataGrid";
            this.emp_sfDataGrid.SerializationController = null;
            this.emp_sfDataGrid.Size = new System.Drawing.Size(1026, 277);
            this.emp_sfDataGrid.TabIndex = 1;
            this.emp_sfDataGrid.Tag = "1233:368:17:54";
            this.emp_sfDataGrid.Text = "emp_sfDataGrid";
            // 
            // empId_textBoxExt
            // 
            this.empId_textBoxExt.BeforeTouchSize = new System.Drawing.Size(112, 21);
            this.empId_textBoxExt.Location = new System.Drawing.Point(50, 6);
            this.empId_textBoxExt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.insert_sfButton.Location = new System.Drawing.Point(698, 6);
            this.insert_sfButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.reset_btn.Location = new System.Drawing.Point(982, 6);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.search_btn.Location = new System.Drawing.Point(926, 6);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(50, 23);
            this.search_btn.TabIndex = 6;
            this.search_btn.Tag = "66:29:1032:10";
            this.search_btn.Text = "搜索";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 696);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(562, 464);
            this.Name = "EmpForm";
            this.Tag = "1283:881:0:0";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.EmpForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
    }
}