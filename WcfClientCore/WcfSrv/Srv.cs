using System.Collections.Generic;
using Utils;
using WcfClientCore.Utils.Authority;
using WcfClientCore.WcfService;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WcfClientCore.WcfSrv
{
    public static class Srv
    {
        public static WcfContractClient Client()
        {
            return SingletonT<WcfContractClient>.Instance;
        }

        public static bool Login(UserProfile userProfile)
        {
            LoginReq loginReq = new LoginReq()
            {
                userProfile = userProfile
            };

            var rsp = Client().Login(loginReq);
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
            return Client().QueryControlAccessString(req);
        }

        public static ModelRsp<ControlAccessString> UpdateControlAccessString(ControlAccessString dbModel, OperateType type)
        {
            UpdateModelReq<ControlAccessString> updateReq = new UpdateModelReq<ControlAccessString>()
            {
                model = dbModel,
                opreateType = type
            };

            return Client().UpdateControlAccessString(updateReq);
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
            AuthorityControl.LoadUserProfile(userProfile);
        }
    }
}
