using System;
using Utils;
using System.Data;

//此为wcf契约服务的宿主程序，server端
namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceManager.StartAllServices();
            }
            catch (Exception ex) {
                Console.WriteLine("Service Start failed!");
                return;
            }

            Console.WriteLine("WCF Host Started!");
            Console.Read();
            ServiceManager.closeAllService();
        }
    }
}
