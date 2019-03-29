using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
using WCFModels.Frame;

namespace WcfClientCore.Form
{
    public partial class ChildFormBase : BaseForm 
    {
        public bool b_Favorite { get; set; }
        public string toolStripName { get; set; }

        public ChildFormBase()
        {
            InitializeComponent();
        }

        private void ChildFormBase_Load(object sender, EventArgs e)
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
                if (!string.IsNullOrEmpty(toolStripName) && toolStripName.Equals(q.ControlId))
                {
                    b_Favorite = true;
                    return;
                }
            }
            b_Favorite = false;
        }

        public void AddNewFormToMdi(ChildFormBase form, bool b_single = true)
        {
            if (null != this.Parent)
            {
                DockingWrapperForm Frm = (DockingWrapperForm)this.Parent;
                if (null != Frm.MdiParent)
                {
                    MDIFormBase mainFrm = (MDIFormBase)Frm.MdiParent;
                    mainFrm.AddMdiChild(form,b_single);
                }
                else
                {
                    //非MDI子窗体
                    form.Show();
                }
            }
        }
    }
}
