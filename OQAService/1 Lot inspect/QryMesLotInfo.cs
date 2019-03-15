using OQAContract;
using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;


namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<IspMesLot> QryMesLotInfo(ModelRsp<IspMesLot> DefectCode)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                PageQueryReq PageQueryReq2 = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<IspMesLot> In_node = new ModelRsp<IspMesLot>();
                ModelRsp<IspMesLot> Out_node = new ModelRsp<IspMesLot>();

                In_node.model = DefectCode.model;

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

                            //MES Query
                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.C_LOT_ID.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, GetParaName<OqaMeslot>(p=>p.Lotid), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso,CompareType.Equal);
                            }
                            if (In_node.model.C_FOUP_ID.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, GetParaName<OqaMeslot>(p => p.Foupid), In_node.model.C_FOUP_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                                                        
                            AddSortCondition(PageQueryReq, GetParaName <OqaMeslot> (p=>p.Lotid), SortType.ASC);
                            
                            var data = PageQuery<OqaMeslot>(PageQueryReq);

                            Out_node.model.OQAMESLOT_LIST = data.models;
                            //slot Query
                            PageQueryReq2.CurrentPage = 1;
                            PageQueryReq2.ItemsPerPage = 200;
                            if (In_node.model.C_LOT_ID.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq2, GetParaName<OqaMeswafer>(p => p.Lotid), In_node.model.C_LOT_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (In_node.model.C_FOUP_ID.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq2, GetParaName<OqaMeswafer>(p => p.Foupid), In_node.model.C_FOUP_ID.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }

                            AddSortCondition(PageQueryReq2, GetParaName<OqaMeswafer>(p => p.Lotid), SortType.ASC);

                            var slotdata = PageQuery<OqaMeswafer>(PageQueryReq2);

                            Out_node.model.OQAMESWAFER_LIST = slotdata.models;

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
                ModelRsp<IspMesLot> Out_node = new ModelRsp<IspMesLot>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
