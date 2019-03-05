using System.Windows.Forms;

namespace WcfClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbshortcut_panel = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbEmp_panel = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("员工信息");
            this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.shortcut_panel = new System.Windows.Forms.Panel();
            this.Emp_panel = new System.Windows.Forms.Panel();
            this.Emp_treeView = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.System_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Authority_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShortCut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectCodeSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oQA检验ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotInspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aOIInspectionInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcoInspectionInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mircoInspectionInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectSendPNDNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectLotResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oQA发货ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foupChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageLabelPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waferInspactionRecordPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOQAShipListPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rep_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Emp_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabbedGroupedMDIManager = new Syncfusion.Windows.Forms.Tools.TabbedGroupedMDIManager();
            this.statusBarAdv = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.System_statusBarAdvPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.Emp_statusBarAdvPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.Active_statusBarAdvPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.Date_statusBarAdvPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.Time_statusBarAdvPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).BeginInit();
            this.Emp_panel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).BeginInit();
            this.statusBarAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.System_statusBarAdvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_statusBarAdvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Active_statusBarAdvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_statusBarAdvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_statusBarAdvPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager
            // 
            this.dockingManager.AnimateAutoHiddenWindow = true;
            this.dockingManager.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this.dockingManager.DockBehavior = Syncfusion.Windows.Forms.Tools.DockBehavior.VS2010;
            this.dockingManager.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager.DockLayoutStream")));
            this.dockingManager.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey;
            this.dockingManager.HostControl = this;
            this.dockingManager.MenuStyle = Syncfusion.Windows.Forms.Tools.DockMenuStyle.VS2003;
            this.dockingManager.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager.ReduceFlickeringInRtl = false;
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager.SetDockLabel(this.shortcut_panel, "快捷菜单");
            this.dockingManager.SetEnableDocking(this.shortcut_panel, true);
            this.dockingManager.SetAutoHideOnLoad(this.shortcut_panel, true);
            this.dockingManager.SetDockAbility(this.shortcut_panel, "Horizontal");
            ccbshortcut_panel.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.shortcut_panel, ccbshortcut_panel);
            this.dockingManager.SetDockLabel(this.Emp_panel, "员工");
            this.dockingManager.SetEnableDocking(this.Emp_panel, true);
            this.dockingManager.SetAutoHideOnLoad(this.Emp_panel, true);
            ccbEmp_panel.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.Emp_panel, ccbEmp_panel);
            // 
            // shortcut_panel
            // 
            this.shortcut_panel.Location = new System.Drawing.Point(1, 30);
            this.shortcut_panel.Name = "shortcut_panel";
            this.shortcut_panel.Size = new System.Drawing.Size(131, 614);
            this.shortcut_panel.TabIndex = 2;
            this.shortcut_panel.Visible = false;
            // 
            // Emp_panel
            // 
            this.Emp_panel.Controls.Add(this.Emp_treeView);
            this.Emp_panel.Location = new System.Drawing.Point(1, 30);
            this.Emp_panel.Name = "Emp_panel";
            this.Emp_panel.Size = new System.Drawing.Size(131, 614);
            this.Emp_panel.TabIndex = 4;
            this.Emp_panel.Visible = false;
            // 
            // Emp_treeView
            // 
            this.Emp_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emp_treeView.Location = new System.Drawing.Point(0, 0);
            this.Emp_treeView.Name = "Emp_treeView";
            treeNode1.Name = "Emp_Node";
            treeNode1.Text = "员工信息";
            this.Emp_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.Emp_treeView.Size = new System.Drawing.Size(131, 614);
            this.Emp_treeView.TabIndex = 0;
            this.Emp_treeView.Click += new System.EventHandler(this.Emp_treeView_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.System_ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.oQA检验ToolStripMenuItem,
            this.oQA发货ToolStripMenuItem,
            this.Rep_ToolStripMenuItem,
            this.Emp_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1374, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // System_ToolStripMenuItem
            // 
            this.System_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Authority_ToolStripMenuItem,
            this.ShortCut_ToolStripMenuItem});
            this.System_ToolStripMenuItem.Name = "System_ToolStripMenuItem";
            this.System_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.System_ToolStripMenuItem.Text = "系统";
            // 
            // Authority_ToolStripMenuItem
            // 
            this.Authority_ToolStripMenuItem.Name = "Authority_ToolStripMenuItem";
            this.Authority_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Authority_ToolStripMenuItem.Text = "权限控制";
            this.Authority_ToolStripMenuItem.Click += new System.EventHandler(this.Authority_ToolStripMenuItem_Click);
            // 
            // ShortCut_ToolStripMenuItem
            // 
            this.ShortCut_ToolStripMenuItem.Name = "ShortCut_ToolStripMenuItem";
            this.ShortCut_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ShortCut_ToolStripMenuItem.Text = "快捷菜单";
            this.ShortCut_ToolStripMenuItem.Click += new System.EventHandler(this.ShortCut_ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defectCodeSetToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // defectCodeSetToolStripMenuItem
            // 
            this.defectCodeSetToolStripMenuItem.Name = "defectCodeSetToolStripMenuItem";
            this.defectCodeSetToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.defectCodeSetToolStripMenuItem.Text = "Defect Code Set";
            this.defectCodeSetToolStripMenuItem.Click += new System.EventHandler(this.defectCodeSetToolStripMenuItem_Click);
            // 
            // oQA检验ToolStripMenuItem
            // 
            this.oQA检验ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotInspectToolStripMenuItem,
            this.aOIInspectionInputToolStripMenuItem,
            this.marcoInspectionInputToolStripMenuItem,
            this.mircoInspectionInputToolStripMenuItem,
            this.defectSendPNDNToolStripMenuItem,
            this.defectLotResultToolStripMenuItem});
            this.oQA检验ToolStripMenuItem.Name = "oQA检验ToolStripMenuItem";
            this.oQA检验ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.oQA检验ToolStripMenuItem.Text = "OQA检验";
            // 
            // lotInspectToolStripMenuItem
            // 
            this.lotInspectToolStripMenuItem.Name = "lotInspectToolStripMenuItem";
            this.lotInspectToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.lotInspectToolStripMenuItem.Text = "Lot Inspect";
            this.lotInspectToolStripMenuItem.Click += new System.EventHandler(this.lotInspectToolStripMenuItem_Click);
            // 
            // aOIInspectionInputToolStripMenuItem
            // 
            this.aOIInspectionInputToolStripMenuItem.Name = "aOIInspectionInputToolStripMenuItem";
            this.aOIInspectionInputToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.aOIInspectionInputToolStripMenuItem.Text = "AOI Inspection Input";
            this.aOIInspectionInputToolStripMenuItem.Click += new System.EventHandler(this.aOIInspectionInputToolStripMenuItem_Click);
            // 
            // marcoInspectionInputToolStripMenuItem
            // 
            this.marcoInspectionInputToolStripMenuItem.Name = "marcoInspectionInputToolStripMenuItem";
            this.marcoInspectionInputToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.marcoInspectionInputToolStripMenuItem.Text = "Marco Inspection Input";
            this.marcoInspectionInputToolStripMenuItem.Click += new System.EventHandler(this.marcoInspectionInputToolStripMenuItem_Click);
            // 
            // mircoInspectionInputToolStripMenuItem
            // 
            this.mircoInspectionInputToolStripMenuItem.Name = "mircoInspectionInputToolStripMenuItem";
            this.mircoInspectionInputToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.mircoInspectionInputToolStripMenuItem.Text = "Mirco Inspection Input";
            this.mircoInspectionInputToolStripMenuItem.Click += new System.EventHandler(this.mircoInspectionInputToolStripMenuItem_Click);
            // 
            // defectSendPNDNToolStripMenuItem
            // 
            this.defectSendPNDNToolStripMenuItem.Name = "defectSendPNDNToolStripMenuItem";
            this.defectSendPNDNToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.defectSendPNDNToolStripMenuItem.Text = "Defect Send PNDN";
            this.defectSendPNDNToolStripMenuItem.Click += new System.EventHandler(this.defectSendPNDNToolStripMenuItem_Click);
            // 
            // defectLotResultToolStripMenuItem
            // 
            this.defectLotResultToolStripMenuItem.Name = "defectLotResultToolStripMenuItem";
            this.defectLotResultToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.defectLotResultToolStripMenuItem.Text = "Defect Lot Result";
            this.defectLotResultToolStripMenuItem.Click += new System.EventHandler(this.defectLotResultToolStripMenuItem_Click);
            // 
            // oQA发货ToolStripMenuItem
            // 
            this.oQA发货ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foupChangeToolStripMenuItem,
            this.lotPackageToolStripMenuItem,
            this.lotTransferToolStripMenuItem,
            this.packageLabelPrintToolStripMenuItem,
            this.waferInspactionRecordPrintToolStripMenuItem,
            this.iOQAShipListPrintToolStripMenuItem});
            this.oQA发货ToolStripMenuItem.Name = "oQA发货ToolStripMenuItem";
            this.oQA发货ToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.oQA发货ToolStripMenuItem.Text = "OQA发货";
            // 
            // foupChangeToolStripMenuItem
            // 
            this.foupChangeToolStripMenuItem.Name = "foupChangeToolStripMenuItem";
            this.foupChangeToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.foupChangeToolStripMenuItem.Text = "Foup Change";
            this.foupChangeToolStripMenuItem.Click += new System.EventHandler(this.foupChangeToolStripMenuItem_Click);
            // 
            // lotPackageToolStripMenuItem
            // 
            this.lotPackageToolStripMenuItem.Name = "lotPackageToolStripMenuItem";
            this.lotPackageToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.lotPackageToolStripMenuItem.Text = "Lot Package";
            this.lotPackageToolStripMenuItem.Click += new System.EventHandler(this.lotPackageToolStripMenuItem_Click);
            // 
            // lotTransferToolStripMenuItem
            // 
            this.lotTransferToolStripMenuItem.Name = "lotTransferToolStripMenuItem";
            this.lotTransferToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.lotTransferToolStripMenuItem.Text = "Lot Transfer";
            this.lotTransferToolStripMenuItem.Click += new System.EventHandler(this.lotTransferToolStripMenuItem_Click);
            // 
            // packageLabelPrintToolStripMenuItem
            // 
            this.packageLabelPrintToolStripMenuItem.Name = "packageLabelPrintToolStripMenuItem";
            this.packageLabelPrintToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.packageLabelPrintToolStripMenuItem.Text = "Package Label Print";
            this.packageLabelPrintToolStripMenuItem.Click += new System.EventHandler(this.packageLabelPrintToolStripMenuItem_Click);
            // 
            // waferInspactionRecordPrintToolStripMenuItem
            // 
            this.waferInspactionRecordPrintToolStripMenuItem.Name = "waferInspactionRecordPrintToolStripMenuItem";
            this.waferInspactionRecordPrintToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.waferInspactionRecordPrintToolStripMenuItem.Text = "Wafer Inspaction Record Print";
            this.waferInspactionRecordPrintToolStripMenuItem.Click += new System.EventHandler(this.waferInspactionRecordPrintToolStripMenuItem_Click);
            // 
            // iOQAShipListPrintToolStripMenuItem
            // 
            this.iOQAShipListPrintToolStripMenuItem.Name = "iOQAShipListPrintToolStripMenuItem";
            this.iOQAShipListPrintToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.iOQAShipListPrintToolStripMenuItem.Text = "IOQA Ship List Print";
            this.iOQAShipListPrintToolStripMenuItem.Click += new System.EventHandler(this.iOQAShipListPrintToolStripMenuItem_Click);
            // 
            // Rep_ToolStripMenuItem
            // 
            this.Rep_ToolStripMenuItem.Name = "Rep_ToolStripMenuItem";
            this.Rep_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.Rep_ToolStripMenuItem.Text = "报表";
            this.Rep_ToolStripMenuItem.Click += new System.EventHandler(this.Rep_ToolStripMenuItem_Click);
            // 
            // Emp_ToolStripMenuItem
            // 
            this.Emp_ToolStripMenuItem.Name = "Emp_ToolStripMenuItem";
            this.Emp_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.Emp_ToolStripMenuItem.Text = "员工";
            this.Emp_ToolStripMenuItem.Click += new System.EventHandler(this.Emp_ToolStripMenuItem_Click);
            // 
            // tabbedGroupedMDIManager
            // 
            this.tabbedGroupedMDIManager.AttachedTo = this;
            this.tabbedGroupedMDIManager.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedGroupedMDIManager.CloseButtonToolTip = "";
            this.tabbedGroupedMDIManager.DropDownButtonToolTip = "";
            this.tabbedGroupedMDIManager.DropDownButtonVisible = true;
            this.tabbedGroupedMDIManager.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedGroupedMDIManager.NeedUpdateHostedForm = false;
            this.tabbedGroupedMDIManager.ShowCloseButton = true;
            this.tabbedGroupedMDIManager.ThemesEnabled = true;
            // 
            // statusBarAdv
            // 
            this.statusBarAdv.BeforeTouchSize = new System.Drawing.Size(1374, 32);
            this.statusBarAdv.Controls.Add(this.System_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Emp_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Active_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Date_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Time_statusBarAdvPanel);
            this.statusBarAdv.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv.Location = new System.Drawing.Point(0, 702);
            this.statusBarAdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBarAdv.Name = "statusBarAdv";
            this.statusBarAdv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBarAdv.Size = new System.Drawing.Size(1374, 32);
            this.statusBarAdv.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv.TabIndex = 15;
            // 
            // System_statusBarAdvPanel
            // 
            this.System_statusBarAdvPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.System_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(167, 24);
            this.System_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.System_statusBarAdvPanel.Location = new System.Drawing.Point(0, 2);
            this.System_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.System_statusBarAdvPanel.Name = "System_statusBarAdvPanel";
            this.System_statusBarAdvPanel.Size = new System.Drawing.Size(167, 24);
            this.System_statusBarAdvPanel.TabIndex = 5;
            this.System_statusBarAdvPanel.Text = null;
            // 
            // Emp_statusBarAdvPanel
            // 
            this.Emp_statusBarAdvPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Emp_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(185, 24);
            this.Emp_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Emp_statusBarAdvPanel.Location = new System.Drawing.Point(169, 2);
            this.Emp_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Emp_statusBarAdvPanel.Name = "Emp_statusBarAdvPanel";
            this.Emp_statusBarAdvPanel.Size = new System.Drawing.Size(185, 24);
            this.Emp_statusBarAdvPanel.TabIndex = 4;
            this.Emp_statusBarAdvPanel.Text = null;
            // 
            // Active_statusBarAdvPanel
            // 
            this.Active_statusBarAdvPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Active_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(636, 24);
            this.Active_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Active_statusBarAdvPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.Active_statusBarAdvPanel.Location = new System.Drawing.Point(356, 2);
            this.Active_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Active_statusBarAdvPanel.Name = "Active_statusBarAdvPanel";
            this.Active_statusBarAdvPanel.PreferredSize = new System.Drawing.Size(432, 24);
            this.Active_statusBarAdvPanel.Size = new System.Drawing.Size(636, 24);
            this.Active_statusBarAdvPanel.TabIndex = 3;
            this.Active_statusBarAdvPanel.Text = null;
            // 
            // Date_statusBarAdvPanel
            // 
            this.Date_statusBarAdvPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date_statusBarAdvPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(177, 24);
            this.Date_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Date_statusBarAdvPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
            this.Date_statusBarAdvPanel.Location = new System.Drawing.Point(994, 2);
            this.Date_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Date_statusBarAdvPanel.Name = "Date_statusBarAdvPanel";
            this.Date_statusBarAdvPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
            this.Date_statusBarAdvPanel.Size = new System.Drawing.Size(177, 24);
            this.Date_statusBarAdvPanel.TabIndex = 2;
            this.Date_statusBarAdvPanel.Text = null;
            // 
            // Time_statusBarAdvPanel
            // 
            this.Time_statusBarAdvPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time_statusBarAdvPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right;
            this.Time_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(177, 24);
            this.Time_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Time_statusBarAdvPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
            this.Time_statusBarAdvPanel.Location = new System.Drawing.Point(1173, 2);
            this.Time_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Time_statusBarAdvPanel.Name = "Time_statusBarAdvPanel";
            this.Time_statusBarAdvPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongTime24Format;
            this.Time_statusBarAdvPanel.Size = new System.Drawing.Size(177, 24);
            this.Time_statusBarAdvPanel.TabIndex = 0;
            this.Time_statusBarAdvPanel.Text = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1374, 734);
            this.Controls.Add(this.statusBarAdv);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager)).EndInit();
            this.Emp_panel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv)).EndInit();
            this.statusBarAdv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.System_statusBarAdvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_statusBarAdvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Active_statusBarAdvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_statusBarAdvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_statusBarAdvPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager;
        private MenuStrip menuStrip;
        private ToolStripMenuItem System_ToolStripMenuItem;
        private ToolStripMenuItem Emp_ToolStripMenuItem;
        private ToolStripMenuItem Rep_ToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TabbedGroupedMDIManager tabbedGroupedMDIManager;
        private Panel shortcut_panel;
        private Panel Emp_panel;
        private TreeView Emp_treeView;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel System_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Emp_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Active_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Date_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Time_statusBarAdvPanel;
        private ToolStripMenuItem Authority_ToolStripMenuItem;
        private ToolStripMenuItem ShortCut_ToolStripMenuItem;
        private ToolStripMenuItem 配置ToolStripMenuItem;
        private ToolStripMenuItem defectCodeSetToolStripMenuItem;
        private ToolStripMenuItem oQA检验ToolStripMenuItem;
        private ToolStripMenuItem lotInspectToolStripMenuItem;
        private ToolStripMenuItem aOIInspectionInputToolStripMenuItem;
        private ToolStripMenuItem marcoInspectionInputToolStripMenuItem;
        private ToolStripMenuItem mircoInspectionInputToolStripMenuItem;
        private ToolStripMenuItem defectSendPNDNToolStripMenuItem;
        private ToolStripMenuItem defectLotResultToolStripMenuItem;
        private ToolStripMenuItem oQA发货ToolStripMenuItem;
        private ToolStripMenuItem foupChangeToolStripMenuItem;
        private ToolStripMenuItem lotPackageToolStripMenuItem;
        private ToolStripMenuItem lotTransferToolStripMenuItem;
        private ToolStripMenuItem packageLabelPrintToolStripMenuItem;
        private ToolStripMenuItem waferInspactionRecordPrintToolStripMenuItem;
        private ToolStripMenuItem iOQAShipListPrintToolStripMenuItem;
    }
}