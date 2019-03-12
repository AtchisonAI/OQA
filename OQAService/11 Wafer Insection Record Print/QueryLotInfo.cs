using OQAService.Contract;
using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<WaferInspectRecordView> QueryLotInfo(ModelRsp<WaferInspectRecordView> LOTView)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<WaferInspectRecordView> In_node = new ModelRsp<WaferInspectRecordView>();
                ModelRsp<WaferInspectRecordView> Out_node = new ModelRsp<WaferInspectRecordView>();
                WaferInspectRecordView out_list = new WaferInspectRecordView();

                In_node.model = LOTView.model;

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


                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_LOTID.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), In_node.model.IN_LOTID.Trim(), LogicCondition.AndAlso,CompareType.Equal);
                            }
                            //if (In_node.model.IN_ISP_CODE.Trim().Equals("") == false)
                            //{
                            //    AddCondition(PageQueryReq, GetParaName<ISPDFTDEF>(p => p.DefectCode), In_node.model.IN_ISP_CODE.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            //}
                                                        
                            AddSortCondition(PageQueryReq, GetParaName <ISPLOTSTS> (p=>p.LotId), SortType.ASC);
                         

                            var data = PageQuery<ISPLOTSTS>(PageQueryReq);
                            out_list.LOT_list = data.models;
                            Out_node.model = out_list;

                            break;

                        case '2':

                            //if (In_node.model.in_isp_code.Trim().Equals("") == true)
                            //{
                            //    Out_node._success = false;
                            //    Out_node._ErrorMsg = "IN_ISP_CODE is null!";
                            //    return Out_node;
                            //}
                            //if (In_node.model.in_isp_type.Trim().Equals("") == true)
                            //{
                            //    Out_node._success = false;
                            //    Out_node._ErrorMsg = "IN_ISP_TYPE is null!";
                            //    return Out_node;
                            //}
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
                ModelRsp<WaferInspectRecordView> Out_node = new ModelRsp<WaferInspectRecordView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
