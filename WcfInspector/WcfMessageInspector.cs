using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WcfInspector
{
    /// <summary>
    ///  消息拦截器
    /// </summary>
    public class WcfMessageInspector : IClientMessageInspector, IDispatchMessageInspector
    {
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
            Console.WriteLine("服务器即将作出以下回复：\n{0}", reply.ToString());
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            throw new NotImplementedException();
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            throw new NotImplementedException();
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