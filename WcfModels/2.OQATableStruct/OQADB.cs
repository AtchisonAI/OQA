using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("INITEDCDATA")]
    [ExplicitColumns]
    public partial class INITEDCDATA
    {
        [DataMember]
        [Column("IDX")] public string Idx { get; set; }
        [DataMember]
        [Column("NAME")] public string Name { get; set; }
        [DataMember]
        [Column("ALIAS")] public string Alias { get; set; }
        [DataMember]
        [Column("RULETYPE")] public string Ruletype { get; set; }
        [DataMember]
        [Column("CATEGORY")] public string Category { get; set; }
        [DataMember]
        [Column("NUMBEROFABNORMALPOINTS")] public decimal Numberofabnormalpoints { get; set; }
        [DataMember]
        [Column("NUMBEROFTARGETPOINTS")] public decimal Numberoftargetpoints { get; set; }
        [DataMember]
        [Column("SIGMA")] public string Sigma { get; set; }
        [DataMember]
        [Column("RULEOPERATOR")] public string Ruleoperator { get; set; }
        [DataMember]
        [Column("FIRSTRULE")] public string Firstrule { get; set; }
        [DataMember]
        [Column("SECONDRULE")] public string Secondrule { get; set; }
        [DataMember]
        [Column("ISINCLUDEEQUAL")] public string Isincludeequal { get; set; }
        [DataMember]
        [Column("RULEDESCRIPTION")] public string Ruledescription { get; set; }
        [DataMember]
        [Column("DESCRIPTION")] public string Description { get; set; }
        [DataMember]
        [Column("OWNER")] public string Owner { get; set; }
        [DataMember]
        [Column("LASTUPDATEUSER")] public string Lastupdateuser { get; set; }
    }

    [DataContract]
    [TableName("INVENTORY")]
    [ExplicitColumns]
    public partial class INVENTORY
    {
        [DataMember]
        [Column("ITEM")] public string Item { get; set; }
        [DataMember]
        [Column("ITE")] public string Ite { get; set; }
        [DataMember]
        [Column("ROOM")] public string Room { get; set; }
        [DataMember]
        [Column("REMARKS")] public string Remarks { get; set; }
    }

    [DataContract]
    [TableName("ISPAREDEF")]
    [PrimaryKey("INSPECT_POINT,AREA_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPAREDEF
    {
        [DataMember]
        [Column("INSPECT_POINT")] public string InspectPoint { get; set; }
        [DataMember]
        [Column("AREA_ID")] public string AreaId { get; set; }
        [DataMember]
        [Column("ARE_DESC")] public string AreDesc { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPDFTDEF")]
    [PrimaryKey("INSPECT_TYPE,DEFECT_CODE",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPDFTDEF
    {
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [Column("DEFECT_CODE")] public string DefectCode { get; set; }
        [DataMember]
        [Column("DFT_DESC")] public string DftDesc { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPIMGDEF")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID,SIDE_TYPE,INSPECT_TYPE,AREA_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPIMGDEF
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("SLOT_ID")] public string SlotId { get; set; }
        [DataMember]
        [Column("WAFER_ID")] public string WaferId { get; set; }
        [DataMember]
        [Column("SIDE_TYPE")] public string SideType { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [Column("AREA_ID")] public decimal AreaId { get; set; }
        [DataMember]
        [Column("IMAGE_ID")] public string ImageId { get; set; }
        [DataMember]
        [Column("IMAGE_PATH")] public string ImagePath { get; set; }
        [DataMember]
        [Column("IMAGE_NAME")] public string ImageName { get; set; }
        [DataMember]
        [Column("IMAGE_TYPE")] public string ImageType { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPITMDEF")]
    [PrimaryKey("SIDE_TYPE,INSPECT_TYPE,INSPECT_RULE_CODE",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPITMDEF
    {
        [DataMember]
        [Column("SIDE_TYPE")] public string SideType { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
        [DataMember]
        [Column("INSPECT_RULE_CODE")] public string InspectRuleCode { get; set; }
        [DataMember]
        [Column("ISP_DESC")] public string IspDesc { get; set; }
        [DataMember]
        [Column("INSPECT_POINT")] public string InspectPoint { get; set; }
    }

    [DataContract]
    [TableName("ISPLOTHIS")]
    [PrimaryKey("LOT_ID,FOUP_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPLOTHI
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("FOUP_ID")] public string FoupId { get; set; }
        [DataMember]
        [Column("STATUS")] public string Status { get; set; }
        [DataMember]
        [Column("INSPECT_RESULT")] public string InspectResult { get; set; }
        [DataMember]
        [Column("PART_ID")] public string PartId { get; set; }
        [DataMember]
        [Column("PART_DESC")] public string PartDesc { get; set; }
        [DataMember]
        [Column("PRODUCT_DIE_QTY")] public decimal ProductDieQty { get; set; }
        [DataMember]
        [Column("QTY")] public decimal Qty { get; set; }
        [DataMember]
        [Column("REC_USER")] public string RecUser { get; set; }
        [DataMember]
        [Column("REC_USER_NAME")] public string RecUserName { get; set; }
        [DataMember]
        [Column("REC_DATE")] public string RecDate { get; set; }
        [DataMember]
        [Column("REC_SHIFT")] public string RecShift { get; set; }
        [DataMember]
        [Column("PHONE")] public string Phone { get; set; }
        [DataMember]
        [Column("LOT_TYPE")] public string LotType { get; set; }
        [DataMember]
        [Column("STAGE")] public string Stage { get; set; }
        [DataMember]
        [Column("DEPT")] public string Dept { get; set; }
        [DataMember]
        [Column("INSPECT_DATE")] public string InspectDate { get; set; }
        [DataMember]
        [Column("CUSTOMER_ID")] public string CustomerId { get; set; }
        [DataMember]
        [Column("CUST_LOT_ID")] public string CustLotId { get; set; }
        [DataMember]
        [Column("CUST_PART_ID")] public string CustPartId { get; set; }
        [DataMember]
        [Column("ORIGNAL_COUNTRY")] public string OrignalCountry { get; set; }
        [DataMember]
        [Column("QA_ID")] public string QaId { get; set; }
        [DataMember]
        [Column("QA_STAMP")] public string QaStamp { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
        [DataMember]
        [Column("TRAN_TIME")] public string TranTime { get; set; }
        [DataMember]
        [Column("TRAN_USER_ID")] public string TranUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPLOTSTS")]
    [PrimaryKey("LOT_ID,FOUP_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPLOTST
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("FOUP_ID")] public string FoupId { get; set; }
        [DataMember]
        [Column("STATUS")] public string Status { get; set; }
        [DataMember]
        [Column("INSPECT_RESULT")] public string InspectResult { get; set; }
        [DataMember]
        [Column("PART_ID")] public string PartId { get; set; }
        [DataMember]
        [Column("PART_DESC")] public string PartDesc { get; set; }
        [DataMember]
        [Column("PRODUCT_DIE_QTY")] public decimal ProductDieQty { get; set; }
        [DataMember]
        [Column("QTY")] public decimal Qty { get; set; }
        [DataMember]
        [Column("REC_USER")] public string RecUser { get; set; }
        [DataMember]
        [Column("REC_USER_NAME")] public string RecUserName { get; set; }
        [DataMember]
        [Column("REC_DATE")] public string RecDate { get; set; }
        [DataMember]
        [Column("REC_SHIFT")] public string RecShift { get; set; }
        [DataMember]
        [Column("PHONE")] public string Phone { get; set; }
        [DataMember]
        [Column("LOT_TYPE")] public string LotType { get; set; }
        [DataMember]
        [Column("STAGE")] public string Stage { get; set; }
        [DataMember]
        [Column("DEPT")] public string Dept { get; set; }
        [DataMember]
        [Column("INSPECT_DATE")] public string InspectDate { get; set; }
        [DataMember]
        [Column("CUSTOMER_ID")] public string CustomerId { get; set; }
        [DataMember]
        [Column("CUST_LOT_ID")] public string CustLotId { get; set; }
        [DataMember]
        [Column("CUST_PART_ID")] public string CustPartId { get; set; }
        [DataMember]
        [Column("ORIGNAL_COUNTRY")] public string OrignalCountry { get; set; }
        [DataMember]
        [Column("QA_ID")] public string QaId { get; set; }
        [DataMember]
        [Column("QA_STAMP")] public string QaStamp { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPWAFDFT")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID,SIDE_TYPE,INSPECT_TYPE,AREA_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPWAFDFT
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("SLOT_ID")] public string SlotId { get; set; }
        [DataMember]
        [Column("WAFER_ID")] public string WaferId { get; set; }
        [DataMember]
        [Column("SIDE_TYPE")] public string SideType { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [Column("AREA_ID")] public decimal AreaId { get; set; }
        [DataMember]
        [Column("DEFECT_CODE")] public string DefectCode { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPWAFITM")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID,SIDE_TYPE,INSPECT_TYPE",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPWAFITM
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("SLOT_ID")] public string SlotId { get; set; }
        [DataMember]
        [Column("WAFER_ID")] public string WaferId { get; set; }
        [DataMember]
        [Column("SIDE_TYPE")] public string SideType { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [Column("IS_INSPECT")] public string IsInspect { get; set; }
        [DataMember]
        [Column("INSPECT_POINT")] public string InspectPoint { get; set; }
        [DataMember]
        [Column("INSPECT_RESULT")] public string InspectResult { get; set; }
        [DataMember]
        [Column("MAGNIFICATION")] public string Magnification { get; set; }
        [DataMember]
        [Column("DIE_QTY")] public decimal DieQty { get; set; }
        [DataMember]
        [Column("DEFECT_RATE")] public decimal DefectRate { get; set; }
        [DataMember]
        [Column("REVIEW_USER")] public string ReviewUser { get; set; }
        [DataMember]
        [Column("DEFECT_DESC")] public string DefectDesc { get; set; }
        [DataMember]
        [Column("CMT")] public string Cmt { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

    [DataContract]
    [TableName("ISPWAFSTS")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID",AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPWAFST
    {
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("SLOT_ID")] public string SlotId { get; set; }
        [DataMember]
        [Column("WAFER_ID")] public string WaferId { get; set; }
        [DataMember]
        [Column("CMF_1")] public string Cmf1 { get; set; }
        [DataMember]
        [Column("CMF_2")] public string Cmf2 { get; set; }
        [DataMember]
        [Column("CMF_3")] public string Cmf3 { get; set; }
        [DataMember]
        [Column("CMF_4")] public string Cmf4 { get; set; }
        [DataMember]
        [Column("CMF_5")] public string Cmf5 { get; set; }
        [DataMember]
        [Column("CMF_6")] public string Cmf6 { get; set; }
        [DataMember]
        [Column("CMF_7")] public string Cmf7 { get; set; }
        [DataMember]
        [Column("CMF_8")] public string Cmf8 { get; set; }
        [DataMember]
        [Column("CMF_9")] public string Cmf9 { get; set; }
        [DataMember]
        [Column("CMF_10")] public string Cmf10 { get; set; }
        [DataMember]
        [VersionColumn("TRANS_SEQ",VersionColumnType.Number)] public decimal TransSeq { get; set; }
        [DataMember]
        [Column("CREATE_TIME")] public string CreateTime { get; set; }
        [DataMember]
        [Column("CREATE_USER_ID")] public string CreateUserId { get; set; }
        [DataMember]
        [Column("UPDATE_TIME")] public string UpdateTime { get; set; }
        [DataMember]
        [Column("UPDATE_USER_ID")] public string UpdateUserId { get; set; }
    }

}

