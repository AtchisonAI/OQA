using System.Windows.Forms;
using WcfClient.Authority;
using WcfClient.Forms;

namespace WcfClient
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            activeForm = null;
            InitializeComponent();
        }

        private Form activeForm;

        private void menuStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //隐藏子窗体图标,隐藏最小化按钮,隐藏还原按钮,隐藏最关闭按钮
            if (e.Item.Text.Length == 0 || e.Item.Text == "最小化(&N)" || e.Item.Text == "还原(&R)" /*|| e.Item.Text == "关闭(&C)"*/)
            {
                e.Item.Visible = false;
            }
        }

        private bool CheckIsActiveForm<T>()
        {
            if (null != activeForm)
            {
                if (activeForm.GetType() == typeof(T))
                {
                    return true;
                }
                else
                {
                    activeForm.Close();
                }
            }
            return false;
        }

        private void System_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        EmpForm empFrm;
        private void Emp_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (empFrm !=null && empFrm.IsDisposed == false)
            {
                empFrm.Activate();
            }
            else
            {
                empFrm = new EmpForm();
                dockingManager.SetEnableDocking(empFrm, true);
                dockingManager.SetAsMDIChild(empFrm, true);
                empFrm.Show();
            }

            SetActiveStatusBar(empFrm.Text);
        }

        private void Rep_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ReportForm repFrm = new ReportForm();
            dockingManager.SetEnableDocking(repFrm, true);
            dockingManager.SetAsMDIChild(repFrm, true);
            repFrm.Show();

            SetActiveStatusBar(repFrm.Text);
        }

        private void Emp_treeView_Click(object sender, System.EventArgs e)
        {
            EmpForm empFrm = new EmpForm();
            dockingManager.SetEnableDocking(empFrm, true);
            dockingManager.SetAsMDIChild(empFrm, true);
            empFrm.Show();

            SetActiveStatusBar(empFrm.Text);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            SetSytemStatusBar(AuthorityControl.GetUserProfile().systemPrefix.Trim(':'));
            SetUserStatusBar(AuthorityControl.GetUserProfile().userId);
            SetActiveStatusBar(Text);
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

        private void Authority_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ControlAuthorityForm contrlAuForm = new ControlAuthorityForm();
            dockingManager.SetEnableDocking(contrlAuForm, true);
            dockingManager.SetAsMDIChild(contrlAuForm, true);
            contrlAuForm.Show();

            SetActiveStatusBar(contrlAuForm.Text);
        }

        private void ShortCut_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
