using NPoco;

namespace WCFModels
{
    public interface ITrackModelObject
    {
        [Column("Create_Time")]  string CreateTime { get; set; }
        [Column("Create_UserId")] string CreateUserId { get; set; }
        [Column("Update_Time")] string UpdateTime { get; set; }
        [Column("Update_UserId")] string UpdateUserId { get; set; }
    }
}