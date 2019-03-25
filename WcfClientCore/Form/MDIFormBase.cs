using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfClientCore.Form
{
    public partial class MDIFormBase : BaseForm
    {
        public MDIFormBase()
        {
            InitializeComponent();
        }

        public virtual void AddMdiChild(ChildFormBase form)
        {
            throw new NotImplementedException();
        }
    }
}
