using System.Collections.Generic;
using System.ServiceModel;
using WcfClientCore.Utils.Authority;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WcfService.Contract;

namespace WcfClientCore.WcfSrv
{
    public class WcfSrv
    {
        public static IWcfContract WcfClient()
        {
            return GetSrvClient<IWcfContract>("WcfSrv");
        }

        public static T GetSrvClient<T>(string configName)
        {
            ChannelFactory<T> channelFactory = new ChannelFactory<T>(configName);
            T proxy = channelFactory.CreateChannel();
            return proxy;
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

        public static ModelRsp<ControlAccessString> UpdateControlAccessString(ControlAccessString dbModel, OperateType type)
        {
            UpdateModelReq<ControlAccessString> updateReq = new UpdateModelReq<ControlAccessString>()
            {
                model = dbModel,
                opreateType = type
            };

            return WcfClient().UpdateControlAccessString(updateReq);
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
