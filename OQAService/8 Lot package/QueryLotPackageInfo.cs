using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;
using OQAContract;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotPackageView> QueryLotPackageInfo(LotPackageInput input)
        {
            ModelRsp<LotPackageView> rsp = new ModelRsp<LotPackageView>();
            var stsRes = QueryLotSts(input);
            if(stsRes._success && stsRes.model.Status.Equals(LotSts.ChangeOut))
            {
                var ImgListRes = QueryPackageImg(input);
                rsp.model.lotInfo = stsRes.model;
                rsp.model.packageImgList = ImgListRes.models;

                var CheckListRes = QueryCheckList(input);
                rsp.model.packageCheckList = CheckListRes.models;

                rsp._success = stsRes._success && ImgListRes._success && CheckListRes._success;
            } else
            {
                rsp._success = false;
                rsp._ErrorMsg = string.Format("Lot id:{0},Error:Lot hasn't in{1} status,or lot isn't exist!", input.lotId,LotSts.ChangeOut);
                log.Error(rsp._ErrorMsg);
            } 

            return rsp;
        }

        public ModelListRsp<ISPIMGDEF> QueryPackageImg(LotPackageInput input)
        {
            QueryReq req = new QueryReq();
            AddCondition(req, GetParaName<ISPIMGDEF>(P => P.LotId), input.lotId, LogicCondition.AndAlso, CompareType.Equal);
            return Query<ISPIMGDEF>(req);
        }

        public ModelRsp<ISPLOTSTS> QueryLotSts(LotPackageInput input)
        {
            return SingleQuery<ISPLOTSTS>(input.lotId);
        }

        public ModelListRsp<PKGCHKRST> QueryCheckList(LotPackageInput input)
        {
            QueryReq req = new QueryReq();
            AddCondition(req, GetParaName<PKGCHKRST>(P => P.LotId), input.lotId, LogicCondition.AndAlso, CompareType.Equal);
            return Query<PKGCHKRST>(req);
        }
    }
}
