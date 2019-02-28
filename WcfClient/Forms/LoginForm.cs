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

        private void Login()
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

        private void logInBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void userNameTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            if (e.KeyChar == (char)13)
            {
                passwdTbx.Focus();
            }
        }

        private void passwdTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            if (e.KeyChar == (char)13)
            {
                Login();
            }
        }
    }
}
