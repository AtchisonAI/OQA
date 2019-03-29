using log4net;
using Syncfusion.Windows.Forms.Chart.SvgBase;
using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;

namespace WcfInspector
{
    /// <summary>
    ///  消息拦截器
    /// </summary>
    public class WcfMessageInspector : IClientMessageInspector, IDispatchMessageInspector
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        void IClientMessageInspector.AfterReceiveReply(ref Message reply, object correlationState)
        {

            //          Console.WriteLine("客户端接收到的回复：\n{0}", reply.ToString());
        }

        object IClientMessageInspector.BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            AddMsgVersion(ref request);
            //            Console.WriteLine("客户端发送请求前的SOAP消息：\n{0}", request.ToString());
            return null;
        }

        object IDispatchMessageInspector.AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            CheckMsgVersion(ref request);
            //Console.WriteLine("服务器端：接收到的请求：\n{0}", request.ToString());
            return null;
        }

        void IDispatchMessageInspector.BeforeSendReply(ref Message reply, object correlationState)
        {
            if (reply.IsFault)
            {
                WriteExceptionLog(ref reply);
            }

            Console.WriteLine("服务器即将作出以下回复：\n{0}", reply.ToString());
        }

        private void WriteExceptionLog(ref Message message)
        {
            var xd = new XmlDocument();
            xd.LoadXml(message.ToString());
            XmlNamespaceManager xnm = new XmlNamespaceManager(xd.NameTable);
            xnm.AddNamespace("s", "http://www.w3.org/2003/05/soap-envelope");
            xnm.AddNamespace("x", "http://schemas.datacontract.org/2004/07/System.ServiceModel");
            XmlNode reasonNode = xd.SelectSingleNode("/s:Envelope/s:Body/s:Fault/s:Detail/x:ExceptionDetail/x:Message", xnm);
            XmlNode stackNode = xd.SelectSingleNode("/s:Envelope/s:Body/s:Fault/s:Detail/x:ExceptionDetail/x:StackTrace", xnm);
            XmlNode typeNode = xd.SelectSingleNode("/s:Envelope/s:Body/s:Fault/s:Detail/x:ExceptionDetail/x:Type", xnm);

            log.Error(string.Format("Exception Reason:{0},Exception Type:{1},StackTrack:{2}", reasonNode?.InnerText, stackNode?.InnerText, typeNode?.InnerText));
        }

        private void AddMsgVersion(ref Message request)
        {
            MessageHeader clientVersion = MessageHeader.CreateHeader("version", "client", VersionContrl.clientVersion);
            request.Headers.Add(clientVersion);
        }

        private void CheckMsgVersion(ref Message request)
        {
            string version = request.Headers.GetHeader<string>("version", "client");
            if(!VersionContrl.MatchVersion(version))
            {
                throw new Exception("消息版本不匹配,必须升级客户端");
            }
        }
    }

    /// <summary>
    /// 插入到终结点的Behavior
    /// </summary>
    public class InspectorEndPointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            // 不需要
            return;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            // 植入“偷听器”客户端
            clientRuntime.MessageInspectors.Add(new WcfMessageInspector());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            // 植入“偷听器” 服务器端
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new WcfMessageInspector());
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            // 不需要
            return;
        }
    }

    //自定义配置节点
    public class InspectorEndPointBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(InspectorEndPointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new InspectorEndPointBehavior();
        }
    }
}