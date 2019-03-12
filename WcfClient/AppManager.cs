using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;
using WcfInspector;

namespace WcfClient
{
    public class AppManager
    {
        public static void InitApp()
        {
            try
            {
                //用onceclick安装后获取的发布版本
                VersionContrl.serverVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                //调试状态下获取的是程序集版本
                VersionContrl.serverVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static bool Login()
        {
            LoginForm lgFrom = new LoginForm();
            lgFrom.StartPosition = FormStartPosition.CenterScreen;
            lgFrom.ShowDialog();

            return lgFrom.DialogResult == DialogResult.OK ? true : false;
        }
    }
}
