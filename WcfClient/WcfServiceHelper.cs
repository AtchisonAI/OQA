using Models.Message;
using System.Collections.Generic;
using Utils;
using Utils.Authority;
using WcfClient.WcfService;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WcfClient
{
    public static class WcfServiceHelper
    {
        public static WcfContractClient WcfClient()
        {
            return SingletonT<WcfContractClient>.Instance;
        }

        public static bool Login(UserProfile userProfile)
        {
            LoginReq loginReq = new LoginReq()
            {
                userProfile = userProfile
            };

            var rsp = WcfClient().Login(loginReq);
            if (rsp._success)
            {
                //获取control&&user accessstring
                LoadUserAccessString(rsp.models);
                LoadControlAccessString(QueryControlAccessString().models);
                LoadUserProfile(userProfile);
            }
            return rsp._success;
        }

        public static ModelListRsp<ControlAccessString> QueryControlAccessString()
        {
            QueryReq req = new QueryReq();
            return WcfClient().QueryControlAccessString(req);
        }

        private static void LoadUserAccessString(IList<string> userAccessList)
        {
            AuthorityControl.LoadUserAccessString(userAccessList);
        }

        private static void LoadControlAccessString(IList<ControlAccessString> controlAccessList)
        {
            Dictionary<string, string> controlAccesstring = new Dictionary<string, string>();

            foreach (ControlAccessString q in controlAccessList)
            {
                controlAccesstring.Add(q.ControlID, q.AccessString);
            }

            AuthorityControl.LoadControlAccessString(controlAccesstring);
        }

        private static void LoadUserProfile(UserProfile userProfile)
        {
            AuthorityControl.LoadUserProfile(userProfile.userId, userProfile.passwd, userProfile.systemPrefix);
        }
    }
}
