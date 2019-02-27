using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFModels.MESDB.FWTST1;
using Models.Message;
using Utils;
using WcfClient.WcfService;
using Syncfusion.WinForms.DataGrid;
using WCFModels.Message;

namespace WcfClient
{
    public partial class InsertEmpForm : Form
    {
        public InsertEmpForm()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp()
            {
                //Id = id_tbx.Text.Trim(),
                //DeptCode = deptname_tbx.Text.Trim(),
                //DeptName = deptname_tbx.Text.Trim(),
                //EmployeeName = name_tbx.Text.Trim(),
                //EEmployeeName = ename_tbx.Text.Trim(),
                //Email = email_tbx.Text.Trim()

                Id = "E100216",
                DeptCode = "CIM",
                DeptName = "CIM",
                EmployeeName = "CODER",
                EEmployeeName = "CODER",
                Email = "fdsfds"
            };

            RmsUser user = new RmsUser()
            {
                //Userid = UserId_textBox.Text.Trim(),
                //Password = Passwd_textBox.Text.Trim(),
                //Username = Username_textBox.Text.Trim(),
                //Dept = RDept_textBox.Text.Trim()

                Userid = "E100216",
                Password = "123456",
                Username = "Coder",
                Dept = "CIM"
            };

            DemoView dv = new DemoView();
            dv.empList.Add(emp);
            dv.rmsList.Add(user);

            //SfDataGrid grid = (SfDataGrid)Parent.Controls.Find("emp_sfDataGrid", false)[0];
            //grid.DataSource = UpdateEmp(emp, OpreateType.Insert).models;

            //       UpdateEmp(emp, OpreateType.Insert)
            UpdateModelReq<DemoView> updateReq = new UpdateModelReq<DemoView>();
            updateReq.model = dv;
            updateReq.opreateType = OpreateType.Insert;

            WcfServiceHelper.WcfClient().UpdateDemoInfo(updateReq);

            Close();
            
            MessageBox.Show("添加成功");
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ModelListRsp<Emp> UpdateEmp(Emp empInfo, OpreateType operate)
        {
            UpdateModelListReq<Emp> updateReq = new UpdateModelListReq<Emp>();
            updateReq.models.Add(empInfo);
            updateReq.opreateType = operate;

            return WcfServiceHelper.WcfClient().UpdateEmpInfo(updateReq);
        }
    }
}
