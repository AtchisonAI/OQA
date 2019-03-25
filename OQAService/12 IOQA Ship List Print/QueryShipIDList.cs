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
        public ModelRsp<ShipIDListView> QueryShipIDList(ModelRsp<ShipIDListView> ShipID)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };

                ModelRsp<ShipIDListView> In_node = new ModelRsp<ShipIDListView>();
                ModelRsp<ShipIDListView> Out_node = new ModelRsp<ShipIDListView>();
                ShipIDListView out_list = new ShipIDListView();

                In_node.model = ShipID.model;

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
                            //if (In_node.model.IN_SHIP_NO.Trim().Equals("") == false)
                            //{
                                AddCondition(PageQueryReq, GetParaName<PKGSHPSTS>(p=>p.ShipId), null, LogicCondition.AndAlso,CompareType.NotEqual);
                            // }

                            //AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.Status), "PackageOut", LogicCondition.AndAlso, CompareType.Equal);

                            AddSortCondition(PageQueryReq, GetParaName <PKGSHPSTS> (p=>p.ShipId), SortType.ASC);
                            
                            var data = PageQuery<PKGSHPSTS>(PageQueryReq);

                            Out_node.model.SHIPIDLIST_list = data.models;

                            break;

                        case '2':
                            List<object[]> SEARCHBYDATE = new List<object[]>();
                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_SEARCHBYDATE_NO.Trim().Equals("") == false)
                            {
                                //AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), In_node.model.IN_SEARCHLOTID_NO.Trim(), LogicCondition.AndAlso, CompareType.Include);
                                string sql = string.Format(@"select B.SHIP_ID from PKGSHPSTS B where B.SHIP_ID  like ('%{0}%')", In_node.model.IN_SEARCHBYDATE_NO.Trim());
                                SEARCHBYDATE = QueryRawSql(sql);
                            }
                            //  AddSortCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), SortType.ASC);

                            out_list.SEARCHshipID_list = SEARCHBYDATE;
                            Out_node.model = out_list;

                            break;

                        case '3':
                            List<object[]> dataSearch = new List<object[]>();
                            PageQueryReq.CurrentPage = 1;
                            PageQueryReq.ItemsPerPage = 200;
                            if (In_node.model.IN_SEARCHSHIP_NO.Trim().Equals("") == false)
                            {
                                //AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), In_node.model.IN_SEARCHLOTID_NO.Trim(), LogicCondition.AndAlso, CompareType.Include);
                                string sql = string.Format(@"select B.SHIP_ID from PKGSHPDAT B where B.LOT_ID  like ('%{0}%')", In_node.model.IN_SEARCHSHIP_NO.Trim());
                                dataSearch = QueryRawSql(sql);
                            }
                            //  AddSortCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), SortType.ASC);

                            out_list.SEARCHshipID_list = dataSearch;
                            Out_node.model = out_list;

                            break;

                    }
                    
                }

                Out_node._success = true;
                Out_node._MsgCode = "Program Success.";
                return Out_node;
            }
            catch (Exception ex)
            {
                ModelRsp<ShipIDListView> Out_node = new ModelRsp<ShipIDListView>();
                Out_node._success = false;
                Out_node._ErrorMsg = ex.Message.ToString();

                return Out_node;
            }
        }
    }
}
