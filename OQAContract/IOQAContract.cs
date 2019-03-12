﻿using System.ServiceModel;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAContract
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
        //关于Defect Code Set 的查询服务
        [OperationContract]
        ModelRsp<DefectCodeView> QueryDefectCodeInfo(ModelRsp<DefectCodeView> DefectCodeView);
        //Defect Code Set 的数据保存修改服务
        [OperationContract]
        ModelRsp<DefectCodeSave> CreateDefectCodeInfo(ModelRsp<DefectCodeSave> DefectCode);

        #endregion

        #region AOI
        [OperationContract]
        ModelRsp<AOIShowView> QueryAOIInfo(ModelRsp<AOIShowView> queryReq);
        //AOIInputView
        [OperationContract]
        ModelRsp<AOIShowView> CreateOrUpdateAOI(UpdateModelReq<AOIShowView> updateReq);
        #endregion

        #region  Lot Transfer

        ModelRsp<LotIDListView> QueryLotList(ModelRsp<LotIDListView> PKGShip);

        #endregion

        #region  Foup Change
        //关于Foup Change 的查询服务
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotIspSlotidInfo(ModelRsp<LotSlotidView> LotSlotidView);
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotMesSlotidInfo(ModelRsp<LotSlotidView> LotSlotidView);
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotIspStsInfo(ModelRsp<LotSlotidView> LotSlotidView);
        #endregion

        #region  Package Info
        [OperationContract]
        ModelRsp<PKGShipView> QryPKGShipInfo(ModelRsp<PKGShipView> PKGShip);

        #endregion

        #region  Image Save
        [OperationContract]
        ModelRsp<ImageSave> SaveImageInfo(ModelRsp<ImageSave> ImageSave);

         #endregion



        #region  WaferInspectRecord
        ModelRsp<WaferInspectRecordView> QueryLotInfo(ModelRsp<WaferInspectRecordView> LOTView);

        ModelRsp<WaferInspectRecordView> QueryWaferInspectionRecordInfo(
            ModelRsp<WaferInspectRecordView> WaferInspectRecord);

        #endregion
    }
}