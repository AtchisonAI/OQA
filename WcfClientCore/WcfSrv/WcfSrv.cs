using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
using WcfContract;
using WCFModels;
using WCFModels.Frame;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

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
            QueryCondition querycon = new QueryCondition();
            querycon.paramName = "SYSNAME";
            querycon.value = "OQA";
            querycon.compareType = CompareType.Equal;
            querycon.conditionType = LogicCondition.AndAlso;
            req.queryConditionList.Add(querycon);

            return WcfClient.QueryControlAccessString(req);
        }

        public static ModelRsp<ControlAccessString> UpdateControlAccessString(ControlAccessString dbModel, OperateType type)
        {
            UpdateModelReq<ControlAccessString> updateReq = new UpdateModelReq<ControlAccessString>()
            {
                model = dbModel,
                operateType = type
            };

            try
            {
                return WcfClient.UpdateControlAccessString(updateReq);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ModelRsp<ControlAccessString> rsp = new ModelRsp<ControlAccessString>();
                rsp._success = false;
                return rsp;
            }
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
