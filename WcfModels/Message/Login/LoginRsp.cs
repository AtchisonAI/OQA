using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.Frame;

namespace WCFModels.Message
{
    [DataContract]
    public class LoginRsp : BaseRsp
    {
        public LoginRsp()
        {
            userAccessString = new List<string>();
            controlAccessString = new List<ControlAccessString>();
            userFavorite = new List<UserFavorite>();
        }

        [DataMember]
        public UserProfile userProfile;

        //用户拥有的权限
        [DataMember]
        public List<string> userAccessString;

        //权限管控的控件
        [DataMember]
        public List<ControlAccessString> controlAccessString;

        //用户自定义快捷菜单
        [DataMember]
        public List<UserFavorite> userFavorite;
    }
}