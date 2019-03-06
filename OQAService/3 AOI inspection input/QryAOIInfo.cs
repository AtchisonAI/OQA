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
        public ModelRsp<AOIShowView> QueryAOIInfo(AOIShowView queryReq)
        {

            //定义服务过程中使用的结构
            PageQueryReq PageQueryReq = new PageQueryReq()
            {
                queryConditionList = new List<QueryCondition>(),
                sortCondittionList = new List<SortCondition>()
            };
            ModelRsp<AOIShowView> qryResult = new ModelRsp<AOIShowView>();
            try
            {
                if (!qryResult.model.ISPWAFITM.LotId.Trim().Equals(""))
                {
                    AddCondition(PageQueryReq, "Lot_id", queryReq.ISPWAFITM.LotId.Trim(), LogicCondition.AndAlso);
                }
                if (!qryResult.model.ISPWAFITM.SlotId.Trim().Equals(""))
                {
                    AddCondition(PageQueryReq, "Slot_id", queryReq.ISPWAFITM.SlotId.Trim(), LogicCondition.AndAlso);
                }
                if (!qryResult.model.ISPWAFITM.WaferId.Trim().Equals(""))
                {
                    AddCondition(PageQueryReq, "Wafer_id", queryReq.ISPWAFITM.WaferId.Trim(), LogicCondition.AndAlso);
                }
                if (!qryResult.model.ISPWAFITM.InspectType.Trim().Equals(""))
                {
                    AddCondition(PageQueryReq, "Inspect_type", queryReq.ISPWAFITM.InspectType.Trim(), LogicCondition.AndAlso);
                }
                if (!qryResult.model.ISPWAFITM.SideType.Trim().Equals(""))
                {
                    AddCondition(PageQueryReq, "Side_type", queryReq.ISPWAFITM.SideType.Trim(), LogicCondition.AndAlso);
                }
                AddSortCondition(PageQueryReq, "Inspect_type", SortType.ASC);
                qryResult.model.ISPWAFITM = IListToList<ISPWAFITM>(PageQuery<ISPWAFITM>(PageQueryReq).models)[0];
                qryResult.model.ISPWAFDFT_list = IListToList< ISPWAFDFT >(Query<ISPWAFDFT>(PageQueryReq).models);
                qryResult.model.ISPIMGDEF_list = IListToList<ISPIMGDEF>(Query<ISPIMGDEF>(PageQueryReq).models);
                qryResult._success = true;

            }
            catch(Exception ex)
            {
                qryResult._success = false;
                qryResult._ErrorMsg = ex.Message.ToString();
            }
            return qryResult;
        }

        public  void SaveOrUpdateModel(UpdateModelReq<AOIShowView> updateReq)
        {
    

            BeginTrans();
            UpdateModelReq<ISPWAFITM> WAFITM = new UpdateModelReq<ISPWAFITM>()
            {
                model = updateReq.model.ISPWAFITM,
                opreateType = updateReq.opreateType
            };

            UpdateModel<ISPWAFITM>(WAFITM);

            UpdateModelListReq<ISPWAFDFT> WAFDFT = new UpdateModelListReq<ISPWAFDFT>()
            {
                models = updateReq.model.ISPWAFDFT_list,
                opreateType = updateReq.opreateType
            };
            UpdateModelObjects(WAFDFT);

            UpdateModelListReq<ISPIMGDEF> IMGDEF = new UpdateModelListReq<ISPIMGDEF>()
            {
                models = updateReq.model.ISPIMGDEF_list,
                opreateType = updateReq.opreateType
            };
            UpdateModelObjects(IMGDEF);
            EndTrans();
        }

    }
    
}
