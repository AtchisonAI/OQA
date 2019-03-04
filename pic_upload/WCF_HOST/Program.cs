using System.ServiceModel;
using TransferPic;
using System.ServiceModel.Description;
using System;

namespace WCF_HOST
{
    class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding bind = new NetTcpBinding();
            bind.MaxBufferSize = 214783647;
            bind.TransferMode = TransferMode.Streamed;
            bind.MaxReceivedMessageSize = 214783647;
            bind.Security.Mode = SecurityMode.None;
            //超出using 范围程序会自动释放
            using (ServiceHost host = new ServiceHost(typeof(TransferPic.TransferPicService)))
            {
                host.AddServiceEndpoint(typeof(ITransferPicService), bind, "net.tcp://localhost:9600/transferPic");//该地址为宿主地址，和客户端接收端地址保持一致
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://localhost:9603/transferPic/metadata/");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate { Console.WriteLine("图片程序已成功启动！"); };
                host.Open();
                Console.ReadLine();
            }
        }

    }
}

