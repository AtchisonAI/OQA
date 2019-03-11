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
        public static readonly IWcfContract WcfClient = GetSrvClient<IWcfContract>("WcfSrv");

        public static T GetSrvClient<T>(string configName)
        {
            ChannelFactory<T> channelFactory = new ChannelFactory<T>(configName);
            T proxy = channelFactory.CreateChannel();
            return proxy;
        }

        public static ModelListRsp<string> Login(UserProfile userProfile)
        {
            LoginReq loginReq = new LoginReq()
            {
                userProfile = userProfile
            };

            var rsp = WcfClient.Login(loginReq);
            if (rsp._success)
            {
                //获取control&&user accessstring
                LoadUserAccessString(rsp.models);
                LoadControlAccessString(QueryControlAccessString().models);
                LoadUserProfile(userProfile);
            }
            return rsp;
        }

        public static ModelListRsp<ControlAccessString> QueryControlAccessString()
        {
            QueryReq req = new QueryReq();
            return WcfClient.QueryControlAccessString(req);
        }

        public static ModelRsp<ControlAccessString> UpdateControlAccessString(ControlAccessString dbModel, OperateType type)
        {
            UpdateModelReq<ControlAccessString> updateReq = new UpdateModelReq<ControlAccessString>()
            {
                model = dbModel,
                operateType = type
            };

            return WcfClient.UpdateControlAccessString(updateReq);
        }

        public static void LoadUserAccessString(List<string> userAccessList)
        {
            AuthorityControl.LoadUserAccessString(userAccessList);
        }

        public static void LoadControlAccessString(List<ControlAccessString> controlAccessList)
        {
            Dictionary<string, string> controlAccesstring = new Dictionary<string, string>();

            foreach (ControlAccessString q in controlAccessList)
            {
                controlAccesstring.Add(q.ControlID, q.AccessString);
            }

            AuthorityControl.LoadControlAccessString(controlAccesstring);
        }

        public static void LoadUserProfile(UserProfile userProfile)
        {
            AuthorityControl.LoadUserProfile(userProfile);
        }

        public static UserProfile GetUserProfile()
        {
            return AuthorityControl.GetUserProfile();
        }
    }
}
