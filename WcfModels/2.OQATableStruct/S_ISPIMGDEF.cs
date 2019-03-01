﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPIMGDEF")]
    [PrimaryKey("LOT_ID,SLOT_ID,WAFER_ID,SIDE_TYPE,INSPECT_TYPE,AREA_ID", AutoIncrement = false)]
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
