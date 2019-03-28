using System.Runtime.Serialization;
using NPoco;

namespace WCFModels.Frame
{
    [DataContract]
    [TableName("CONTROLACCESSSTRING")]
    [PrimaryKey("CONTROLID,SYSNAME", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class ControlAccessString: ITrackModelObject
    {
        [DataMember]
        [Column("CONTROLID")] public string ControlID { get; set; }
        [DataMember]
        [Column("ACCESSSTRING")] public string AccessString { get; set; }

        [DataMember]
        [Column("SYSNAME")] public string SysName { get; set; }
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
    [TableName("USERFAVORITE")]
    [PrimaryKey("CONTROLID,USERID,SYSNAME", AutoIncrement = false)]
    [ExplicitColumns]
    public partial class UserFavorite
    {
        [DataMember]
        [Column("USERID")] public string UserID { get; set; }
        [DataMember]
        [Column("CONTROLID")] public string ControlId { get; set; }
        [DataMember]
        [Column("FORMNAME")] public string FormName { get; set; }
        [DataMember]
        [Column("SYSNAME")] public string SysName { get; set; }
    }
}