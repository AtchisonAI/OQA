using OQAMain;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System;
using System.Reflection;
using System.Windows.Forms;
using WcfClient.Forms;
using WcfClientCore.Form;
using WcfClientCore.Utils.Authority;
using WcfClientCore.WcfSrv;
using WcfInspector;
using WCFModels.Frame;
using WCFModels.Message;

namespace WcfClient
{
    public partial class MainForm : BaseForm
    {
        private string mainFrameFullName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName.Replace('.',':') + ':';

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //隐藏子窗体图标,隐藏最小化按钮,隐藏还原按钮,隐藏最关闭按钮
            if (e.Item.Text.Length == 0 || e.Item.Text == "最小化(&N)" || e.Item.Text == "还原(&R)" /*|| e.Item.Text == "关闭(&C)"*/)
            {
                e.Item.Visible = false;
            }
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SetSytemStatusBar(AuthorityControl.GetUserProfile().systemPrefix.Trim(':'));
            SetUserStatusBar(AuthorityControl.GetUserProfile().userId);
            SetActiveStatusBar(Text);
            SetVersionStatusBar(VersionContrl.clientVersion);
            AddFavoriteBarItem();
            LoadFavoriteTreeView();
        }

        private void Emp_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            EmpForm frm = On_MenuItemClickImpl<EmpForm>(ctr.Name);
        }

        private void Rep_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            ReportForm frm = On_MenuItemClickImpl<ReportForm>(ctr.Name);
        }

        private void Authority_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            ControlAuthorityForm frm = On_MenuItemClickImpl<ControlAuthorityForm>(ctr.Name);
        }

        private void ShortCut_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            dockingManager.SetDockVisibility(shortcut_panel, true);
            dockingManager.ActivateControl(shortcut_panel);
        }

        private void defectCodeSetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmDefectCodeSet frm = On_MenuItemClickImpl<FrmDefectCodeSet>(ctr.Name);
        }

        private void lotInspectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmLotInspect frm = On_MenuItemClickImpl<FrmLotInspect>(ctr.Name);
        }

        private void aOIInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmAOIInput frm = On_MenuItemClickImpl<FrmAOIInput>(ctr.Name);
        }

        private void marcoInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmMarcoInput frm = On_MenuItemClickImpl<FrmMarcoInput>(ctr.Name);
        }

        private void defectSendPNDNToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmDefectSend frm = On_MenuItemClickImpl<FrmDefectSend>(ctr.Name);
        }

        private void defectLotResultToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmDefectLotResult frm = On_MenuItemClickImpl<FrmDefectLotResult>(ctr.Name);
        }

        private void foupChangeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmFoupChange frm = On_MenuItemClickImpl<FrmFoupChange>(ctr.Name);
        }

        private void lotPackageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmLotPackage frm = On_MenuItemClickImpl<FrmLotPackage>(ctr.Name);
        }

        private void lotTransferToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmLotTransfer frm = On_MenuItemClickImpl<FrmLotTransfer>(ctr.Name);
        }

        private void packageLabelPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmPackageLabelPrint frm = On_MenuItemClickImpl<FrmPackageLabelPrint>(ctr.Name);
        }

        private void waferInspactionRecordPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmWaferInspectRecordPrint frm = On_MenuItemClickImpl<FrmWaferInspectRecordPrint>(ctr.Name);
        }

        private void iOQAShipListPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmOQAShipListPrint frm = On_MenuItemClickImpl<FrmOQAShipListPrint>(ctr.Name);
        }

        private void mircoInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem ctr = (ToolStripMenuItem)sender;
            FrmMircoInput frm = On_MenuItemClickImpl<FrmMircoInput>(ctr.Name);
        }

        private T On_MenuItemClickImpl<T>(string toolBarName) where T : BaseForm, new()
        {
            T frm = ActiveTabHost<T>();
            if(null == frm)
            {
                frm = GenerateNewForm<T>(toolBarName);
            }
            return frm;
        }

        private T ActiveTabHost<T>() where T : BaseForm, new()
        {
            //这里默认一种类型的Form只能由一个toolstrip弹出
            Form[] childs = tabbedGroupedMDIManager.MdiChildren;
            foreach (DockingWrapperForm q in childs)
            {
                Form childFrm = (Form)q.ctrlChildRef;
                if (childFrm is T)
                {
                    tabbedGroupedMDIManager.UpdateActiveTabHost(q);
                    SetActiveStatusBar(childFrm.Text);
                    return (T)childFrm;
                }
            }
            return null;
        }

        private T GenerateNewForm<T>(string stripName) where T : BaseForm, new()
        {
            T Frm = new T();
            dockingManager.SetEnableDocking(Frm, true);
            dockingManager.SetAsMDIChild(Frm, true);
            dockingManager.SetDockLabel(Frm, Frm.Text);
            Frm.FormClosed += new FormClosedEventHandler(this.ChildFormClosed);

            //新Form绑定其对应的toolstripItemID 为了与权限控制保持一致，这里需要接上mainframe的命名空间
            Frm.toolStripName = mainFrameFullName + stripName;
            SetActiveStatusBar(Frm.Text);

            return Frm;
        }

        //FORM的Text可能相同，但是里面包含的菜单弹出按钮ID是唯一的
        private BaseForm GetFormByToolStripNameFromMDI(string toolStripId)
        {
            Form[] childs = tabbedGroupedMDIManager.MdiChildren;
            foreach (DockingWrapperForm q in childs)
            {
                BaseForm childFrm = (BaseForm)q.ctrlChildRef;
                if (childFrm.toolStripName.Equals(toolStripId))
                {
                    return childFrm;
                }
            }
            return null;
        }

        private void ChildFormClosed(object sender, System.EventArgs e)
        {
            BaseForm form = sender as BaseForm;
            dockingManager.SetAsMDIChild(form, false);
            dockingManager.SetEnableDocking(form, false);
        }

        private void SetActiveStatusBar(string text)
        {
            Active_statusBarAdvPanel.Text = "Active From:" + text;
        }
        private void SetUserStatusBar(string UserIdText)
        {
            Emp_statusBarAdvPanel.Text = "User:" + UserIdText;
        }
        private void SetSytemStatusBar(string systemPrefixText)
        {
            System_statusBarAdvPanel.Text = "System:" + systemPrefixText;
        }

        private void SetVersionStatusBar(string version)
        {
            Version_statusBarAdvPanel.Text = "Version:" +version;
        }

        private void Logout_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LoginForm lgFrom = new LoginForm();
            lgFrom.StartPosition = FormStartPosition.CenterScreen;
            lgFrom.ShowDialog();

            if (lgFrom.DialogResult == DialogResult.OK)
            {
                AuthorityControl.InitializeAuthority(this);
                LoadFavoriteTreeView();
            } 
        }

        private void FavoriteBarItem_Click(object sender, System.EventArgs e)
        {
            BarItem Item = (BarItem)sender;
            BaseForm activeFrm = GetMdiActiveForm();
            if (null == activeFrm)
            {
                log.Error("无法获取ActiveFrm");
                return;
            }
            

            if (Item.Checked)
            {
                RemoveFavoriteForm(activeFrm);
                Item.Checked = false;
            }
            else
            {
                AddFavoriteForm(activeFrm);
                Item.Checked = true;
            }
        }

        private void AddFavoriteBarItem()
        {
            ParentBarItem contextMenuItem = new ParentBarItem();
            BarItem newDocItem = new BarItem("Add To Favorite",new EventHandler(this.FavoriteBarItem_Click));
            //newDocItem.ImageIndex = 5;
            newDocItem.MergeOrder = 30;
            newDocItem.ID = "Add To Favorite";
            contextMenuItem.Items.Add(newDocItem);
            contextMenuItem.BeginGroupAt(newDocItem);
            tabbedGroupedMDIManager.ContextMenuItem.MergeItems(contextMenuItem);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            BaseForm activeFrm = GetMdiActiveForm(); 
            SetActiveStatusBar(activeFrm.Text);
            SetBarItemChecked("Add To Favorite", activeFrm.b_Favorite);
        }

        private void SetBarItemChecked(string barId,bool bCheck)
        {
            BarItem item = tabbedGroupedMDIManager.ContextMenuItem.Items.FindItem(barId);
            if (null != item)
            {
                item.Checked = bCheck;
            }
        }

        private BaseForm GetMdiActiveForm()
        {
            BaseForm mainFrame = (BaseForm)tabbedGroupedMDIManager.AttachedTo;
            System.Diagnostics.Debug.Assert(null != mainFrame);
            if(null != mainFrame.ActiveControl)
            {
                DockingWrapperForm activeDockedFrm = (DockingWrapperForm)mainFrame.ActiveControl;
                if(null != activeDockedFrm.ActiveControl)
                    return (BaseForm)activeDockedFrm.ActiveControl;
            }
            return null;
        }

        private BaseForm GetActiveMDICtrlRef()
        {
            BaseForm mainFrame = (BaseForm)tabbedGroupedMDIManager.AttachedTo;
            System.Diagnostics.Debug.Assert(null != mainFrame);
            if(null != mainFrame.ActiveMdiChild)
            {
                DockingWrapperForm activeMdiChild = (DockingWrapperForm)mainFrame.ActiveMdiChild;
                if(null != activeMdiChild.ctrlChildRef)
                {
                    return (BaseForm)activeMdiChild.ctrlChildRef;
                }
            }
            return null;
        }

        private void LoadFavoriteTreeView()
        {
            shutcut_TreeView.Nodes.Clear();
            //从权限库加载
            foreach(UserFavorite q in AuthorityControl.GetUserFavorite())
            {
                TreeNode tNode = new TreeNode();
                tNode.Text = q.FormName;
                tNode.Name = q.ControlId;
                shutcut_TreeView.Nodes.Add(tNode);
            }
        }

        private void RemoveNodeFromTree(string Text)
        {
            foreach(TreeNode node in shutcut_TreeView.Nodes)
            {
                if (node.Name.Equals(Text))
                {
                    shutcut_TreeView.Nodes.Remove(node);
                    break;
                }
            }
        }

        private void AddNodeToTree(string Text,string contrlId)
        {
            TreeNode tNode = new TreeNode();
            tNode.Text = Text;
            tNode.Name = contrlId;
            shutcut_TreeView.Nodes.Add(tNode);
        }

        private void AddFavoriteForm(BaseForm Frm)
        {
            UserFavorite model = new UserFavorite();
            model.ControlId = Frm.toolStripName;
            model.FormName = Frm.Text;

            WcfSrv.UpdateUserFavorite(model, OperateType.Insert);
            AuthorityControl.AddUserFavorite(model);
            AddNodeToTree(model.FormName, model.ControlId);
            Frm.b_Favorite = true;
        }

        private void RemoveFavoriteForm(BaseForm Frm)
        {
            UserFavorite model = new UserFavorite();
            model.ControlId = Frm.toolStripName;
            model.FormName = Frm.Text;

            WcfSrv.UpdateUserFavorite(model, OperateType.Delete);
            AuthorityControl.RemoveUserFavorite(model);
            RemoveNodeFromTree(model.ControlId);
            Frm.b_Favorite = false;
        }

        private void shutcut_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    TreeNode currentNode = e.Node;
                    ContextMenuStrip cms = new ContextMenuStrip();

                    if (currentNode != null)
                    {
                        ToolStripMenuItem deleteToolStrip = new ToolStripMenuItem("移除");
                        deleteToolStrip.Click += new EventHandler(RemoveShutcutTreeNode_Click);
                        cms.Items.Add(deleteToolStrip);
                        cms.Show(this.shutcut_TreeView, e.X, e.Y);

                        this.shutcut_TreeView.SelectedNode = currentNode;
                    }
                    break;
                case MouseButtons.Left:
                    string name = e.Node.Name;
                    name = name.Substring(name.LastIndexOf(':') + 1);
                    bool b_find = false;
                    ToolStripMenuItem item = GetItemByName<ToolStripMenuItem>(this, name, out b_find);

                    if (b_find && null != item)
                    {
                        item.PerformClick();
                    }
                    break;
            }
        }

        private void RemoveShutcutTreeNode_Click (object sender, EventArgs e)
        {
            TreeNode treenode = this.shutcut_TreeView.SelectedNode;
            if(null != treenode)
            {
                shutcut_TreeView.Nodes.Remove(treenode);
                BaseForm Frm = GetFormByToolStripNameFromMDI(treenode.Name);
                if (null == Frm)
                {
                    Frm = new BaseForm();
                    Frm.toolStripName = treenode.Name;
                    Frm.Text = treenode.Text;
                } else if (null != GetActiveMDICtrlRef()&& Frm.Text.Equals(GetActiveMDICtrlRef().Text))
                {
                    //移除的窗体是activeMDIChild（当前页签下的form），但不是activecontrol（鼠标点击之后才会active）
                    SetBarItemChecked("Add To Favorite",false);
                }
                RemoveFavoriteForm(Frm);
            }
        }

        private T GetItemByName<T>(object obj,string paraName, out bool b_find)
        {
            b_find = false;
            FieldInfo[] fieldInfo = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            
            foreach (FieldInfo fi in fieldInfo )
            {
                if(fi.FieldType.Name.Equals(typeof(T).Name) && fi.Name.Equals(paraName))
                {
                    T Item = (T)fi.GetValue(obj);
                    b_find = true;

                    return Item;
                }
            }
            return default(T);
        }

        private void SaveTableMdiLayout()
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, "Layout");
            tabbedGroupedMDIManager.SaveTabGroupStates(serializer);
            serializer.PersistNow();
        }

        private void LoadTableMdiLayout()
        {
            AppStateSerializer serializer = new AppStateSerializer(SerializeMode.XMLFile, "Layout");
            tabbedGroupedMDIManager.LoadTabGroupStates(serializer);
        }
    }
}