using System.ServiceModel;
using WCFModels.Frame;
using WCFModels.Message;

namespace WcfContract
{
    [ServiceContract]
    public interface IWcfContract
    {
        #region 登陆&权限

        [OperationContract]
        ModelListRsp<string> Login(LoginReq loginReq);

        [OperationContract]
        ModelListRsp<ControlAccessString> QueryControlAccessString(QueryReq queryReq);

        [OperationContract]
        PageModelRsp<ControlAccessString> PageQueryControlAccessString(PageQueryReq pageQueryReq);

        [OperationContract]
        ModelRsp<ControlAccessString> UpdateControlAccessString(UpdateModelReq<ControlAccessString> updateReq);

        #endregion
    }
}
