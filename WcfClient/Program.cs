using System;
using System.Windows.Forms;

namespace WcfClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            LoginForm lgFrom = new LoginForm();
            lgFrom.StartPosition = FormStartPosition.CenterScreen;
            lgFrom.ShowDialog();

            if (lgFrom.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
