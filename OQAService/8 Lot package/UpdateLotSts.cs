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
            UpdateTrackModel(input,rsp,true);
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

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<LotPackageView> UpdateLotPackageSts(UpdateModelReq<LotPackageView> input)
        {
            ModelRsp<LotPackageView> rsp = new ModelRsp<LotPackageView>();

            UpdateModelReq<ISPLOTSTS> lotStsRep = new UpdateModelReq<ISPLOTSTS>();
            lotStsRep.model = input.model.lotInfo;
            lotStsRep.operateType = OperateType.Update;
            var res = UpdateLotSts(lotStsRep);
            if (res._success)
            {
                rsp.model.lotInfo = res.model;
                UpdateModelListReq<PKGCHKRST> checkUpdateReq = new UpdateModelListReq<PKGCHKRST>();
                checkUpdateReq.models = input.model.packageCheckList;
                checkUpdateReq.operateType = input.operateType;
                var checkUpdateRes = UpdateLotCheckList(checkUpdateReq);
                rsp.model.packageCheckList = checkUpdateRes.models;
                rsp._success = res._success && checkUpdateRes._success;
            } else
            {
                rsp._success = false;
                rsp._ErrorMsg = "lot package update failed";
                log.Error(rsp._ErrorMsg);
            }
            
            return rsp;
        }

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelListRsp<PKGCHKRST> UpdateLotCheckList(UpdateModelListReq<PKGCHKRST> input)
        {
            ModelListRsp<PKGCHKRST> rsp = new ModelListRsp<PKGCHKRST>();
            UpdateTrackModels(input, rsp, true);
            return rsp;
        }
    }
}
