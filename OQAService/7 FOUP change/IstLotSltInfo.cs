using OQAContract;
using System;
using System.Collections.Generic;
using System.ServiceModel;
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
        public ModelRsp<LotSlotidSave> IstLotSltInfo(ModelRsp<LotSlotidSave> SaveMesSlotidInfo)
        {
            //try
            //{
                ////定义服务过程中使用的结构
                //PageQueryReq PageQueryReq = new PageQueryReq()
                //{
                //    queryConditionList = new List<QueryCondition>(),
                //    sortCondittionList = new List<SortCondition>()
                //};

                ModelRsp<LotSlotidSave> In_node = new ModelRsp<LotSlotidSave>();
                ModelRsp<LotSlotidSave> Out_node = new ModelRsp<LotSlotidSave>();

                UpdateModelListReq<PKGSLTDEF> Do_Save = new UpdateModelListReq<PKGSLTDEF>();//定义数据库操作新增动作传入结构
                ModelListRsp<PKGSLTDEF> Do_message = new ModelListRsp<PKGSLTDEF>();         //定义数据库操作新增动作输出结构
                PKGSLTDEF T_PKGSLTDEF = new PKGSLTDEF(); //定义临时表结构

                //传入数据赋值

                In_node.model = SaveMesSlotidInfo.model;
               


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
                                Out_node._ErrorMsg = "LOT ID is null!";
                                return Out_node;
                            }

                        QueryReq IsChkLot = new QueryReq();
                        IsChkLot.queryConditionList.Add(new QueryCondition() { paramName = "LotId", value = In_node.model.IN_LOT_ID.Trim(),compareType = CompareType.Equal});
                        if (Query<PKGSLTDEF>(IsChkLot).models.Count > 0)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = "Lot ID is checked!";
                            Out_node.model.PkgsltdefList = Query<PKGSLTDEF>(IsChkLot).models;
                            return Out_node;
                        }


                        //传入数据赋值
                        if (null != SaveMesSlotidInfo.model.PkgsltdefList && SaveMesSlotidInfo.model.PkgsltdefList.Count > 0)
                            {
                                foreach (PKGSLTDEF pkgsltdef in SaveMesSlotidInfo.model.PkgsltdefList)
                                {
                                    UpdateModelReq<PKGSLTDEF> insertpkgslt = new UpdateModelReq<PKGSLTDEF>()
                                    {
                                        model = pkgsltdef,
                                        operateType = OperateType.Insert
                                    };
                                    InitTable(pkgsltdef);
                                    ModelRsp<PKGSLTDEF> backInfo = new ModelRsp<PKGSLTDEF>();//定义数据库操作新增动作传入结构
                                    UpdateModel<PKGSLTDEF>(insertpkgslt, backInfo, true);
                                    if (!backInfo._success)
                                    {
                                        Out_node._success = false;
                                        Out_node._ErrorMsg = Out_node._ErrorMsg + "  " + backInfo._ErrorMsg;
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
                }

                Out_node._success = true;
                Out_node._MsgCode = "Program Success.";
                return Out_node;
            //}
            //catch (Exception ex)
            //{
            //    ModelRsp<LotSlotidSave> Out_node = new ModelRsp<LotSlotidSave>();
            //    Out_node._success = false;
            //    Out_node._ErrorMsg = ex.Message.ToString();

            //    return Out_node;
            //}
        }
    }
}
