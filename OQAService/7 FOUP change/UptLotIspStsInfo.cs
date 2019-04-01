using OQAContract;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;


namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<LotSlotidView> UptLotIspStsInfo(ModelRsp<LotSlotidView> UptLotIspStsInfo)
        {
            try
            {
              
                ModelRsp<LotSlotidView> In_node = new ModelRsp<LotSlotidView>();
                ModelRsp<LotSlotidView> Out_node = new ModelRsp<LotSlotidView>();


                UpdateModelListReq<ISPLOTSTS> Do_Save = new UpdateModelListReq<ISPLOTSTS>();//定义数据库操作新增动作传入结构
                ModelListRsp<ISPLOTSTS> Do_message = new ModelListRsp<ISPLOTSTS>();         //定义数据库操作新增动作输出结构
                ISPLOTSTS T_ISPLOTSTS = new ISPLOTSTS(); //定义临时表结构


                In_node.model = UptLotIspStsInfo.model;


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
                                Out_node._ErrorMsg = "LOT ID is null!";
                                return Out_node;
                            }

                            PageQueryReq PageQueryReq = new PageQueryReq()
                            {
                                queryConditionList = new List<QueryCondition>(),
                                sortCondittionList = new List<SortCondition>()
                            };
                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            AddCondition(PageQueryReq, GetParaName<PKGSLTDEF>(p => p.LotId), In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(PageQueryReq, GetParaName<PKGSLTDEF>(p => p.LotId), SortType.ASC);

                            var FoupChangeCount = PageQuery<PKGSLTDEF>(PageQueryReq);
                            //如果检验项目有缺陷，hold记录，并通知客户端去PNDN
                            if (FoupChangeCount.models.Count == 0)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "Please do Check first!";
                                return Out_node;

                            }

                            //更新
                            T_ISPLOTSTS.LotId =In_node.model.IN_LOT_ID;
                            T_ISPLOTSTS.TransSeq = In_node.model.D_TRANSSEQ;
                            T_ISPLOTSTS.Status = LotSts.ChangeOut;
                            T_ISPLOTSTS.Qty = FoupChangeCount.models.Count;
                            T_ISPLOTSTS.UpdateUserId = In_node.model.S_USER_ID;
                            T_ISPLOTSTS.UpdateTime = GetSysTime();

                            Do_Save.operateType = OperateType.Update;
                            Do_Save.models.Add(T_ISPLOTSTS);
                            //InitTable(T_ISPLOTSTS);
                            UpdateModels(Do_Save, Do_message, true);

                            //记录历史
                            SaveISPLotHistory(LotSts.ChangeOut, In_node.model.S_USER_ID,Do_message);

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
            catch (Exception ex)
            {
                ModelRsp<LotSlotidView> Out_node = new ModelRsp<LotSlotidView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
