using System;
using System.Collections.Generic;
using OQAContract;
using WCFModels;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public ModelRsp<LotstsInfoView> QuerySlotstsInfo(ModelRsp<LotstsInfoView> queryInfoReq)
        {
            try
            {
                //定义服务过程中使用的结构
                PageQueryReq PageQueryReq = new PageQueryReq()
                {
                    queryConditionList = new List<QueryCondition>(),
                    sortCondittionList = new List<SortCondition>()
                };
                ModelRsp<LotstsInfoView> Qry_in = new ModelRsp<LotstsInfoView>();
                ModelRsp<LotstsInfoView> Qry_out = new ModelRsp<LotstsInfoView>();
                Qry_in.model = queryInfoReq.model;
                Qry_out.model = new LotstsInfoView();
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
                            if (null != Qry_in.model.ISPLOTSTS.LotId && !Qry_in.model.ISPLOTSTS.LotId.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.LotId), Qry_in.model.ISPLOTSTS.LotId.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            if (null != Qry_in.model.ISPLOTSTS.Status && !Qry_in.model.ISPLOTSTS.Status.Trim().Equals(""))
                            {
                                AddCondition(PageQueryReq, GetParaName<ISPLOTSTS>(p => p.Status), Qry_in.model.ISPLOTSTS.Status.Trim(), LogicCondition.AndAlso, CompareType.Equal);
                            }
                            ModelListRsp<ISPLOTSTS> resultModel = Query<ISPLOTSTS>(PageQueryReq);
                            if (null != resultModel && null != resultModel.models && resultModel.models.Count>0)
                            {
                                Qry_out.model.ISPLOTSTS = resultModel.models[0];
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
                ModelRsp<LotstsInfoView> Qry_out = new ModelRsp<LotstsInfoView>();
                Qry_out._success = false;
                Qry_out._ErrorMsg = ex.Message.ToString();
                return Qry_out;
            }

        }


    }

}
