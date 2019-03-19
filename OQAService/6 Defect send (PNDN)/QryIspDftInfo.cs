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
        public ModelRsp<IspWafDftView> QryIspDftInfo(ModelRsp<IspWafDftView> IspWafDftView)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<IspWafDftView> In_node = new ModelRsp<IspWafDftView>();
                ModelRsp<IspWafDftView> Out_node = new ModelRsp<IspWafDftView>();
                IspWafDftView out_list = new IspWafDftView();

                In_node.model = IspWafDftView.model;

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
                           
                            if (In_node.model.IN_LOTID.Trim().Equals("") == false)
                            {
                                // AddCondition(PageQueryReq, GetParaName<PKGLabel>(p => p.LotId), In_node.model.IN_LOTID.Trim(), LogicCondition.AndAlso,CompareType.Equal);
                                string sql = string.Format(@"select t.lot_id,
                                                                   t.inspect_type,
                                                                   t.defect_code,
                                                                   listagg(t.slot_id, ', ') within
                                                             group(
                                                             order by t.lot_id) slot_id
                                                              from (SELECT distinct d.lot_id, d.inspect_type, d.defect_code, d.slot_id
                                                                      FROM ispwafdft d
                                                                     WHERE d.lot_id = '{0}') t
                                                             group by t.lot_id, t.inspect_type, t.defect_code
                                                            ", In_node.model.IN_LOTID.Trim());
                                
                                data = QueryRawSql(sql);
                            }
                            
                            out_list.Ispwafdft_list = data;
                            Out_node.model = out_list;


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
                ModelRsp<IspWafDftView> Out_node = new ModelRsp<IspWafDftView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
