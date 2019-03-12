using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfInspector;

namespace WcfHost
{
    public class AppManager
    {
        public static void InitApp()
        {
            VersionContrl.serverVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
