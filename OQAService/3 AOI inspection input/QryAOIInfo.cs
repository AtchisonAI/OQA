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
        public ModelRsp<AOIShowView> QueryAOIInfo(ModelRsp<AOIShowView> queryInfoReq)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                ModelRsp<AOIShowView> Qry_in = new ModelRsp<AOIShowView>();
                ModelRsp<AOIShowView> Qry_out = new ModelRsp<AOIShowView>();
                Qry_in.model = queryInfoReq.model;
                Qry_out.model = new AOIShowView();
                Boolean flag = true;
                if (!Qry_in.model.QryAllFlag)
                {
                    flag = false;
                }
                //验证系统级别输入参数
                if (Qry_in.model.C_PROC_STEP.Equals("") == true)
                {
                    Qry_out._success = false;
                    Qry_out._ErrorMsg = "C_PROC_STEP is null!";
                    return Qry_out;

                }
                if (Qry_in.model.C_TRAN_FLAG.Equals("") == true)
                {
                    Qry_out._success = false;
                    Qry_out._ErrorMsg = "C_TRAN_FLAG is null!";
                    return Qry_out;

                }

                if (Qry_in.model.C_TRAN_FLAG == GlobalConstant.TRAN_VIEW)
                {
                    //业务逻辑选择
                    switch (Qry_in.model.C_PROC_STEP)
                    {
                        case '1':
                            //验证业务级输入参数
                            if (null != Qry_in.model.ISPWAFITM_list[0].LotId &&!Qry_in.model.ISPWAFITM_list[0].LotId.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPWAFITM>(p => p.LotId), Qry_in.model.ISPWAFITM_list[0].LotId.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (null!=Qry_in.model.ISPWAFITM_list[0].SlotId &&  !Qry_in.model.ISPWAFITM_list[0].SlotId.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPWAFITM>(p => p.SlotId), Qry_in.model.ISPWAFITM_list[0].SlotId.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (null != Qry_in.model.ISPWAFITM_list[0].WaferId && !Qry_in.model.ISPWAFITM_list[0].WaferId.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPWAFITM>(p => p.WaferId), Qry_in.model.ISPWAFITM_list[0].WaferId.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (null != Qry_in.model.ISPWAFITM_list[0].InspectType && !Qry_in.model.ISPWAFITM_list[0].InspectType.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPWAFITM>(p => p.InspectType), Qry_in.model.ISPWAFITM_list[0].InspectType.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (null != Qry_in.model.ISPWAFITM_list[0].SideType && !Qry_in.model.ISPWAFITM_list[0].SideType.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPWAFITM>(p => p.SideType), Qry_in.model.ISPWAFITM_list[0].SideType.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            AddSortCondition(PageQueryReq, "SlotId", SortType.ASC);
                            ModelListRsp<ISPWAFITM> wafModel = Query<ISPWAFITM>(PageQueryReq);
                            if (null != wafModel)
                            {
                                    Qry_out.model.ISPWAFITM_list = wafModel.models;
                            }
                            if (flag)
                            {
                                ModelListRsp<ISPWAFDFT> detModel = Query<ISPWAFDFT>(PageQueryReq);
                                if (null != detModel)
                                {
                                    Qry_out.model.ISPWAFDFT_list = detModel.models;
                                }
                                ModelListRsp<ISPIMGDEF> imgModel = Query<ISPIMGDEF>(PageQueryReq);
                                if (null != imgModel)
                                {
                                    Qry_out.model.ISPIMGDEF_list = imgModel.models;
                                }
                            }
                           
                            break;
                        case '2':
                            // TODO
                            break;
                        case '3':
                            // TODO

                            break;
                    }
                }

                Qry_out._success = true;
                Qry_out._MsgCode = "Program Success.";
                return Qry_out;
            }
            catch (Exception ex)
            {
                ModelRsp<AOIShowView> Qry_out = new ModelRsp<AOIShowView>();
                Qry_out._success = false;
                Qry_out._ErrorMsg = ex.Message.ToString();
                return Qry_out;
            }

        }
        

    }

}
