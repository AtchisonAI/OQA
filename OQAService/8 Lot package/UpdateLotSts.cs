using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;
using OQAContract;
using System.ServiceModel;
using System.IO;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<ISPLOTSTS> UpdateLotSts(UpdateModelReq<ISPLOTSTS> input)
        {
            ModelRsp<ISPLOTSTS> rsp = new ModelRsp<ISPLOTSTS>();
            input.model.UpdateTime = GetSystemDateTime();
            UpdateModel(input,rsp,true);
            SaveISPLotHistory(LotSts.PackageOut, input.userId ,rsp);
            return rsp;
        }

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public BaseRsp DeletePackageImg(DeletePackageImgReq input)
        {
            var ImgListRes = QueryPackageImg(new LotPackageInput { lotId = input.lotId});
            if(ImgListRes.models.Count > 0)
            {
                UpdateModelReq<ISPIMGDEF> req = new UpdateModelReq<ISPIMGDEF>
                {
                    operateType = OperateType.Delete
                };

                foreach (ISPIMGDEF img in ImgListRes.models)
                {
                    req.model = img;
                    UpdateModel(req);
                    File.Delete(img.ImagePath);
                }
            }

            BaseRsp rsp = new BaseRsp();
            rsp._success = true;
            return rsp;
        }
    }
}
