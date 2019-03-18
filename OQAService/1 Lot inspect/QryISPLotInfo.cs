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
        public ModelRsp<IspLot> QryISPLotInfo(ModelRsp<IspLot> IspLot)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq QueryLotReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                PageQueryReq QueryWaferReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                PageQueryReq QueryAOIReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                PageQueryReq QueryMACReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                PageQueryReq QueryMIRReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<IspLot> In_node = new ModelRsp<IspLot>();
                ModelRsp<IspLot> Out_node = new ModelRsp<IspLot>();

                In_node.model = IspLot.model;

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
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                        case '1':
                            //验证业务级输入参数

                            //Lot Query
                            QueryLotReq.CurrentPage = 1;
                            QueryLotReq.ItemsPerPage = 200;
                            if (In_node.model.C_LOT_ID.Trim().Equals("") == false)
                            {
                                AddCondition(QueryLotReq, GetParaName<ISPLOTSTS>(p => p.LotId), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (In_node.model.C_FOUP_ID.Trim().Equals("") == false)
                            {
                                AddCondition(QueryLotReq, GetParaName<ISPLOTSTS>(p => p.FoupId), In_node.model.C_FOUP_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }

                            AddCondition(QueryLotReq, GetParaName<ISPLOTSTS>(p => p.Status), ISPStatus.Create, LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(QueryLotReq, GetParaName <ISPLOTSTS> (p=>p.LotId), SortType.ASC);
                            
                            var lot = PageQuery<ISPLOTSTS>(QueryLotReq);

                            Out_node.model.ISPLOTSTS_LIST = lot.models;



                            break;

                        case '2':
                            if (In_node.model.C_LOT_ID.Equals("") == true)
                            {
                                Out_node._success = false;
                                Out_node._ErrorMsg = "Lot ID is null!";
                                return Out_node;
                            }
                            //slot Query
                            QueryWaferReq.CurrentPage = 1;
                            QueryWaferReq.ItemsPerPage = 200;

                            AddCondition(QueryWaferReq, GetParaName<ISPWAFST>(p => p.LotId), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(QueryWaferReq, GetParaName<ISPWAFST>(p => p.LotId), SortType.ASC);

                            var wafer = PageQuery<ISPWAFST>(QueryWaferReq);

                            Out_node.model.ISPWAFSTS_LIST = wafer.models;
                            //AOI Item Query
                            QueryAOIReq.CurrentPage = 1;
                            QueryAOIReq.ItemsPerPage = 200;

                            AddCondition(QueryAOIReq, GetParaName<ISPWAFITM>(p => p.LotId), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);

                            AddCondition(QueryAOIReq, GetParaName<ISPWAFITM>(p => p.InspectType), IspType.AOI, LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(QueryAOIReq, GetParaName<ISPWAFITM>(p => p.LotId), SortType.ASC);

                            var aoi = PageQuery<ISPWAFITM>(QueryAOIReq);

                            Out_node.model.AOI_LIST = aoi.models;

                            //MACRO Item Query
                            QueryMACReq.CurrentPage = 1;
                            QueryMACReq.ItemsPerPage = 200;

                            AddCondition(QueryMACReq, GetParaName<ISPWAFITM>(p => p.LotId), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);

                            AddCondition(QueryMACReq, GetParaName<ISPWAFITM>(p => p.InspectType), IspType.MACRO, LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(QueryMACReq, GetParaName<ISPWAFITM>(p => p.LotId), SortType.ASC);

                            var mac = PageQuery<ISPWAFITM>(QueryMACReq);

                            Out_node.model.MAC_LIST = mac.models;

                            //AOI Item Query
                            QueryMIRReq.CurrentPage = 1;
                            QueryMIRReq.ItemsPerPage = 200;

                            AddCondition(QueryMIRReq, GetParaName<ISPWAFITM>(p => p.LotId), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);

                            AddCondition(QueryMIRReq, GetParaName<ISPWAFITM>(p => p.InspectType), IspType.MIRCRO, LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(QueryMIRReq, GetParaName<ISPWAFITM>(p => p.LotId), SortType.ASC);

                            var mir = PageQuery<ISPWAFITM>(QueryMIRReq);

                            Out_node.model.MIR_LIST = mir.models;



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
                ModelRsp<IspLot> Out_node = new ModelRsp<IspLot>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}