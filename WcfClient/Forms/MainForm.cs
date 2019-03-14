using OQAMain;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;
using WcfClient.Forms;
using WcfClientCore.Form;
using WcfClientCore.Utils.Authority;
using WcfInspector;

namespace WcfClient
{
    public partial class MainForm : BaseForm
    {
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
        }

        private void Emp_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            EmpForm frm = On_MenuItemClickImpl<EmpForm>();
        }

        private void Rep_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ReportForm frm = On_MenuItemClickImpl<ReportForm>();
        }

        private void Emp_treeView_Click(object sender, System.EventArgs e)
        {
            EmpForm frm = On_MenuItemClickImpl<EmpForm>();
        }

        private void Authority_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ControlAuthorityForm frm = On_MenuItemClickImpl<ControlAuthorityForm>();
        }

        private void ShortCut_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            dockingManager.SetDockVisibility(shortcut_panel, true);
            dockingManager.ActivateControl(shortcut_panel);
        }

        private void defectCodeSetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmDefectCodeSet frm = On_MenuItemClickImpl<FrmDefectCodeSet>();
        }

        private void lotInspectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmLotInspect frm = On_MenuItemClickImpl<FrmLotInspect>();
        }

        private void aOIInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmAOIInput frm = On_MenuItemClickImpl<FrmAOIInput>();
        }

        private void marcoInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmMarcoInput frm = On_MenuItemClickImpl<FrmMarcoInput>();
        }

        private void defectSendPNDNToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmDefectSend frm = On_MenuItemClickImpl<FrmDefectSend>();
        }

        private void defectLotResultToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmDefectLotResult frm = On_MenuItemClickImpl<FrmDefectLotResult>();
        }

        private void foupChangeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmFoupChange frm = On_MenuItemClickImpl<FrmFoupChange>();
        }

        private void lotPackageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmLotPackage frm = On_MenuItemClickImpl<FrmLotPackage>();
        }

        private void lotTransferToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmLotTransfer frm = On_MenuItemClickImpl<FrmLotTransfer>();
        }

        private void packageLabelPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmPackageLabelPrint frm = On_MenuItemClickImpl<FrmPackageLabelPrint>();
        }

        private void waferInspactionRecordPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmWaferInspectRecordPrint frm = On_MenuItemClickImpl<FrmWaferInspectRecordPrint>();
        }

        private void iOQAShipListPrintToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmOQAShipListPrint frm = On_MenuItemClickImpl<FrmOQAShipListPrint>();
        }

        private void mircoInspectionInputToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmMircoInput frm = On_MenuItemClickImpl<FrmMircoInput>();
        }

        private T On_MenuItemClickImpl<T>() where T : BaseForm, new()
        {
            T frm = ActiveTabHost<T>();
            if(null == frm)
            {
                frm = GenerateNewForm<T>();
            }
            return frm;
        }

        private T ActiveTabHost<T>() where T : BaseForm, new()
        {
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

        private T GenerateNewForm<T>() where T : BaseForm, new()
        {
            T Frm = new T();
            dockingManager.SetEnableDocking(Frm, true);
            dockingManager.SetAsMDIChild(Frm, true);
            dockingManager.SetDockLabel(Frm, Frm.Text);
            Frm.FormClosed += new FormClosedEventHandler(this.ChildFormClosed);
            //Frm.Show();
            SetActiveStatusBar(Frm.Text);
            
            return Frm;
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
            } 
        }
    }
}
