using Models.Message;
using Syncfusion.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;
using Utils.Authority;
using WcfClient.WcfService;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

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