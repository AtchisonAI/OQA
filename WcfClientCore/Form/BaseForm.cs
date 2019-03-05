using log4net;
using Syncfusion.Windows.Forms;
using WcfClientCore.Utils.Authority;
using System.Windows.Forms;

namespace WcfClientCore.Form
{
    public partial class BaseForm : MetroForm
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
        }
    }
}