using OQAContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using OQAService.WorkFlowService;
using WCFModels;
using WCFModels.Message;
using WCFModels.MESDB.FWTST1;
using WCFModels.OQA;


namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<LotPndnInfoSave> IstPndnInfo(ModelRsp<LotPndnInfoSave>SavePndnInfo)
        {
            
                ModelRsp<LotPndnInfoSave> In_node = new ModelRsp<LotPndnInfoSave>();
                ModelRsp<LotPndnInfoSave> Out_node = new ModelRsp<LotPndnInfoSave>();

                UpdateModelListReq<OUT_PNDN> Do_Save = new UpdateModelListReq<OUT_PNDN>();//定义数据库操作新增动作传入结构
                ModelListRsp<OUT_PNDN> Do_message = new ModelListRsp<OUT_PNDN>();         //定义数据库操作新增动作输出结构
                OUT_PNDN T_Out_Pndn = new OUT_PNDN(); //定义临时表结构

                //传入数据赋值

                In_node.model = SavePndnInfo.model;
               

                //验证系统级别输入参数

                if (In_node.model.C_PROC_STEP.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_PROC_STEP is null!";
                    return Out_node;

                }
                if (In_node.model.C_TRAN_FLAG.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_TRAN_FLAG is null!";
                    return Out_node;

                }

               
                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_CREATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                        //验证业务级输入参数


                        if (In_node.model.IN_LOT_ID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOT_ID is null!";
                                return Out_node;
                            }

                        QueryReq IsChkLot = new QueryReq();


                        IsChkLot.queryConditionList.Add(new QueryCondition() { paramName = "LotId", value = In_node.model.IN_LOT_ID.Trim(),compareType = CompareType.Equal});
                        

                        if (Query<OUT_PNDN>(IsChkLot).models.Count > 0)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = "Lotid PNDN已存在!";
                            return Out_node;
                        }


                        //传入数据赋值
                        if (null != SavePndnInfo.model.PndnList && SavePndnInfo.model.PndnList.Count > 0)
                        {
                            UpdateModelListReq<OUT_PNDN> insertpkgslt = new UpdateModelListReq<OUT_PNDN>();

                            foreach (OUT_PNDN out_Pndn in SavePndnInfo.model.PndnList)
                            {
                               
                                string s_requestname = out_Pndn.LotId + "-" + out_Pndn.InspectType + "-" + out_Pndn.DefectCode;

                                //获取PNDN Number
                                string PndnNumber = string.Empty;
                                try
                                {
                                    PndnNumber= GetPndnNumber(s_requestname, out_Pndn.UserId, out_Pndn.DefectCode);
                                    out_Pndn.PndnNo = PndnNumber;
                                    out_Pndn.PndnStatus = "Y";
                                    out_Pndn.PndnErr = "Send Success";
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    out_Pndn.PndnStatus = "N";
                                    out_Pndn.PndnErr = e.ToString();
                                }

                                out_Pndn.CreateUserId = In_node.model.PndnList[0].UserId;
                                out_Pndn.CreateTime = GetSysTime();
                                InitTable(out_Pndn);

                                insertpkgslt.models.Add(out_Pndn);
                                insertpkgslt.operateType = OperateType.Insert;

                            }

                            ModelListRsp<OUT_PNDN> backInfo = new ModelListRsp<OUT_PNDN>();//定义数据库操作新增动作传入结构
                            OUT_PNDN t_OUT_PNDN = new OUT_PNDN();

                            UpdateModels<OUT_PNDN>(insertpkgslt, backInfo, true);
                            Out_node.model.PndnList = backInfo.models;


                            if (!backInfo._success)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = Out_node._ErrorMsg + "  " + backInfo._ErrorMsg;
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
                }
                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            if (In_node.model.IN_LOT_ID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOT_ID is null!";
                                return Out_node;
                            }

                            QueryReq IsChkLot = new QueryReq();


                            IsChkLot.queryConditionList.Add(new QueryCondition() { paramName = "LotId", value = In_node.model.IN_LOT_ID.Trim(), compareType = CompareType.Equal });
                            IsChkLot.queryConditionList.Add(new QueryCondition() { paramName = "PndnStatus", value = "N", compareType = CompareType.Equal });

                            List<OUT_PNDN> uptPndnNumberList = Query<OUT_PNDN>(IsChkLot).models;
                            if (Query<OUT_PNDN>(IsChkLot).models.Count == 0)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "没有未开单的PNDN!";
                                return Out_node;
                            }


                            //传入数据赋值
                            if (null != uptPndnNumberList && uptPndnNumberList.Count > 0)
                            {
                                UpdateModelListReq<OUT_PNDN> updatePndnNumber = new UpdateModelListReq<OUT_PNDN>();

                                foreach (OUT_PNDN out_Pndn in uptPndnNumberList)
                                {
                                    if (out_Pndn.PndnStatus=="N")
                                    {
                                        string s_requestname = out_Pndn.LotId + "-" + out_Pndn.InspectType + "-" + out_Pndn.DefectCode;

                                        //获取PNDN Number
                                        string PndnNumber = string.Empty;
                                        try
                                        {
                                            PndnNumber = GetPndnNumber(s_requestname, out_Pndn.UserId, out_Pndn.DefectCode);
                                            out_Pndn.PndnNo = PndnNumber;
                                            out_Pndn.PndnStatus = "Y";
                                            out_Pndn.PndnErr = "Send Success";
                                        Console.WriteLine(out_Pndn.TransSeq);
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine(e);
                                            out_Pndn.PndnStatus = "N";
                                            out_Pndn.PndnErr = e.ToString();

                                        }
                                        out_Pndn.UpdateUserId = In_node.model.PndnList[0].UserId;
                                        out_Pndn.UpdateTime = GetSysTime();

                                        updatePndnNumber.models.Add(out_Pndn);
                                        updatePndnNumber.operateType = OperateType.Update;
                                    }

                                }

                                ModelListRsp<OUT_PNDN> backInfo = new ModelListRsp<OUT_PNDN>();//定义数据库操作新增动作传入结构
                                OUT_PNDN t_OUT_PNDN = new OUT_PNDN();

                                UpdateModels<OUT_PNDN>(updatePndnNumber, backInfo,true);
                                Out_node.model.PndnList = backInfo.models;


                                if (!backInfo._success)
                                {
                                    Out_node._success = false;
                                    Out_node._ErrorMsg = Out_node._ErrorMsg + "  " + backInfo._ErrorMsg;
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
                }


                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                AddCondition(PageQueryReq, GetParaName<OUT_PNDN>(p => p.LotId), In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                AddCondition(PageQueryReq, GetParaName<OUT_PNDN>(p => p.PndnStatus), "N", LogicCondition.AndAlso, CompareType.Equal);

                var ChkPndnSts = PageQuery<OUT_PNDN>(PageQueryReq);
                
                PageQueryReq=new PageQueryReq();
                AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                var LotstsInfo = PageQuery<ISPLOTSTS>(PageQueryReq);
        

            if (ChkPndnSts.models.Count>0)
                {
                    //有PNDN未开成功，不更新Lot状态
                }
                else
                {


                    UpdateModelListReq<ISPLOTSTS> LOTSTS_Save = new UpdateModelListReq<ISPLOTSTS>(); //定义数据库操作新增动作传入结构
                    ModelListRsp<ISPLOTSTS> LOTSTS_Message = new ModelListRsp<ISPLOTSTS>(); //定义数据库操作新增动作输出结构
                    ISPLOTSTS T_ISPLOTSTS = new ISPLOTSTS(); //定义临时表结构
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            T_ISPLOTSTS.LotId = LotstsInfo.models[0].LotId;
                            T_ISPLOTSTS.TransSeq = LotstsInfo.models[0].TransSeq;
                            T_ISPLOTSTS.InspectResult = IspResult.Pndn;                        
                            T_ISPLOTSTS.Status = LotSts.IspOut;
                            T_ISPLOTSTS.UpdateTime = GetSysTime();
                            T_ISPLOTSTS.UpdateUserId = In_node.model.PndnList[0].UserId;
                            LOTSTS_Save.operateType = OperateType.Update;
                            LOTSTS_Save.models.Add(T_ISPLOTSTS);

                            UpdateModels(LOTSTS_Save, LOTSTS_Message, true);

                            SaveISPLotHistory("PNDNSubmit", In_node.model.PndnList[0].UserId, LOTSTS_Message);

                            break;

                        case '2':
                            // TODO
                            break;
                        case '3':
                            // TODO
                            break;
                    }
                }



                Out_node._success = true;
                Out_node._MsgCode = "Program Success.";
                return Out_node;
            
        }

        public static string  GetPndnNumber(string s_requestName, string s_userid, string s_defectCode)
        {
            using (WorkflowServicePortTypeClient client = new WorkflowServicePortTypeClient())
            {

                string strUserID = client.getUserId("LoginId", s_userid);
                int userID;

                //getUserId方法参数未知，写死strUserID Debug
               // strUserID = "602";

                if (int.TryParse(strUserID, out userID) == false)
                {
                    throw new Exception("Can not get user ID!");
                }

                WorkflowRequestInfo workflowRequestInfo = new WorkflowRequestInfo();
                workflowRequestInfo.canEdit = true;
                workflowRequestInfo.canView = true;
                workflowRequestInfo.requestName = s_requestName;//"OQAService-Date-001"; //请求标题
                workflowRequestInfo.requestLevel = "0"; //请求重要级别

                workflowRequestInfo.creatorId = strUserID;// "E100835";
                //workflowRequestInfo.creatorName = "徐涛";


                WorkflowBaseInfo workflowBaseInfo = new WorkflowBaseInfo();
                workflowBaseInfo.workflowId = "181"; //流程ID
                workflowBaseInfo.workflowName = "Test"; //流程名称
                // workflowBaseInfo.setWorkflowTypeId("1951");//流程类型id
                workflowBaseInfo.workflowTypeName = "Test"; //流程类型 名称
                workflowRequestInfo.workflowBaseInfo = workflowBaseInfo; //工作流 信息

                /****************main table start*************/
                WorkflowMainTableInfo workflowMainTableInfo = new WorkflowMainTableInfo(); //主表
                workflowMainTableInfo.requestRecords = new List<WorkflowRequestTableRecord>(); //主表字段只有一条记录
                WorkflowRequestTableRecord tmpTableRecord = new WorkflowRequestTableRecord();
                tmpTableRecord.workflowRequestTableFields = new List<WorkflowRequestTableField>(); //主的1个字段

                WorkflowRequestTableField tmpField = new WorkflowRequestTableField();
                tmpField.fieldName = "DefectCode"; //栏位名
                tmpField.fieldValue = s_defectCode;//"115"; //栏位值
                tmpField.edit = true;
                tmpField.view = true;
                tmpTableRecord.workflowRequestTableFields.Add(tmpField);
                workflowMainTableInfo.requestRecords.Add(tmpTableRecord);

                workflowRequestInfo.workflowMainTableInfo = workflowMainTableInfo;


                var strRequestID = client.doCreateWorkflowRequest(workflowRequestInfo, userID);

                int requestID;

                if (int.TryParse(strRequestID, out requestID) == false)
                {
                    throw new Exception("Unknown Exception when create workflow!");
                }
                else
                {
                    if (requestID < 0)
                    {
                        switch (requestID)
                        {
                            case -1:
                                throw new Exception("创建流程失败!");
                            case -2:
                                throw new Exception("没有创建权限!"); 
                            case -3:
                                throw new Exception("创建流程失败!");
                            case -4:
                                throw new Exception("字段或表名不正!");
                            case -5:
                                throw new Exception("更新流程级别失败!");
                            case -6:
                                throw new Exception("无法创建流程待办任!");
                            case -7:
                                throw new Exception("流程下一节点出错，请检查流程的配置，在OA中发起流程进行测试!");
                            case -8:
                                throw new Exception("流程节点自动赋值操作错误!");
                            default:
                                throw new Exception("Unknown Exception when create workflow!");

                        }
                    }
                }

                var flow = client.getWorkflowRequest(requestID, userID, 0);
                if (flow == null)
                {

                    throw new Exception("创建流程失败!");
                }

                string fieldValue;



                if (GetWorkFlowFieldValue("PNDNNumber", flow, out fieldValue) == false)
                {
                    throw new Exception("创建流程失败!");
                }

                return fieldValue;
            }

            
        }

        
        private static bool GetWorkFlowFieldValue(string field, WorkflowRequestInfo reqFlow, out string value)
        {
            try
            {
                value = reqFlow.workflowMainTableInfo.requestRecords[0].workflowRequestTableFields
                    .FirstOrDefault(p => p.fieldName == field)?.fieldValue;
                return true;
            }
            catch (Exception ex)
            {
                value = ex.Message;
                return false;
            }

        }


    }
        
        

        

    
}
