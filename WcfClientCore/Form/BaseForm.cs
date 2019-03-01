using Syncfusion.Windows.Forms;
using WcfClientCore.Utils.Authority;

namespace WcfClientCore.Form
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            AuthorityControl.InitializeAuthority(this);
        }
    }
}