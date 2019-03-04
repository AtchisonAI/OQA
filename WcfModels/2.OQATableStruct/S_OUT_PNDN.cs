using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("OUT_PNDN")]
    [PrimaryKey("PNDN_NO,LOT_ID", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class OUT_PNDN
    {
        [DataMember]
        [Column("PNDN_NO")] public string PndnNo { get; set; }
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("DEPT")] public string Dept { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
        [DataMember]
        [Column("DEFECT_CODE")] public string DefectCode { get; set; }
        [DataMember]
        [Column("WAFER_ID")] public string WaferId { get; set; }
        [DataMember]
        [Column("SPEC")] public string Spec { get; set; }
        [DataMember]
        [Column("REMARK")] public string Remark { get; set; }
        [DataMember]
        [Column("PART_ID")] public string PartId { get; set; }
        [DataMember]
        [Column("QTY")] public decimal Qty { get; set; }
        [DataMember]
        [Column("STEP_ID")] public string StepId { get; set; }
        [DataMember]
        [Column("STEP_NAME")] public string StepName { get; set; }
        [DataMember]
        [Column("HOLD_CODE")] public string HoldCode { get; set; }
        [DataMember]
        [Column("HOLD_COMMENT")] public string HoldComment { get; set; }
        [DataMember]
        [Column("USER_ID")] public string UserId { get; set; }
        [DataMember]
        [Column("SUPERVISOR_ID")] public string SupervisorId { get; set; }
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
