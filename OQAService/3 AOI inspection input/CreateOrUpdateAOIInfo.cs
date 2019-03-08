using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;
using OQAService.Contract;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<AOIShowView> CreateOrUpdateAOI(UpdateModelReq<AOIShowView> updateReq)
        {
            try
            {
                ModelRsp<AOIShowView> out_Msg = new ModelRsp<AOIShowView>();

                //验证系统级别输入参数
                if (updateReq.model.C_PROC_STEP.Equals("") == true)
                {
                    out_Msg._success = false;
                    out_Msg._ErrorMsg = "C_PROC_STEP is null!";
                    return out_Msg;

                }
                if (updateReq.model.C_TRAN_FLAG.Equals("") == true)
                {
                    out_Msg._success = false;
                    out_Msg._ErrorMsg = "C_TRAN_FLAG is null!";
                    return out_Msg;

                }

                if (updateReq.model.C_PROC_STEP == GlobalConstant.TRAN_CREATE)
                {
                    //业务逻辑选择
                    switch (updateReq.model.C_TRAN_FLAG)
                    {
                        case '1':
                            BeginTrans();
                            UpdateModelReq<ISPWAFITM> wafitm = new UpdateModelReq<ISPWAFITM>()
                            {
                                model = updateReq.model.ISPWAFITM,
                                operateType = updateReq.operateType
                            };
                            UpdateModel(wafitm);

                            UpdateModelListReq<ISPWAFDFT> wafdet = new UpdateModelListReq<ISPWAFDFT>()
                            {
                                models = updateReq.model.ISPWAFDFT_list,
                                operateType = updateReq.operateType
                            };
                            //UpdateModelObjects<ISPWAFDFT>(wafdet);

                            UpdateModelListReq<ISPIMGDEF> imgdef = new UpdateModelListReq<ISPIMGDEF>()
                            {
                                models = updateReq.model.ISPIMGDEF_list,
                                operateType = updateReq.operateType
                            };
                            //UpdateModelingObjects<ISPWAFDFT>(imgdef);

                            EndTrans();
                            break;
                        case '2':
                            // TODO
                            break;
                        case '3':
                            // TODO

                            break;
                    }
                }
                else if (updateReq.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (updateReq.model.C_TRAN_FLAG)
                    {
                        case '1':
                            BeginTrans();
                            UpdateModelReq<ISPWAFITM> wafitm = new UpdateModelReq<ISPWAFITM>()
                            {
                                model = updateReq.model.ISPWAFITM,
                                operateType = updateReq.operateType
                            };
                            UpdateModel(wafitm);

                            UpdateModelListReq<ISPWAFDFT> wafdet = new UpdateModelListReq<ISPWAFDFT>()
                            {
                                models = updateReq.model.ISPWAFDFT_list,
                                operateType = updateReq.operateType
                            };
                            //UpdateModelObjects<ISPWAFDFT>(wafdet);

                            UpdateModelListReq<ISPIMGDEF> imgdef = new UpdateModelListReq<ISPIMGDEF>()
                            {
                                models = updateReq.model.ISPIMGDEF_list,
                                operateType = updateReq.operateType
                            };
                            //UpdateModelingObjects<ISPWAFDFT>(imgdef);

                            EndTrans();
                            break;
                        case '2':
                            // TODO
                            break;
                        case '3':
                            // TODO

                            break;
                    }

                    out_Msg._success = true;
                    out_Msg._MsgCode = "Program Success.";
                    return out_Msg;
                }
            }
            catch (Exception e)
            {
                ModelRsp<AOIShowView> out_Msg = new ModelRsp<AOIShowView>();
                out_Msg._success = false;
                out_Msg._ErrorMsg = "C_TRAN_FLAG is null!";
                return out_Msg;
            }

            return null;
        }


    }
}