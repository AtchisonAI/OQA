using System.ServiceModel;
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

        #region AOI & MA & MI
        [OperationContract]
        ModelRsp<AOIShowView> QueryAOIInfo(ModelRsp<AOIShowView> queryReq);
        //AOIInputView
        [OperationContract]
        ModelRsp<AOIShowView> CreateOrUpdateAOI(UpdateModelReq<AOIShowView> updateReq);
        [OperationContract]
        ModelRsp<LotstsInfoView> QuerySlotstsInfo(ModelRsp<LotstsInfoView> queryInfoReq);
        #endregion

        #region  Lot Transfer
        [OperationContract]
        ModelRsp<LotIDListView> QueryLotList(ModelRsp<LotIDListView> PKGShip);
        [OperationContract]
        ModelRsp<QueryLotDetailView> QueryLotDetail(ModelRsp<QueryLotDetailView> PKGShip);
        [OperationContract]
        ModelRsp<LotTransferSave> CreateLotTransferInfo(ModelRsp<LotTransferSave> LotTransferSave);
        [OperationContract]
        ModelRsp<LotTransferListSave> CreateLotTransferListInfo(ModelRsp<LotTransferListSave> LotTransferListSave);

        

        #endregion

        #region  Foup Change
        //关于Foup Change 的查询服务
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotIspSlotidInfo(ModelRsp<LotSlotidView> LotSlotidView);
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotMesSlotidInfo(ModelRsp<LotSlotidView> LotSlotidView);
        [OperationContract]
        ModelRsp<LotSlotidView> QryLotIspStsInfo(ModelRsp<LotSlotidView> LotSlotidView);
        [OperationContract]
        ModelRsp<LotSlotidSave> IstLotSltInfo(ModelRsp<LotSlotidSave> LotSlotidSave);
        [OperationContract]
        ModelRsp<LotSlotidView> UptLotIspStsInfo(ModelRsp<LotSlotidView> UptLotIspStsInfo);
        #endregion

        #region Dft Send Pndn

        [OperationContract]
        ModelRsp<IspWafDftView> QryIspDftInfo(ModelRsp<IspWafDftView> IspWafDftView);

        [OperationContract]
        ModelRsp<LotPndnInfoView> QryPndnInfo(ModelRsp<LotPndnInfoView> QryPndnInfo);
        [OperationContract]
        ModelRsp<LotPndnInfoSave> IstPndnInfo(ModelRsp<LotPndnInfoSave> SavePndnInfo);

        
        #endregion

        #region  IOQA Ship List Print
        [OperationContract]
        ModelRsp<PKGShipView> QryPKGShipInfo(ModelRsp<PKGShipView> PKGShip);

        [OperationContract]
        ModelRsp<PKGShipView> QryPKGShipSummaryInfo(ModelRsp<PKGShipView> PKGShipSummary);
        [OperationContract]
        ModelRsp<ShipIDListView> QueryShipIDList(ModelRsp<ShipIDListView> ShipID);

        #endregion

        #region  Image Save
        [OperationContract]
        ModelRsp<ImageSave> SaveImageInfo(ModelRsp<ImageSave> ImageSave);

        #endregion

        #region  Lot Inspect 
        [OperationContract]
        ModelRsp<IspMesLot> QryMesLotInfo(ModelRsp<IspMesLot> DefectCode);
        [OperationContract]
        ModelRsp<ISPLotSave> SaveISPLotInfo(ModelRsp<ISPLotSave> ISPLotSave);
        [OperationContract]
        ModelRsp<IspLot> QryISPLotInfo(ModelRsp<IspLot> IspLot);
        #endregion

        #region  WaferInspectRecord
        [OperationContract]
        ModelRsp<WaferInspectRecordView> QueryLotInfo(ModelRsp<WaferInspectRecordView> LOTView);
        [OperationContract]
        ModelRsp<WaferInspectRecordView> QueryWaferInspectionRecordInfo(ModelRsp<WaferInspectRecordView> WaferInspectRecord);

        #endregion

        #region  Package Label Print
        [OperationContract]
        ModelRsp<PKGLabelPrintView> QueryPKGLabelInfo(ModelRsp<PKGLabelPrintView> PKGLabelView);


        #endregion

        #region lot package
        [OperationContract]
        ModelRsp<ISPLOTSTS> QueryLotSts(LotPackageInput input);
        [OperationContract]
        ModelListRsp<ISPIMGDEF> QueryPackageImg(LotPackageInput input);
        [OperationContract]
        ModelRsp<LotPackageView> QueryLotPackageInfo(LotPackageInput input);
        [OperationContract]
        ModelRsp<ISPLOTSTS> UpdateLotSts(UpdateModelReq<ISPLOTSTS> input);
        [OperationContract]
        BaseRsp DeletePackageImg(DeletePackageImgReq input);
        #endregion

    }
}