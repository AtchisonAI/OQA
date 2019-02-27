using System;
using System.Windows.Forms;
using WCFModels.Message;

namespace WcfClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTbx.Text.Trim();
            string passwd = passwdTbx.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("账户密码不能为空!");
            }
            else
            {
                if (WcfServiceHelper.Login(new UserProfile(userName, passwd, "OQA:")))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("登陆失败！账户密码错误!");
                }
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
