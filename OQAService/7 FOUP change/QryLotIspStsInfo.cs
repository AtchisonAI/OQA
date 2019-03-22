﻿using OQAContract;
using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;


namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotSlotidView> QryLotIspStsInfo(ModelRsp<LotSlotidView> LotIspStsInfo)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<LotSlotidView> In_node = new ModelRsp<LotSlotidView>();
                ModelRsp<LotSlotidView> Out_node = new ModelRsp<LotSlotidView>();

                In_node.model = LotIspStsInfo.model;

              


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

                if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_VIEW)
                {
                    var data = new PageModelRsp<ISPLOTSTS>();
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数


                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;


                            if (In_node.model.IN_LOT_ID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOT_ID is null!";
                                return Out_node;
                            }

                            AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId),In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.InspectResult), IspResult.Pass,LogicCondition.AndAlso, CompareType.Equal);
                            AddSortCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), SortType.ASC);
                            data = PageQuery<ISPLOTSTS>(PageQueryReq);

                            Out_node.model.ISPLOTSTS_list = data.models;
                            if (Out_node.model.ISPLOTSTS_list.Count == 0)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "Lot Inspect Result Error,lotid is not found!";
                                return Out_node;
                            }

                            break;

                        case '2':
                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;


                            if (In_node.model.IN_LOT_ID.Trim().Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "IN_LOT_ID is null!";
                                return Out_node;

                            }

                            AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId),In_node.model.IN_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.InspectResult), IspResult.Hold,LogicCondition.AndAlso, CompareType.Equal);
                            AddSortCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), SortType.ASC);
                            data = PageQuery<ISPLOTSTS>(PageQueryReq);

                            Out_node.model.ISPLOTSTS_list = data.models;
                            if (Out_node.model.ISPLOTSTS_list.Count == 0)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "Lot Inspect Result Error,lotid is not found!";
                                return Out_node;
                            }

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
