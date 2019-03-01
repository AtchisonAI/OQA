using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPAREDEF")]
    [PrimaryKey("INSPECT_POINT,AREA_ID", AutoIncrement = false)]
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
