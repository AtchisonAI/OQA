using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Reflection;
using System.Configuration;
using WcfService;
using WcfInspector;

namespace WcfHost
{
    public class ServiceManager
    {
        static List<ServiceHost> hosts = new List<ServiceHost>();

        private static void OpenHost(Type t)
        {
            ServiceHost host = new ServiceHost(t);

            //foreach (var endpont in host.Description.Endpoints)
            //{
            //    endpont.Behaviors.Add(new InspectorEndPointBehavior());
            //}

            host.Open();
            hosts.Add(host);
        }

        public static void StartAllServices()
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location);

            ServiceModelSectionGroup svcmod = (ServiceModelSectionGroup)conf.GetSectionGroup("system.serviceModel");

            string dllMode;
            foreach (ServiceElement el in svcmod.Services.Services)
            {
                //用字符串反射类型，需要指定使用的dll名称，这里需要约定在配置文件中service name配置项需要与dll中服务class名一致
                //且统一格式dllname.serviceclassname
                dllMode = el.Name.Substring(0, el.Name.IndexOf('.'));
                el.Name = string.Format("{0},{1}", el.Name,dllMode);

                Type svcType = Type.GetType(el.Name);
                if (svcType == null)
                    throw new Exception("Invalid Service Type " + el.Name + " in configuration file.");
                OpenHost(svcType);
                Console.WriteLine(el.Name + " started!");
            }
        }

        public static void StartSingleService(Type t)
        {
            ServiceHost host = new ServiceHost(t);
            host.Open();
            hosts.Add(host);
        }

        public static void closeAllService()
        {
            foreach (ServiceHost hst in hosts)
            {
                hst.Close();
            }
        }
    }
}
