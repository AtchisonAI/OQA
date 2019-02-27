using Models.Message;
using System.Runtime.Serialization;

namespace WCFModels.Message
{
    [DataContract]
    public class LoginReq : BaseReq
    {
        [DataMember]
        public UserProfile userProfile;
    }
}