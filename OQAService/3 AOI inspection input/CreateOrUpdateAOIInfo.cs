using System;
using WCFModels.Message;
using WCFModels.OQA;
using System.ServiceModel;
using OQAContract;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

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
                out_Msg._success = true;
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
                queryInfo.model.QryAllFlag = true;
                queryInfo.model.C_TRAN_FLAG = GlobalConstant.TRAN_VIEW;
                ModelRsp<AOIShowView> qryOut = QueryAOIInfo(queryInfo);

                //业务逻辑选择
                switch (updateReq.model.C_PROC_STEP)
                {
                    case '1':

                        if (null != qryOut.model)
                        {   //update ISPWAFITM
                            if (null != qryOut.model.ISPWAFITM_list && qryOut.model.ISPWAFITM_list.Count > 0)
                            {
                                updateReq.model.ISPWAFITM_list[0].TransSeq = qryOut.model.ISPWAFITM_list[0].TransSeq;
                                updateReq.model.ISPWAFITM_list[0].UpdateTime = GetSysTime();
                                UpdateModelReq <ISPWAFITM> wafitm = new UpdateModelReq<ISPWAFITM>()
                                {
                                    model = updateReq.model.ISPWAFITM_list[0],
                                    operateType = OperateType.Update
                                };
                                InitTable(wafitm.model);
                                ModelRsp<ISPWAFITM> backInfo = new ModelRsp<ISPWAFITM>();//定义数据库操作新增动作传入结构
                                UpdateModel(wafitm, backInfo, true);
                                if (!backInfo._success)
                                {
                                    out_Msg._success = false;
                                    out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                }
                            }
                            //save or update ISPIMGDEF
                            //if (null != updateReq.model.ISPIMGDEF_list && updateReq.model.ISPIMGDEF_list.Count > 0)
                            //{
                            //    if (null != qryOut.model.ISPIMGDEF_list && qryOut.model.ISPIMGDEF_list.Count > 0)
                            //    {

                            //        foreach (ISPIMGDEF imgReq in updateReq.model.ISPIMGDEF_list)
                            //        {
                            //            OperateType operateTypeImg = OperateType.Insert;
                            //            imgReq.TransSeq = 0;
                            //            foreach (ISPIMGDEF imgQry in qryOut.model.ISPIMGDEF_list)
                            //            {
                            //                if (imgReq.SlotId.Equals(imgQry.SlotId) && imgReq.AreaId == imgQry.AreaId
                            //                    && imgReq.ImageId.Equals(imgQry.ImageId))
                            //                {
                            //                    imgReq.TransSeq = imgQry.TransSeq;
                            //                    operateTypeImg = OperateType.Update;
                            //                }
                            //            }
                            //            UpdateModelReq<ISPIMGDEF> imgdef = new UpdateModelReq<ISPIMGDEF>()
                            //            {
                            //                model = imgReq,
                            //                operateType = operateTypeImg
                            //            };
                            //                ModelRsp<ISPIMGDEF> backInfo = new ModelRsp<ISPIMGDEF>();//定义数据库操作新增动作传入结构
                            //                UpdateModel(imgdef, backInfo, true);
                            //                if (!backInfo._success)
                            //                {
                            //                    out_Msg._success = false;
                            //                    out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                            //                }
                            //        }
                            //    }
                            //    else
                            //    {
                            //        foreach (ISPIMGDEF imgReq in updateReq.model.ISPIMGDEF_list)
                            //        {
                            //            imgReq.TransSeq = 0;
                            //            UpdateModelReq<ISPIMGDEF> imgdef = new UpdateModelReq<ISPIMGDEF>()
                            //            {
                            //                model = imgReq,
                            //                operateType = OperateType.Insert
                            //            };
                            //            ModelRsp<ISPIMGDEF> backInfo = new ModelRsp<ISPIMGDEF>();//定义数据库操作新增动作传入结构
                            //            UpdateModel(imgdef, backInfo, true);
                            //            if (!backInfo._success)
                            //            {
                            //                out_Msg._success = false;
                            //                out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                            //            }
                            //        }

                            //    }

                            //}
                            //save or update ISPWAFDFT
                            
                            if (null != updateReq.model.ISPWAFDFT_list && updateReq.model.ISPWAFDFT_list.Count > 0)
                            {
                                if (null != qryOut.model.ISPWAFDFT_list && qryOut.model.ISPWAFDFT_list.Count > 0)
                                {
                                    List<ISPWAFDFT> copyQryList = new List<ISPWAFDFT>();
                                    foreach(ISPWAFDFT qry in  qryOut.model.ISPWAFDFT_list){
                                        copyQryList.Add(qry);
                                    }
                                    foreach (ISPWAFDFT detReq in updateReq.model.ISPWAFDFT_list)
                                    {
                                        detReq.TransSeq = 0;
                                        detReq.CreateTime = GetSysTime();
                                        OperateType operateTypeDft = OperateType.Insert;
                                        for(int i = 0; i < qryOut.model.ISPWAFDFT_list.Count; i++)
                                        {
                                            if (detReq.SlotId.Equals(qryOut.model.ISPWAFDFT_list[i].SlotId) 
                                                && detReq.AreaId == qryOut.model.ISPWAFDFT_list[i].AreaId
                                            && detReq.DefectCode.Equals(qryOut.model.ISPWAFDFT_list[i].DefectCode))
                                            {
                                                detReq.TransSeq = qryOut.model.ISPWAFDFT_list[i].TransSeq;
                                                operateTypeDft = OperateType.Update;
                                                detReq.CreateTime = qryOut.model.ISPWAFDFT_list[i].CreateTime;
                                                detReq.UpdateTime = GetSysTime();
                                                detReq.UpdateUserId = detReq.CreateUserId;
                                                detReq.CreateUserId = qryOut.model.ISPWAFDFT_list[i].CreateUserId;
                                                //移除更新的数据
                                                copyQryList.Remove(qryOut.model.ISPWAFDFT_list[i]);
                                            }
                                            
                                        }
                                        //foreach (ISPWAFDFT detQry in qryOut.model.ISPWAFDFT_list)
                                        //{
                                        //    if (detReq.SlotId.Equals(detQry.SlotId) && detReq.AreaId == detQry.AreaId
                                        //    && detReq.DefectCode.Equals(detQry.DefectCode))
                                        //    {
                                        //        detReq.TransSeq = detQry.TransSeq;
                                        //        operateTypeDft = OperateType.Update;
                                        //    }
                                        //    //移除更新的数据
                                        //    copyQryList.Remove(detQry);
                                        //}
                                        
                                        UpdateModelReq<ISPWAFDFT> wafdet = new UpdateModelReq<ISPWAFDFT>()
                                        {
                                            model = detReq,
                                            operateType = operateTypeDft
                                        };
                                        InitTable(wafdet.model);
                                        ModelRsp<ISPWAFDFT> backInfo = new ModelRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                        UpdateModel(wafdet, backInfo, true);
                                        if (!backInfo._success)
                                        {
                                            out_Msg._success = false;
                                            out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                        }
                                    }
                                    //delete
                                    UpdateModelListReq<ISPWAFDFT> deleteList = new UpdateModelListReq<ISPWAFDFT>()
                                    {
                                        models = copyQryList,
                                        operateType = OperateType.Delete
                                    };
                                    InitTable(deleteList.models);
                                    ModelListRsp<ISPWAFDFT> deleteBackInfo = new ModelListRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                    UpdateModels(deleteList, deleteBackInfo, true);
                                    if (!deleteBackInfo._success)
                                    {
                                        out_Msg._success = false;
                                        out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + deleteBackInfo._ErrorMsg;
                                    }
                                }
                                else
                                {
                                    foreach (ISPWAFDFT detReq in updateReq.model.ISPWAFDFT_list)
                                    {
                                        detReq.TransSeq = 0;
                                        detReq.CreateTime = GetSysTime();
                                        UpdateModelReq<ISPWAFDFT> wafdet = new UpdateModelReq<ISPWAFDFT>()
                                        {
                                            model = detReq,
                                            operateType = OperateType.Insert
                                        };
                                        InitTable(wafdet.model);
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
                            else
                            {//请求为空列表时detete旧数据
                                if (null != qryOut.model.ISPWAFDFT_list && qryOut.model.ISPWAFDFT_list.Count > 0)
                                {
                                    UpdateModelListReq<ISPWAFDFT> wafdet = new UpdateModelListReq<ISPWAFDFT>()
                                    {
                                        models = qryOut.model.ISPWAFDFT_list,
                                        operateType = OperateType.Delete
                                    };
                                    InitTable(wafdet.models);
                                    ModelListRsp<ISPWAFDFT> backInfo = new ModelListRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                    UpdateModels(wafdet, backInfo, true);
                                    if (!backInfo._success)
                                    {
                                        out_Msg._success = false;
                                        out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                    }

                                    //foreach (ISPWAFDFT qry in qryOut.model.ISPWAFDFT_list)
                                    //{
                                    //    UpdateModelReq<ISPWAFDFT> wafdet = new UpdateModelReq<ISPWAFDFT>()
                                    //    {
                                    //        model = qry,
                                    //        operateType = OperateType.Delete
                                    //    };
                                    //    ModelRsp<ISPWAFDFT> backInfo = new ModelRsp<ISPWAFDFT>();//定义数据库操作新增动作传入结构
                                    //    UpdateModel(wafdet, backInfo, true);
                                    //    if (!backInfo._success)
                                    //    {
                                    //        out_Msg._success = false;
                                    //        out_Msg._ErrorMsg = out_Msg._ErrorMsg + "  " + backInfo._ErrorMsg;
                                    //    }
                                    //}
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