using System.ServiceModel;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Contract
{
    [ServiceContract]
    public interface IOQAContract
    {
        #region Emp
        [OperationContract]
        PageModelRsp<Emp> QueryEmpInfo(QueryEmpReq queryEmpReq);

        [OperationContract]
        ModelListRsp<CEmpPercentView> QueryEmpPercent(QueryReq queryReq);

        [OperationContract]
        ModelListRsp<CEmpSumView> QueryEmpSum(QueryReq queryReq);

        [OperationContract]
        ModelListRsp<Emp> UpdateEmpInfo(UpdateModelListReq<Emp> updateReq);

        [OperationContract]
        ModelRsp<DemoView> UpdateDemoInfo(UpdateModelReq<DemoView> updateReq);
        #endregion

        #region  Defect code set
        [OperationContract]
        ModelRsp<DefectCodeView> QueryDefectCodeInfo(ModelRsp<DefectCodeView> DefectCodeView);


        #endregion

        #region AOI
        ModelRsp<AOIInputView> QueryAOIInfo(PageQueryReq queryReq);
        //AOIInputView
        void SaveOrUpdateModel(UpdateModelReq<AOIShowView> updateReq);
        #endregion



    }
}