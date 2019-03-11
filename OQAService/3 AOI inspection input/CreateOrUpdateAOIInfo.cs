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
using System.ServiceModel;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<AOIShowView> CreateOrUpdateAOI(UpdateModelReq<AOIShowView> updateReq)
        {
            try
            {
                ModelRsp<AOIShowView> out_Msg = new ModelRsp<AOIShowView>();

                updateReq.partialUpdate = true;//部分更新
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
                //先查询
                ModelRsp<AOIShowView> queryInfo = new ModelRsp<AOIShowView>();
                queryInfo.model = updateReq.model;
                queryInfo.model.C_TRAN_FLAG = GlobalConstant.TRAN_VIEW;
                ModelRsp<AOIShowView> qryOut = QueryAOIInfo(queryInfo);

                //业务逻辑选择
                switch (updateReq.model.C_PROC_STEP)
                {
                    case '1':

                        if (null != qryOut.model)
                        {   //update ISPWAFITM
                            if (null != qryOut.model.ISPWAFITM)
                            {
                                updateReq.model.ISPWAFITM.TransSeq = qryOut.model.ISPWAFITM.TransSeq;
                                UpdateModelReq<ISPWAFITM> wafitm = new UpdateModelReq<ISPWAFITM>()
                                {
                                    model = updateReq.model.ISPWAFITM,
                                    operateType = OperateType.Update
                                };
                                ModelRsp<ISPWAFITM> backInfo = new ModelRsp<ISPWAFITM>();//定义数据库操作新增动作传入结构
                                UpdateModel(wafitm, backInfo, true);
                                if (!backInfo._success)
                                {
                                    out_Msg._success = false;
                                    out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                }
                            }
                            //save  ISPIMGDEF
                            if (null != updateReq.model.ISPIMGDEF_list && updateReq.model.ISPIMGDEF_list.Count > 0)
                            {
                                if (null != qryOut.model.ISPIMGDEF_list && qryOut.model.ISPIMGDEF_list.Count > 0)
                                {

                                    foreach (ISPIMGDEF imgReq in updateReq.model.ISPIMGDEF_list)
                                    {
                                        OperateType operateTypeImg = OperateType.Insert;
                                        imgReq.TransSeq = 0;
                                        foreach (ISPIMGDEF imgQry in qryOut.model.ISPIMGDEF_list)
                                        {
                                            if (imgReq.SlotId.Equals(imgQry.SlotId) && imgReq.AreaId == imgQry.AreaId
                                                && imgReq.ImageId.Equals(imgQry.ImageId))
                                            {
                                                imgReq.TransSeq = imgQry.TransSeq;
                                                operateTypeImg = OperateType.Update;
                                            }
                                        }
                                        UpdateModelReq<ISPIMGDEF> imgdef = new UpdateModelReq<ISPIMGDEF>()
                                        {
                                            model = imgReq,
                                            operateType = operateTypeImg
                                        };
                                        if (operateTypeImg is OperateType.Insert)
                                        {
                                            ModelRsp<ISPIMGDEF> backInfo = new ModelRsp<ISPIMGDEF>();//定义数据库操作新增动作传入结构
                                            UpdateModel(imgdef, backInfo, true);
                                            if (!backInfo._success)
                                            {
                                                out_Msg._success = false;
                                                out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (ISPIMGDEF imgReq in updateReq.model.ISPIMGDEF_list)
                                    {
                                        imgReq.TransSeq = 0;
                                        UpdateModelReq<ISPIMGDEF> imgdef = new UpdateModelReq<ISPIMGDEF>()
                                        {
                                            model = imgReq,
                                            operateType = OperateType.Insert
                                        };
                                        ModelRsp<ISPIMGDEF> backInfo = new ModelRsp<ISPIMGDEF>();//定义数据库操作新增动作传入结构
                                        UpdateModel(imgdef, backInfo, true);
                                        if (!backInfo._success)
                                        {
                                            out_Msg._success = false;
                                            out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                        }
                                    }

                                }

                            }
                            //save  ISPWAFDFT
                            if (null != updateReq.model.ISPWAFDFT_list && updateReq.model.ISPWAFDFT_list.Count > 0)
                            {
                                if (null != qryOut.model.ISPWAFDFT_list && qryOut.model.ISPWAFDFT_list.Count > 0)
                                {

                                    foreach (ISPWAFDFT detReq in updateReq.model.ISPWAFDFT_list)
                                    {
                                        detReq.TransSeq = 0;
                                        OperateType operateTypeDft = OperateType.Insert;
                                        foreach (ISPWAFDFT detQry in qryOut.model.ISPWAFDFT_list)
                                        {
                                            if (detReq.SlotId.Equals(detQry.SlotId) && detReq.AreaId == detQry.AreaId
                                            && detReq.DefectCode.Equals(detQry.DefectCode))
                                            {
                                                detReq.TransSeq = detQry.TransSeq;
                                                operateTypeDft = OperateType.Update;
                                            }
                                        }
                                        //目前只能新增更新存在问题 多个code列的主键一样
                                        if (operateTypeDft is OperateType.Insert)
                                        {
                                            UpdateModelReq<ISPWAFDFT> wafdet = new UpdateModelReq<ISPWAFDFT>()
                                            {
                                                model = detReq,
                                                operateType = operateTypeDft
                                            };
                                            ModelRsp<ISPWAFDFT> backInfo = new ModelRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                            UpdateModel(wafdet, backInfo, true);
                                            if (!backInfo._success)
                                            {
                                                out_Msg._success = false;
                                                out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (ISPWAFDFT detReq in updateReq.model.ISPWAFDFT_list)
                                    {
                                        detReq.TransSeq = 0;
                                        UpdateModelReq<ISPWAFDFT> wafdet = new UpdateModelReq<ISPWAFDFT>()
                                        {
                                            model = detReq,
                                            operateType = OperateType.Insert
                                        };
                                        ModelRsp<ISPWAFDFT> backInfo = new ModelRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                        UpdateModel<ISPWAFDFT>(wafdet, backInfo, true);
                                        if (!backInfo._success)
                                        {
                                            out_Msg._success = false;
                                            out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                        }
                                    }
                                }

                            }

                        }
                        break;
                    case '2':
                        // TODO
                        break;
                    case '3':
                        // TODO

                        break;
                }
                if (out_Msg._success)
                {
                    out_Msg._MsgCode = "Program Success.";
                }

                return out_Msg;
            }

            catch (Exception e)
            {
                ModelRsp<AOIShowView> out_Msg = new ModelRsp<AOIShowView>();
                out_Msg._success = false;
                out_Msg._ErrorMsg = e.Message.ToString();
                return out_Msg;
            }

        }


    }
}