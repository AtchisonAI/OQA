using OQA_Core;
using System;
using System.Windows.Forms;
using WcfClientCore.Form;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace OQAMain
{
    public partial class InsertEmpForm : ChildFormBase
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
            updateReq.operateType = OperateType.Insert;

            try
            {
                var res = OQASrv.Call.UpdateDemoInfo(updateReq);
                MessageBox.Show(res.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
            Close();         
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ModelListRsp<Emp> UpdateEmp(Emp empInfo, OperateType operate)
        {
            UpdateModelListReq<Emp> updateReq = new UpdateModelListReq<Emp>();
            updateReq.models.Add(empInfo);
            updateReq.operateType = operate;
            return OQASrv.Call.UpdateEmpInfo(updateReq);


        }
    }
}
