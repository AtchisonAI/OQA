using System;
using System.Collections.Generic;
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
            if(stsRes._success)
            {
                var ImgListRes = QueryPackageImg(input);
                rsp.model.lotInfo = stsRes.model;
                rsp.model.packageImgList = ImgListRes.models;
                rsp._success = stsRes._success && ImgListRes._success;
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
    }
}
