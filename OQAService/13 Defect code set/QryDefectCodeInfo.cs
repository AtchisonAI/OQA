using OQAService.Contract;
using System;
using System.Collections.Generic;
using WCFModels;
using Utils;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<DefectCodeView> QueryDefectCodeInfo(ModelRsp<DefectCodeView> DefectCode)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<DefectCodeView> In_node = new ModelRsp<DefectCodeView>();
                ModelRsp<DefectCodeView> Out_node = new ModelRsp<DefectCodeView>();

                In_node.model = DefectCode.model;

                //验证系统级别输入参数

                if (In_node.model.c_proc_step.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_PROC_STEP is null!";
                    return Out_node;

                }
                if (In_node.model.c_tran_flag.Equals("") == true)
                {
                    Out_node._success = false;
                    Out_node._ErrorMsg = "C_TRAN_FLAG is null!";
                    return Out_node;

                }

                if (In_node.model.c_proc_step == GlobalConstant.TRAN_VIEW)
                {
                    //业务逻辑选择
                    switch (In_node.model.c_tran_flag)
                    {
                        case '1':
                            //验证业务级输入参数


                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.in_isp_type.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, GetParaName< ISPDFTDEF >(p=>p.InspectType), In_node.model.in_isp_type.Trim(), LogicCondition.AndAlso,CompareType.Equal);
                            }
                            if (In_node.model.in_isp_code.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPDFTDEF>(p => p.DefectCode), In_node.model.in_isp_code.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                                                        
                            AddSortCondition(PageQueryReq, GetParaName < ISPDFTDEF > (p=>p.InspectType), SortType.ASC);
                         

                            var data = PageQuery<ISPDFTDEF>(PageQueryReq);

                            Out_node.model.ISPDFTDEF_list = data.models;

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
                ModelRsp<DefectCodeView> Out_node = new ModelRsp<DefectCodeView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
