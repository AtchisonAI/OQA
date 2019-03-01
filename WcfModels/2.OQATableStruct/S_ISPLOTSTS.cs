using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.OQA
{
    [DataContract]
    [TableName("ISPLOTSTS")]
    [PrimaryKey("LOT_ID,FOUP_ID", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ISPLOTSTS
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
