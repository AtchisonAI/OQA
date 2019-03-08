using OQAService.Contract;
using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.MESDB.FWTST1;
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
                                AddCondition(PageQueryReq, "Inspect_type", In_node.model.in_isp_type.Trim(), LogicCondition.AndAlso);
                            }
                            if (In_node.model.in_isp_code.Trim().Equals("") == false)
                            {
                                AddCondition(PageQueryReq, "Defect_code", In_node.model.in_isp_code.Trim(), LogicCondition.AndAlso);
                            }
                                                        
                            AddSortCondition(PageQueryReq, "Inspect_type", SortType.ASC);
                         

                            var data = PageQuery<ISPDFTDEF>(PageQueryReq);

                            Out_node.model.ISPDFTDEF_list = IListToList<ISPDFTDEF>(data.models);

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


        public List<T> IListToList<T>(IList<T> list)
        {
            T[] array = new T[list.Count];
            list.CopyTo(array, 0);
            return new List<T>(array);
        }
    }

}
