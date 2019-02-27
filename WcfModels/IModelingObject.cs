namespace Models
{
    public interface IModelingObject
    {
        string CreateTime { get; set; }
        string CreateUserId { get; set; }
        string UpdateTime { get; set; }
        string UpdateUserId { get; set; }
    }
}