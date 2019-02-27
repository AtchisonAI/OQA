using System.Runtime.Serialization;
using NPoco;
namespace WCFModels.MESDB.FWTST1
{
    [DataContract]
    [TableName("C_USERACCESSSTRING_VIEW")]
    [ExplicitColumns]
    public partial class CUserAccessStringView
    {
        [DataMember]
        [Column("userName")] public string userName { get; set; }
        [DataMember]
        [Column("accessName")] public string accessName { get; set; }
    }


    [DataContract]
    public class CBaseView
    {
        [DataMember]
        [Column("name")] public string name { get; set; }
        [DataMember]
        [Column("value")] public string value { get; set; }
    }

    [DataContract]
    [TableName("C_EMP_PERCENT_VIEW")]
    [ExplicitColumns]
    public partial class CEmpPercentView : CBaseView
    {

    }

    [DataContract]
    [TableName("C_EMP_SUM_VIEW")]
    [ExplicitColumns]
    public partial class CEmpSumView : CBaseView
    {

    }
}