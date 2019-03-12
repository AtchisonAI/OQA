using System.ServiceModel;
using OQAContract;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelListRsp<CEmpPercentView> QueryEmpPercent(QueryReq queryReq)
        {
            return Query<CEmpPercentView>(queryReq);
        }

        public ModelListRsp<CEmpSumView> QueryEmpSum(QueryReq queryReq)
        {
            return Query<CEmpSumView>(queryReq);
        }

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelListRsp<Emp> UpdateEmpInfo(UpdateModelListReq<Emp> updateReq)
        {
            ModelListRsp<Emp> empUpdateRsp = new ModelListRsp<Emp>();

            UpdateModels(updateReq, empUpdateRsp, true);
            
            return empUpdateRsp;
        }

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<DemoView> UpdateDemoInfo(UpdateModelReq<DemoView> updateReq)
        {
            ModelRsp<DemoView> rsp = new ModelRsp<DemoView>();

            UpdateModelListReq<Emp> req = new UpdateModelListReq<Emp>()
            {
                models = updateReq.model.empList,
                operateType = updateReq.operateType
            };

            UpdateEmpInfo(req);

            UpdateModelListReq<RmsUser> rmsReq = new UpdateModelListReq<RmsUser>()
            {
                models = updateReq.model.rmsList,
                operateType = updateReq.operateType
            };
            UpdateModels(rmsReq);

            return rsp;
        }
    }
}