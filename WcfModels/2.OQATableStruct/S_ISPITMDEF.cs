using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPITMDEF")]
    [PrimaryKey("SIDE_TYPE,INSPECT_TYPE,INSPECT_RULE_CODE", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPITMDEF
    {
        [DataMember]
        [Column("SIDE_TYPE")] public string SideType { get; set; }
        [DataMember]
        [Column("INSPECT_TYPE")] public string InspectType { get; set; }
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
        [DataMember]
        [Column("INSPECT_RULE_CODE")] public string InspectRuleCode { get; set; }
        [DataMember]
        [Column("ISP_DESC")] public string IspDesc { get; set; }
        [DataMember]
        [Column("INSPECT_POINT")] public string InspectPoint { get; set; }
    }
}
