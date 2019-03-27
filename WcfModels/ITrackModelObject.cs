using NPoco;

namespace WCFModels
{
    public interface ITrackModelObject
    {
        [Column("CREATE_TIME")]
        string CreateTime { get; set; }

        [Column("CREATE_USER_ID")]
        string CreateUserId { get; set; }

        [Column("UPDATE_TIME")]
        string UpdateTime { get; set; }

        [Column("UPDATE_USER_ID")]
        string UpdateUserId { get; set; }
    }
}