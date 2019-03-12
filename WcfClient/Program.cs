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

            AppManager.InitApp();
            if (AppManager.Login())
            {
                Application.Run(new MainForm());
            }
        }
    }
}
