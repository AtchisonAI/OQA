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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Dept_Lable = new System.Windows.Forms.Label();
            this.UserId_Lable = new System.Windows.Forms.Label();
            this.dept_textBoxExt = new System.Windows.Forms.TextBox();
            this.empId_textBoxExt = new System.Windows.Forms.TextBox();
            this.pagesize_label = new System.Windows.Forms.Label();
            this.page_sfComboBox = new System.Windows.Forms.ComboBox();
            this.emp_sfDataPager = new Syncfusion.WinForms.DataPager.SfDataPager();
            this.reset_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.emp_sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.empChartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.empPieChartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.Dept_Lable);
            this.splitContainer.Panel1.Controls.Add(this.UserId_Lable);
            this.splitContainer.Panel1.Controls.Add(this.dept_textBoxExt);
            this.splitContainer.Panel1.Controls.Add(this.empId_textBoxExt);
            this.splitContainer.Panel1.Controls.Add(this.pagesize_label);
            this.splitContainer.Panel1.Controls.Add(this.page_sfComboBox);
            this.splitContainer.Panel1.Controls.Add(this.emp_sfDataPager);
            this.splitContainer.Panel1.Controls.Add(this.reset_button);
            this.splitContainer.Panel1.Controls.Add(this.search_button);
            this.splitContainer.Panel1.Controls.Add(this.delete_button);
            this.splitContainer.Panel1.Controls.Add(this.update_button);
            this.splitContainer.Panel1.Controls.Add(this.insert_button);
            this.splitContainer.Panel1.Controls.Add(this.emp_sfDataGrid);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(1047, 785);
            this.splitContainer.SplitterDistance = 452;
            this.splitContainer.TabIndex = 0;
            // 
            // Dept_Lable
            // 
            this.Dept_Lable.AutoSize = true;
            this.Dept_Lable.Location = new System.Drawing.Point(245, 24);
            this.Dept_Lable.Name = "Dept_Lable";
            this.Dept_Lable.Size = new System.Drawing.Size(34, 15);
            this.Dept_Lable.TabIndex = 7;
            this.Dept_Lable.Text = "部门:";
            // 
            // UserId_Lable
            // 
            this.UserId_Lable.AutoSize = true;
            this.UserId_Lable.Location = new System.Drawing.Point(19, 24);
            this.UserId_Lable.Name = "UserId_Lable";
            this.UserId_Lable.Size = new System.Drawing.Size(34, 15);
            this.UserId_Lable.TabIndex = 6;
            this.UserId_Lable.Text = "工号:";
            // 
            // dept_textBoxExt
            // 
            this.dept_textBoxExt.Location = new System.Drawing.Point(291, 20);
            this.dept_textBoxExt.Name = "dept_textBoxExt";
            this.dept_textBoxExt.Size = new System.Drawing.Size(137, 21);
            this.dept_textBoxExt.TabIndex = 1;
            // 
            // empId_textBoxExt
            // 
            this.empId_textBoxExt.Location = new System.Drawing.Point(67, 20);
            this.empId_textBoxExt.Name = "empId_textBoxExt";
            this.empId_textBoxExt.Size = new System.Drawing.Size(137, 21);
            this.empId_textBoxExt.TabIndex = 0;
            // 
            // pagesize_label
            // 
            this.pagesize_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pagesize_label.AutoSize = true;
            this.pagesize_label.Location = new System.Drawing.Point(682, 416);
            this.pagesize_label.Name = "pagesize_label";
            this.pagesize_label.Size = new System.Drawing.Size(63, 15);
            this.pagesize_label.TabIndex = 4;
            this.pagesize_label.Text = "PageSize:";
            // 
            // page_sfComboBox
            // 
            this.page_sfComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_sfComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.page_sfComboBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.page_sfComboBox.FormattingEnabled = true;
            this.page_sfComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.page_sfComboBox.Location = new System.Drawing.Point(754, 413);
            this.page_sfComboBox.Name = "page_sfComboBox";
            this.page_sfComboBox.Size = new System.Drawing.Size(47, 20);
            this.page_sfComboBox.TabIndex = 3;
            this.page_sfComboBox.Text = "20";
            this.page_sfComboBox.SelectedIndexChanged += new System.EventHandler(this.page_sfComboBox_SelectedIndexChanged);
            // 
            // emp_sfDataPager
            // 
            this.emp_sfDataPager.AccessibleName = "DataPager";
            this.emp_sfDataPager.AllowOnDemandPaging = true;
            this.emp_sfDataPager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emp_sfDataPager.Location = new System.Drawing.Point(319, 403);
            this.emp_sfDataPager.Name = "emp_sfDataPager";
            this.emp_sfDataPager.PageCount = 1;
            this.emp_sfDataPager.Size = new System.Drawing.Size(346, 40);
            this.emp_sfDataPager.TabIndex = 2;
            this.emp_sfDataPager.Text = "sfDataPager1";
            this.emp_sfDataPager.PageIndexChanged += new System.EventHandler<Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs>(this.sfDataPager_PageIndexChanged);
            // 
            // reset_button
            // 
            this.reset_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_button.Location = new System.Drawing.Point(975, 18);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(63, 29);
            this.reset_button.TabIndex = 6;
            this.reset_button.Text = "重置";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(882, 18);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(63, 29);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "搜索";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(724, 18);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(63, 29);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "删除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_button.Location = new System.Drawing.Point(626, 18);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(63, 29);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "更新";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_button.Location = new System.Drawing.Point(540, 18);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(63, 29);
            this.insert_button.TabIndex = 2;
            this.insert_button.Text = "新增";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // emp_sfDataGrid
            // 
            this.emp_sfDataGrid.AccessibleName = "Table";
            this.emp_sfDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_sfDataGrid.Location = new System.Drawing.Point(3, 53);
            this.emp_sfDataGrid.Name = "emp_sfDataGrid";
            this.emp_sfDataGrid.Size = new System.Drawing.Size(1038, 346);
            this.emp_sfDataGrid.TabIndex = 1;
            this.emp_sfDataGrid.Text = "sfDataGrid1";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.empChartControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.empPieChartControl, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1043, 325);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // empChartControl
            // 
            this.empChartControl.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.empChartControl.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.empChartControl.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.empChartControl.ChartArea.CursorReDraw = false;
            this.empChartControl.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(2, -5, 5, 2);
            this.empChartControl.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.empChartControl.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(43)))), ((int)(((byte)(144))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(78)))), ((int)(((byte)(101))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(95)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(110)))), ((int)(((byte)(125))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(123)))))};
            this.empChartControl.DataSourceName = "[none]";
            this.empChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empChartControl.IsWindowLess = false;
            // 
            // 
            // 
            this.empChartControl.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.empChartControl.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.empChartControl.Legend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.empChartControl.Legend.Location = new System.Drawing.Point(217, 283);
            this.empChartControl.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.empChartControl.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.empChartControl.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.empChartControl.Legend.ShowBorder = true;
            this.empChartControl.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.empChartControl.Localize = null;
            this.empChartControl.Location = new System.Drawing.Point(2, 2);
            this.empChartControl.Margin = new System.Windows.Forms.Padding(2);
            this.empChartControl.Name = "empChartControl";
            this.empChartControl.PrimaryXAxis.DrawGrid = false;
            this.empChartControl.PrimaryXAxis.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.empChartControl.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.empChartControl.PrimaryXAxis.Margin = true;
            this.empChartControl.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.empChartControl.PrimaryYAxis.DrawGrid = false;
            this.empChartControl.PrimaryYAxis.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.empChartControl.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.empChartControl.PrimaryYAxis.Margin = true;
            this.empChartControl.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.empChartControl.Size = new System.Drawing.Size(517, 321);
            this.empChartControl.TabIndex = 1;
            this.empChartControl.Text = "员工信息";
            // 
            // 
            // 
            this.empChartControl.Title.Name = "Default";
            this.empChartControl.Titles.Add(this.empChartControl.Title);
            this.empChartControl.VisualTheme = "";
            this.empChartControl.Click += new System.EventHandler(this.empChartControl_Click);
            // 
            // empPieChartControl
            // 
            this.empPieChartControl.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.White,
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(230))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(230))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))))});
            this.empPieChartControl.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.empPieChartControl.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.empPieChartControl.ChartArea.CursorReDraw = false;
            this.empPieChartControl.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.empPieChartControl.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(43)))), ((int)(((byte)(144))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(78)))), ((int)(((byte)(101))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(95)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(110)))), ((int)(((byte)(125))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(178)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(94)))), ((int)(((byte)(123)))))};
            this.empPieChartControl.DataSourceName = "[none]";
            this.empPieChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empPieChartControl.IsWindowLess = false;
            // 
            // 
            // 
            this.empPieChartControl.Legend.Location = new System.Drawing.Point(409, 75);
            this.empPieChartControl.Legend.Margin = new System.Windows.Forms.Padding(2);
            this.empPieChartControl.Localize = null;
            this.empPieChartControl.Location = new System.Drawing.Point(523, 2);
            this.empPieChartControl.Margin = new System.Windows.Forms.Padding(2);
            this.empPieChartControl.Name = "empPieChartControl";
            this.empPieChartControl.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.empPieChartControl.PrimaryXAxis.DrawGrid = false;
            this.empPieChartControl.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.empPieChartControl.PrimaryXAxis.Margin = true;
            this.empPieChartControl.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.empPieChartControl.PrimaryYAxis.DrawGrid = false;
            this.empPieChartControl.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.empPieChartControl.PrimaryYAxis.Margin = true;
            this.empPieChartControl.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.empPieChartControl.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.empPieChartControl.Size = new System.Drawing.Size(518, 321);
            this.empPieChartControl.TabIndex = 1;
            this.empPieChartControl.Text = "统计图";
            // 
            // 
            // 
            this.empPieChartControl.Title.Name = "Default";
            this.empPieChartControl.Titles.Add(this.empPieChartControl.Title);
            this.empPieChartControl.VisualTheme = "";
            this.empPieChartControl.Click += new System.EventHandler(this.empPieChartControl_Click);
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 785);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EmpForm";
            this.Text = "EmpForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label Dept_Lable;
        private System.Windows.Forms.Label UserId_Lable;
        private System.Windows.Forms.TextBox dept_textBoxExt;
        private System.Windows.Forms.TextBox empId_textBoxExt;
        private System.Windows.Forms.Label pagesize_label;
        private System.Windows.Forms.ComboBox page_sfComboBox;
        private Syncfusion.WinForms.DataPager.SfDataPager emp_sfDataPager;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button insert_button;
        private Syncfusion.WinForms.DataGrid.SfDataGrid emp_sfDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Syncfusion.Windows.Forms.Chart.ChartControl empChartControl;
        private Syncfusion.Windows.Forms.Chart.ChartControl empPieChartControl;
    }
}