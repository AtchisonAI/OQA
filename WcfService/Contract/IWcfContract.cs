using Models.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WcfService.Contract
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

        #region Emp
        [OperationContract]
        PageModelRsp<Emp> QueryEmpInfo(QueryEmpReq queryEmpReq);

        [OperationContract]
        ModelListRsp<CEmpPercentView> QueryEmpPercent(QueryReq queryReq);

        [OperationContract]
        ModelListRsp<CEmpSumView> QueryEmpSum(QueryReq queryReq);

        [OperationContract]
        ModelListRsp<Emp> UpdateEmpInfo(UpdateModelListReq<Emp> updateReq);
        #endregion

        [OperationContract]
        ModelRsp<DemoView> UpdateDemoInfo(UpdateModelReq<DemoView> updateReq);

    }
}
