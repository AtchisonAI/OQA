namespace WcfClient
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries4 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo4 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo3 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries5 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo5 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            this.sfScrollFrame1 = new Syncfusion.WinForms.Controls.SfScrollFrame();
            this.empChartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.empPieChartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.empChartControl.Legend.Location = new System.Drawing.Point(329, 376);
            this.empChartControl.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.empChartControl.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.empChartControl.Legend.ShowBorder = true;
            this.empChartControl.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.empChartControl.Localize = null;
            this.empChartControl.Location = new System.Drawing.Point(3, 3);
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
            chartSeries4.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries4.Points.Add(1D, ((double)(145D)), ((double)(134D)), ((double)(35D)), ((double)(24D)));
            chartSeries4.Points.Add(2D, ((double)(388D)), ((double)(222D)), ((double)(62D)), ((double)(5D)));
            chartSeries4.Points.Add(3D, ((double)(142D)), ((double)(124D)), ((double)(72D)), ((double)(9D)));
            chartSeries4.Points.Add(4D, ((double)(335D)), ((double)(166D)), ((double)(86D)), ((double)(38D)));
            chartSeries4.Points.Add(5D, ((double)(358D)), ((double)(219D)), ((double)(95D)), ((double)(77D)));
            chartSeries4.Resolution = 0D;
            chartSeries4.StackingGroup = "Default Group";
            chartSeries4.Style.AltTagFormat = "";
            chartSeries4.Style.DrawTextShape = false;
            chartLineInfo3.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo3.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo3.DashPattern = null;
            chartLineInfo3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo3.Width = 1F;
            chartCustomShapeInfo4.Border = chartLineInfo3;
            chartCustomShapeInfo4.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo4.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries4.Style.TextShape = chartCustomShapeInfo4;
            this.empChartControl.Series.Add(chartSeries4);
            this.empChartControl.ShowToolTips = true;
            this.empChartControl.Size = new System.Drawing.Size(686, 414);
            this.empChartControl.Spacing = 10F;
            this.empChartControl.TabIndex = 1;
            this.empChartControl.Tag = "569:351:17:471";
            this.empChartControl.Text = "员工信息";
            // 
            // 
            // 
            this.empChartControl.Title.Font = new System.Drawing.Font("Arial", 18F);
            this.empChartControl.Title.Name = "Default";
            this.empChartControl.Titles.Add(this.empChartControl.Title);
            this.empChartControl.VisualTheme = "";
            this.empChartControl.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.empChartControl_ChartRegionClick);
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
            this.empPieChartControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(125)))), ((int)(((byte)(59)))));
            this.empPieChartControl.IsWindowLess = false;
            // 
            // 
            // 
            this.empPieChartControl.Legend.Location = new System.Drawing.Point(604, 81);
            this.empPieChartControl.Localize = null;
            this.empPieChartControl.Location = new System.Drawing.Point(695, 3);
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
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries1.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            chartSeries5.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries5.Name = "Default1";
            chartSeries5.Resolution = 0D;
            chartSeries5.StackingGroup = "Default Group";
            chartSeries5.Style.AltTagFormat = "";
            chartSeries5.Style.DrawTextShape = false;
            chartCustomShapeInfo5.Border = chartLineInfo1;
            chartCustomShapeInfo5.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo5.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries5.Style.TextShape = chartCustomShapeInfo5;
            chartSeries5.Text = "Default1";
            chartSeries5.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Pie;
            this.empPieChartControl.Series.Add(chartSeries1);
            this.empPieChartControl.Series.Add(chartSeries5);
            this.empPieChartControl.Size = new System.Drawing.Size(686, 414);
            this.empPieChartControl.TabIndex = 8;
            this.empPieChartControl.Tag = "589:351:657:471";
            this.empPieChartControl.Text = "员工信息";
            // 
            // 
            // 
            this.empPieChartControl.Title.Name = "Default";
            this.empPieChartControl.Titles.Add(this.empPieChartControl.Title);
            this.empPieChartControl.VisualTheme = "";
            this.empPieChartControl.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.empPieChartControl_ChartRegionClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 857);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 13;
            // 
            // page_label
            // 
            this.page_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_label.AutoSize = true;
            this.page_label.Location = new System.Drawing.Point(716, 402);
            this.page_label.Name = "page_label";
            this.page_label.Size = new System.Drawing.Size(79, 15);
            this.page_label.TabIndex = 10;
            this.page_label.Text = "PageSize:";
            // 
            // emp_sfDataPager
            // 
            this.emp_sfDataPager.AccessibleName = "DataPager";
            this.emp_sfDataPager.AllowOnDemandPaging = true;
            this.emp_sfDataPager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emp_sfDataPager.Enabled = false;
            this.emp_sfDataPager.Location = new System.Drawing.Point(340, 391);
            this.emp_sfDataPager.Name = "emp_sfDataPager";
            this.emp_sfDataPager.PageCount = 1;
            this.emp_sfDataPager.Size = new System.Drawing.Size(362, 35);
            this.emp_sfDataPager.TabIndex = 0;
            this.emp_sfDataPager.Tag = "474:37:352:428";
            this.emp_sfDataPager.Text = "emp_sfDataPager";
            this.emp_sfDataPager.PageIndexChanged += new System.EventHandler<Syncfusion.WinForms.DataPager.Events.PageIndexChangedEventArgs>(this.emp_sfDataPager_PageIndexChanged);
            // 
            // page_sfComboBox
            // 
            this.page_sfComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.page_sfComboBox.Location = new System.Drawing.Point(803, 398);
            this.page_sfComboBox.Name = "page_sfComboBox";
            this.page_sfComboBox.Size = new System.Drawing.Size(72, 25);
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
            this.delete_sfButton.Location = new System.Drawing.Point(1080, 7);
            this.delete_sfButton.Name = "delete_sfButton";
            this.delete_sfButton.Size = new System.Drawing.Size(66, 29);
            this.delete_sfButton.TabIndex = 9;
            this.delete_sfButton.Text = "删除";
            this.delete_sfButton.Click += new System.EventHandler(this.delete_sfButton_Click);
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(291, 12);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(52, 15);
            this.dept_label.TabIndex = 2;
            this.dept_label.Tag = "52:15:346:18";
            this.dept_label.Text = "部门：";
            // 
            // dept_textBoxExt
            // 
            this.dept_textBoxExt.BeforeTouchSize = new System.Drawing.Size(148, 25);
            this.dept_textBoxExt.Location = new System.Drawing.Point(348, 7);
            this.dept_textBoxExt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dept_textBoxExt.Name = "dept_textBoxExt";
            this.dept_textBoxExt.Size = new System.Drawing.Size(148, 25);
            this.dept_textBoxExt.TabIndex = 1;
            this.dept_textBoxExt.Tag = "137:25:401:14";
            // 
            // update_sfButton
            // 
            this.update_sfButton.AccessibleName = "Button";
            this.update_sfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_sfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.update_sfButton.Location = new System.Drawing.Point(1006, 7);
            this.update_sfButton.Name = "update_sfButton";
            this.update_sfButton.Size = new System.Drawing.Size(66, 29);
            this.update_sfButton.TabIndex = 9;
            this.update_sfButton.Text = "更新";
            this.update_sfButton.Click += new System.EventHandler(this.update_sfButton_Click);
            // 
            // empIdlabel
            // 
            this.empIdlabel.AutoSize = true;
            this.empIdlabel.Location = new System.Drawing.Point(11, 13);
            this.empIdlabel.Name = "empIdlabel";
            this.empIdlabel.Size = new System.Drawing.Size(52, 15);
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
            this.emp_sfDataGrid.Location = new System.Drawing.Point(8, 39);
            this.emp_sfDataGrid.Name = "emp_sfDataGrid";
            this.emp_sfDataGrid.SerializationController = null;
            this.emp_sfDataGrid.Size = new System.Drawing.Size(1367, 346);
            this.emp_sfDataGrid.TabIndex = 1;
            this.emp_sfDataGrid.Tag = "1233:368:17:54";
            this.emp_sfDataGrid.Text = "emp_sfDataGrid";
            // 
            // empId_textBoxExt
            // 
            this.empId_textBoxExt.BeforeTouchSize = new System.Drawing.Size(148, 25);
            this.empId_textBoxExt.Location = new System.Drawing.Point(66, 8);
            this.empId_textBoxExt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.empId_textBoxExt.Name = "empId_textBoxExt";
            this.empId_textBoxExt.Size = new System.Drawing.Size(148, 25);
            this.empId_textBoxExt.TabIndex = 0;
            this.empId_textBoxExt.Tag = "137:25:134:14";
            // 
            // insert_sfButton
            // 
            this.insert_sfButton.AccessibleName = "Button";
            this.insert_sfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_sfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.insert_sfButton.Location = new System.Drawing.Point(931, 7);
            this.insert_sfButton.Name = "insert_sfButton";
            this.insert_sfButton.Size = new System.Drawing.Size(66, 29);
            this.insert_sfButton.TabIndex = 9;
            this.insert_sfButton.Text = "插入";
            this.insert_sfButton.Click += new System.EventHandler(this.insert_sfButton_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.AccessibleName = "Button";
            this.reset_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.reset_btn.Location = new System.Drawing.Point(1309, 7);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(66, 29);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Tag = "66:29:1125:9";
            this.reset_btn.Text = "重置";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.AccessibleName = "Button";
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.search_btn.Location = new System.Drawing.Point(1235, 7);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(66, 29);
            this.search_btn.TabIndex = 2;
            this.search_btn.Tag = "66:29:1032:10";
            this.search_btn.Text = "搜索";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.empPieChartControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.empChartControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 420);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 870);
            this.Controls.Add(this.splitContainer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EmpForm";
            this.Tag = "1283:881:0:0";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.EmpForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page_sfComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dept_textBoxExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_sfDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empId_textBoxExt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfScrollFrame sfScrollFrame1;
        private Syncfusion.Windows.Forms.Chart.ChartControl empChartControl;
        private Syncfusion.Windows.Forms.Chart.ChartControl empPieChartControl;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}