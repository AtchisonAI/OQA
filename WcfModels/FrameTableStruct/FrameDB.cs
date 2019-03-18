using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.Frame
{
    [DataContract]
    [TableName("CONTROLACCESSSTRING")]
    [PrimaryKey("CONTROLID", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ControlAccessString
    {
        [DataMember]
        [Column("CONTROLID")] public string ControlID { get; set; }
        [DataMember]
        [Column("ACCESSSTRING")] public string AccessString { get; set; }

        [DataMember]
        [Column("SYSNAME")] public string SysName { get; set; }

        [DataMember]
        [VersionColumn("TRANS_SEQ", VersionColumnType.Number)] public decimal TransSeq { get; set; }
    }
}