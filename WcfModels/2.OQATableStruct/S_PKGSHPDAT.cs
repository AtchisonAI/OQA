using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("PKGSHPDAT")]
    [PrimaryKey("SHIP_ID,LOT_ID", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class PKGSHPDAT
    {
        [DataMember]
        [Column("SHIP_ID")] public string ShipId { get; set; }
        [DataMember]
        [Column("LOT_ID")] public string LotId { get; set; }
        [DataMember]
        [Column("QTY")] public string Qty { get; set; }
        [DataMember]
        [Column("PART_ID")] public string PartId { get; set; }
        [DataMember]
        [Column("INSPECT_RESULT")] public string InspectResult { get; set; }
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
