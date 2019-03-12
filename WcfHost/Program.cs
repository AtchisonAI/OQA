using System;
using WcfInspector;

//此为wcf契约服务的宿主程序，server端
namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppManager.InitApp();
                ServiceManager.StartAllServices();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("WCF Host Started!");
            Console.WriteLine("Service version:" + VersionContrl.serverVersion);
            Console.Read();
            ServiceManager.closeAllService();
        }
    }
}
