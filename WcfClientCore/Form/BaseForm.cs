using log4net;
using Syncfusion.Windows.Forms;
using WcfClientCore.Utils.Authority;

namespace WcfClientCore.Form
{
    public partial class BaseForm : MetroForm
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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