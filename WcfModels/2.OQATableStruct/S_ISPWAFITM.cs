using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPWAFITM")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID,SIDE_TYPE,INSPECT_TYPE", AutoIncrement = false)]
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
        [Column("TRANS_SEQ")] public decimal TransSeq { get; set; }
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
