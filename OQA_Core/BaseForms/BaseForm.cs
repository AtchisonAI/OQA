using Syncfusion.Windows.Forms;
using WcfClientCore.Form;

namespace OQA_Core
{
    public partial class OQABaseForm : ChildFormBase
    {
        public OQABaseForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }


    }
}