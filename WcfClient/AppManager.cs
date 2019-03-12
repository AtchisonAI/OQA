using System.Windows.Forms;
using WcfInspector;

namespace WcfClient
{
    public class AppManager
    {
        public static void InitApp()
        {
            VersionContrl.clientVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
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
