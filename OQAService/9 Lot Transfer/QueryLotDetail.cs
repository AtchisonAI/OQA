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
        public ModelRsp<QueryLotDetailView> QueryLotDetail(ModelRsp<QueryLotDetailView> PKGShip)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<QueryLotDetailView> In_node = new ModelRsp<QueryLotDetailView>();
                ModelRsp<QueryLotDetailView> Out_node = new ModelRsp<QueryLotDetailView>();
                QueryLotDetailView out_list = new QueryLotDetailView();
                
                In_node.model = PKGShip.model;

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

                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_MASTERLOT_NO.Trim().Equals("") == false)
                            {
                                //AddCondition(PageQueryReq, GetParaName<PKGSHPDAT>(p => p.LotId), In_node.model.IN_MASTERLOT_NO.Trim(), LogicCondition.AndAlso,CompareType.Include);
                                string sql = string.Format(@"select LOT_ID,QTY,PART_ID,INSPECT_RESULT,TRANS_SEQ from isplotsts WHERE LOT_ID IN ({0})", In_node.model.IN_MASTERLOT_NO.Trim());
                                data = QueryRawSql(sql);
                            }
                            
                            out_list.PKGSHPDAT_list = data;
                            Out_node.model = out_list;
                            //   AddSortCondition(PageQueryReq, GetParaName <PKGSHPDAT> (p=>p.LotId), SortType.ASC);

                            //   var data = PageQuery<PKGSHPDAT>(PageQueryReq);
                            //   out_list.PKGSHPDAT_list = data.models;
                            //    Out_node.model = out_list;
                            break;

                        case '2':
                            List<object[]> dataS = new List<object[]>();

                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_MASTERLOT_NO.Trim().Equals("") == false)
                            {
                                //AddCondition(PageQueryReq, GetParaName<PKGSHPDAT>(p => p.LotId), In_node.model.IN_MASTERLOT_NO.Trim(), LogicCondition.AndAlso,CompareType.Include);
                                string sql = string.Format(@"select COUNT(DISTINCT PART_ID)  from isplotsts WHERE LOT_ID IN ({0})", In_node.model.IN_MASTERLOT_NO.Trim());
                                dataS = QueryRawSql(sql);
                            }

                            out_list.PKGSHPDAT_list = dataS;
                            Out_node.model = out_list;

                            //   AddSortCondition(PageQueryReq, GetParaName <PKGSHPDAT> (p=>p.LotId), SortType.ASC);

                            //   var data = PageQuery<PKGSHPDAT>(PageQueryReq);
                            //   out_list.PKGSHPDAT_list = data.models;
                            //    Out_node.model = out_list;
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
                ModelRsp<QueryLotDetailView> Out_node = new ModelRsp<QueryLotDetailView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
