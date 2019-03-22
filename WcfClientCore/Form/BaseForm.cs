using log4net;
using Syncfusion.Windows.Forms;
using WcfClientCore.Utils.Authority;
using System.Windows.Forms;
using WCFModels.Frame;
using Syncfusion.Windows.Forms.Tools;

namespace WcfClientCore.Form
{
    public partial class BaseForm : MetroForm
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool b_Favorite { get; set; }
        public string toolStripName { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }

        public void ReFreshControl(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {
                // 如果是容器类控件，递归调用自己
                if (parContainer.Controls[index].HasChildren)
                {
                    ReFreshControl(parContainer.Controls[index]);
                }
                else
                {
                    switch (parContainer.Controls[index].GetType().Name)
                    {
                        case "TextBox":
                            parContainer.Controls[index].Text = "";
                            break;
                        case "RadioButton":
                            ((RadioButton)(parContainer.Controls[index])).Checked = false;
                            break;
                        case "CheckBox":
                            ((CheckBox)(parContainer.Controls[index])).Checked = false;
                            break;
                        case "ComboBox":
                            ((ComboBox)(parContainer.Controls[index])).Text = "";
                            break;
                    }
                }
            }
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            AuthorityControl.InitializeAuthority(this);
            CheckFavorite();
        }

        private void InitPara()
        {
            b_Favorite = false;
            toolStripName = string.Empty;
        }

        private void CheckFavorite()
        {
            foreach (UserFavorite q in AuthorityControl.GetUserFavorite())
            {
                if(Text.Equals(q.FormName))
                {
                    b_Favorite = true;
                    return;
                }
            }
            b_Favorite = false;
        }

        public void AddNewFormToMdi(BaseForm form)
        {
            if (null != this.Parent)
            {
                DockingWrapperForm Frm = (DockingWrapperForm)this.Parent;
                if (null != Frm.MdiParent)
                {
                    BaseForm mainFrm = (BaseForm)Frm.MdiParent;
                    mainFrm.AddMdiChild(form);
                }
                else
                {
                    //非MDI子窗体
                    form.Show();
                }
            }
        }

        public virtual void AddMdiChild(BaseForm form)
        {
            //非MDI子类不要实现该方法
        }
    }
}