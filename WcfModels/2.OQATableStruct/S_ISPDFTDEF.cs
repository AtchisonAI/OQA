using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPDFTDEF")]
    [PrimaryKey("INSPECT_TYPE,DEFECT_CODE", AutoIncrement = false)]
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
