using System;
using System.Collections.Generic;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;
using OQAContract;
using static WCFModels.OQA.PKGLabelPrintView;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<PKGLabelPrintView> QueryPKGLabelInfo(ModelRsp<PKGLabelPrintView> PKGLabelView)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<PKGLabelPrintView> In_node = new ModelRsp<PKGLabelPrintView>();
                ModelRsp<PKGLabelPrintView> Out_node = new ModelRsp<PKGLabelPrintView>();
                PKGLabelPrintView out_list = new PKGLabelPrintView();

                In_node.model = PKGLabelView.model;

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
                            List<object[]> data = new List<object[]>();
                           

                          //  List<PKGLabelPrintView> data = new List<PKGLabelPrintView>();

                            //    var data = new datalist();


                            //        PageQueryReq.CurrentPage = 1;
                            //        PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_LOTID.Trim().Equals("") == false)
                            {
                                // AddCondition(PageQueryReq, GetParaName<PKGLabel>(p => p.LotId), In_node.model.IN_LOTID.Trim(), LogicCondition.AndAlso,CompareType.Equal);
                                string sql = string.Format(@"select listagg(t.slot_id, ',') within
                                                 group(
                                                 order by slot_id, slot_id) as slot_id, count(t.lot_id) as qty, t.lot_id, s.part_id, s.part_desc, s.rec_user, s.customer_id, s.cust_lot_id, s.cust_part_id, s.orignal_country, s.qa_stamp
                                                  from pkgsltdef t, isplotsts s
                                                 where t.lot_id = s.lot_id and s.lot_id = '{0}'
                                                 group by t.lot_id,
                                                          s.part_id,
                                                          s.part_desc,
                                                          s.rec_user,
                                                          s.customer_id,
                                                          s.cust_lot_id,
                                                          s.cust_part_id,
                                                          s.orignal_country,
                                                          s.qa_stamp", In_node.model.IN_LOTID.Trim());
                                
                                data = QueryRawSql(sql);
                            }


                            //   AddSortCondition(PageQueryReq, GetParaName <PKGLabel> (p=>p.LotId), SortType.ASC);


                            //    var data = PageQuery<PKGLabel>(PageQueryReq);
                            //out_list.PKGLabel_list = data;

                            out_list.PKGLabel_list = data;
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
                ModelRsp<PKGLabelPrintView> Out_node = new ModelRsp<PKGLabelPrintView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
