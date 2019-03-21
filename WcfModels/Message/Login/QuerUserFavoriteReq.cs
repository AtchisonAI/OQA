using System.Runtime.Serialization;

namespace WCFModels.Message
{
    [DataContract]
    public class QuerUserFavoriteReq :QueryReq
    {
        [DataMember]
        public string userId;
    }
}