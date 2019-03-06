using OQAService.Contract;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        //public PageModelRsp<Emp> QueryEmpInfo(QueryEmpReq queryEmpReq)
        //{
        //    return PageQuery<Emp>(queryEmpReq);
        //}

        public ModelListRsp<CEmpPercentView> QueryEmpPercent(QueryReq queryReq)
        {
            return Query<CEmpPercentView>(queryReq);
        }

        public ModelListRsp<CEmpSumView> QueryEmpSum(QueryReq queryReq)
        {
            return Query<CEmpSumView>(queryReq);
        }

        public ModelListRsp<Emp> UpdateEmpInfo(UpdateModelListReq<Emp> updateReq)
        {
            ModelListRsp<Emp> empUpdateRsp = new ModelListRsp<Emp>();

            BeginTrans();
            UpdateModelingObjects(updateReq, empUpdateRsp, true);
            EndTrans();
            
            return empUpdateRsp;
        }

        public ModelRsp<DemoView> UpdateDemoInfo(UpdateModelReq<DemoView> updateReq)
        {
            ModelRsp<DemoView> rsp = new ModelRsp<DemoView>();

            BeginTrans();
            UpdateModelListReq<Emp> req = new UpdateModelListReq<Emp>()
            {
                models = updateReq.model.empList,
                opreateType = updateReq.opreateType
            };

            UpdateModelObjects(req);

            UpdateModelListReq<RmsUser> rmsReq = new UpdateModelListReq<RmsUser>()
            {
                models = updateReq.model.rmsList,
                opreateType = updateReq.opreateType
            };
            UpdateModelObjects(rmsReq);

            EndTrans();
            return rsp;
        }

    }
}
