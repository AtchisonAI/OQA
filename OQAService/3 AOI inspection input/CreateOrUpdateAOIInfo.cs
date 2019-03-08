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

                UpdateModelListReq<ISPDFTDEF> Do_Save = new UpdateModelListReq<ISPDFTDEF>();//定义数据库操作新增动作传入结构
                ModelListRsp<ISPDFTDEF> Do_message = new ModelListRsp<ISPDFTDEF>();         //定义数据库操作新增动作输出结构
                ISPDFTDEF T_ISPDFTDEF = new ISPDFTDEF(); //定义临时表结构

                //验证系统级别输入参数
                if (updateReq.model.C_PROC_STEP.Equals("") == true)
                {
                    out_Msg._success = false;
                    out_Msg._ErrorMsg = "C_PROC_STEP is null!";
                    return out_Msg;

                }
                //if (updateReq.model.C_TRAN_FLAG.Equals("") == true)
                //{
                //    out_Msg._success = false;
                //    out_Msg._ErrorMsg = "C_TRAN_FLAG is null!";
                //    return out_Msg;

                //}
                ModelRsp<AOIShowView> queryInfo = new ModelRsp<AOIShowView>();
                queryInfo.model = updateReq.model;
                queryInfo.model.C_TRAN_FLAG = GlobalConstant.TRAN_VIEW;
                ModelRsp<AOIShowView> qryOut = QueryAOIInfo(queryInfo);
                OperateType operateTypeItm = OperateType.Insert;
                OperateType operateTypeDft = OperateType.Insert;
                OperateType operateTypeImg = OperateType.Insert;

                if (null != qryOut.model)
                {
                    if (null != qryOut.model.ISPWAFITM)
                    {
                        operateTypeItm = OperateType.Update;
                        updateReq.model.ISPWAFITM.TransSeq = qryOut.model.ISPWAFITM.TransSeq + 1;
                    }
                    else
                    {
                        updateReq.model.ISPWAFITM.TransSeq = 0;
                    }

                    if (null != qryOut.model.ISPIMGDEF_list && qryOut.model.ISPIMGDEF_list.Count > 0)
                    {
                        operateTypeDft = OperateType.Update;
                        foreach(ISPIMGDEF imgReq in updateReq.model.ISPIMGDEF_list)
                        {
                            foreach(ISPIMGDEF imgQry in qryOut.model.ISPIMGDEF_list)
                            {
                                if(imgReq.SlotId.Equals(imgQry.SlotId) && imgReq.AreaId == imgQry.AreaId)
                                {
                                    imgReq.TransSeq = imgQry.TransSeq + 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (null != updateReq.model.ISPIMGDEF_list && updateReq.model.ISPIMGDEF_list.Count > 0)
                        {
                            foreach (ISPIMGDEF img in updateReq.model.ISPIMGDEF_list)
                            {
                                    img.TransSeq = 0;
                            }
                        }
                    }
                    if (null != qryOut.model.ISPWAFDFT_list && qryOut.model.ISPWAFDFT_list.Count > 0)
                    {
                        operateTypeImg = OperateType.Update;
                        foreach (ISPWAFDFT detReq in updateReq.model.ISPWAFDFT_list)
                        {
                            foreach (ISPWAFDFT detQry in qryOut.model.ISPWAFDFT_list)
                            {
                                if (detReq.SlotId.Equals(detQry.SlotId) && detReq.AreaId == detQry.AreaId)
                                {
                                    detReq.TransSeq = detQry.TransSeq + 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (null != updateReq.model.ISPWAFDFT_list && updateReq.model.ISPWAFDFT_list.Count > 0)
                        {
                            foreach (ISPWAFDFT det in updateReq.model.ISPWAFDFT_list)
                            {
                                det.TransSeq = 0;
                            }
                        }
                    }
                }

                //业务逻辑选择
                switch (updateReq.model.C_PROC_STEP)
                {
                    case '1':
                        BeginTrans();
                        UpdateModelReq<ISPWAFITM> wafitm = new UpdateModelReq<ISPWAFITM>()
                        {
                            model = updateReq.model.ISPWAFITM,
                            operateType = operateTypeItm
                        };
                        UpdateModel(wafitm);

                        UpdateModelListReq<ISPWAFDFT> wafdet = new UpdateModelListReq<ISPWAFDFT>()
                        {
                            models = updateReq.model.ISPWAFDFT_list,
                            operateType = operateTypeDft
                        };
                        UpdateModels<ISPWAFDFT>(wafdet);

                        UpdateModelListReq<ISPIMGDEF> imgdef = new UpdateModelListReq<ISPIMGDEF>()
                        {
                            models = updateReq.model.ISPIMGDEF_list,
                            operateType = operateTypeImg
                        };
                        UpdateModels<ISPIMGDEF>(imgdef);

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

            catch (Exception e)
            {
                ModelRsp<AOIShowView> out_Msg = new ModelRsp<AOIShowView>();
                out_Msg._success = false;
                out_Msg._ErrorMsg = "C_TRAN_FLAG is null!";
                return out_Msg;
            }

        }


    }
}