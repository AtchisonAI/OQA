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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbSystem_panel = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbEmp_panel = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("员工信息");
            this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.System_panel = new System.Windows.Forms.Panel();
            this.Emp_panel = new System.Windows.Forms.Panel();
            this.Emp_treeView = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.System_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Emp_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rep_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dockingManager.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager.DockLayoutStream")));
            this.dockingManager.HostControl = this;
            this.dockingManager.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.dockingManager.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager.ReduceFlickeringInRtl = false;
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager.SetDockLabel(this.System_panel, "系统");
            this.dockingManager.SetEnableDocking(this.System_panel, true);
            this.dockingManager.SetAutoHideOnLoad(this.System_panel, true);
            ccbSystem_panel.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.System_panel, ccbSystem_panel);
            this.dockingManager.SetDockLabel(this.Emp_panel, "员工");
            this.dockingManager.SetEnableDocking(this.Emp_panel, true);
            this.dockingManager.SetAutoHideOnLoad(this.Emp_panel, true);
            ccbEmp_panel.MergeWith(this.dockingManager.CaptionButtons, false);
            this.dockingManager.SetCustomCaptionButtons(this.Emp_panel, ccbEmp_panel);
            // 
            // System_panel
            // 
            this.System_panel.Location = new System.Drawing.Point(1, 30);
            this.System_panel.Name = "System_panel";
            this.System_panel.Size = new System.Drawing.Size(135, 615);
            this.System_panel.TabIndex = 2;
            // 
            // Emp_panel
            // 
            this.Emp_panel.Controls.Add(this.Emp_treeView);
            this.Emp_panel.Location = new System.Drawing.Point(1, 30);
            this.Emp_panel.Name = "Emp_panel";
            this.Emp_panel.Size = new System.Drawing.Size(131, 615);
            this.Emp_panel.TabIndex = 4;
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
            this.Emp_treeView.Size = new System.Drawing.Size(131, 615);
            this.Emp_treeView.TabIndex = 0;
            this.Emp_treeView.Click += new System.EventHandler(this.Emp_treeView_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.System_ToolStripMenuItem,
            this.Emp_ToolStripMenuItem,
            this.Rep_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1375, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // System_ToolStripMenuItem
            // 
            this.System_ToolStripMenuItem.Name = "System_ToolStripMenuItem";
            this.System_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.System_ToolStripMenuItem.Text = "系统";
            this.System_ToolStripMenuItem.Click += new System.EventHandler(this.System_ToolStripMenuItem_Click);
            // 
            // Emp_ToolStripMenuItem
            // 
            this.Emp_ToolStripMenuItem.Name = "Emp_ToolStripMenuItem";
            this.Emp_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.Emp_ToolStripMenuItem.Text = "员工";
            this.Emp_ToolStripMenuItem.Click += new System.EventHandler(this.Emp_ToolStripMenuItem_Click);
            // 
            // Rep_ToolStripMenuItem
            // 
            this.Rep_ToolStripMenuItem.Name = "Rep_ToolStripMenuItem";
            this.Rep_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.Rep_ToolStripMenuItem.Text = "报表";
            this.Rep_ToolStripMenuItem.Click += new System.EventHandler(this.Rep_ToolStripMenuItem_Click);
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
            // 
            // statusBarAdv
            // 
            this.statusBarAdv.BeforeTouchSize = new System.Drawing.Size(1375, 32);
            this.statusBarAdv.Controls.Add(this.System_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Emp_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Active_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Date_statusBarAdvPanel);
            this.statusBarAdv.Controls.Add(this.Time_statusBarAdvPanel);
            this.statusBarAdv.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv.Location = new System.Drawing.Point(0, 703);
            this.statusBarAdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBarAdv.Name = "statusBarAdv";
            this.statusBarAdv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBarAdv.Size = new System.Drawing.Size(1375, 32);
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
            this.Active_statusBarAdvPanel.BeforeTouchSize = new System.Drawing.Size(643, 24);
            this.Active_statusBarAdvPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Active_statusBarAdvPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
            this.Active_statusBarAdvPanel.Location = new System.Drawing.Point(356, 2);
            this.Active_statusBarAdvPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Active_statusBarAdvPanel.Name = "Active_statusBarAdvPanel";
            this.Active_statusBarAdvPanel.PreferredSize = new System.Drawing.Size(432, 24);
            this.Active_statusBarAdvPanel.Size = new System.Drawing.Size(643, 24);
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
            this.Date_statusBarAdvPanel.Location = new System.Drawing.Point(1001, 2);
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
            this.Time_statusBarAdvPanel.Location = new System.Drawing.Point(1180, 2);
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
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.statusBarAdv);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
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
        private Panel System_panel;
        private Panel Emp_panel;
        private TreeView Emp_treeView;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel System_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Emp_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Active_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Date_statusBarAdvPanel;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel Time_statusBarAdvPanel;
    }
}