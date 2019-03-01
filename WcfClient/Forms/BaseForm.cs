using Syncfusion.Windows.Forms;
using WcfClient.Authority;

namespace WcfClient
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