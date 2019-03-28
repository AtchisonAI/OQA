using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
using WcfClientCore.Utils.Authority;
using WcfContract;
using WCFModels;
using WCFModels.Frame;
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

        public static ModelRsp<LoginRsp> Login(UserProfile userProfile)
        {
            LoginReq loginReq = new LoginReq()
            {
                userProfile = userProfile
            };

            var rsp = WcfClient.Login(loginReq);
            if (rsp._success)
            {
                //获取control&&user accessstring
                LoadUserProfile(userProfile);
                LoadUserAccessString(rsp.model.userAccessString);
                LoadControlAccessString(rsp.model.controlAccessString);
                LoadUserFavoriteCtl(rsp.model.userFavorite);
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
            dbModel.SysName = "OQA";
            UpdateModelReq<ControlAccessString> updateReq = new UpdateModelReq<ControlAccessString>()
            {
                model = dbModel,
                operateType = type,
                userId = AuthorityControl.GetUserProfile().userId
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

        public static ModelListRsp<ControlAccessString> UpdateControlAccessStringList(List<ControlAccessString> dbModelList, OperateType type)
        {
            UpdateModelListReq<ControlAccessString> updateReq = new UpdateModelListReq<ControlAccessString>()
            {
                models = dbModelList,
                operateType = type,
                userId = AuthorityControl.GetUserProfile().userId
            };

            try
            {
                return WcfClient.UpdateControlAccessStringList(updateReq);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ModelListRsp<ControlAccessString> rsp = new ModelListRsp<ControlAccessString>();
                rsp._success = false;
                return rsp;
            }
        }

        public static ModelListRsp<UserFavorite> QueryUserFavorites()
        {
            QuerUserFavoriteReq req = new QuerUserFavoriteReq();
            req.userId = AuthorityControl.GetUserProfile().userId;

            return WcfClient.QueryUserFavorite(req);
        }

        public static ModelRsp<UserFavorite> UpdateUserFavorite(UserFavorite model, OperateType type)
        {
            model.SysName = "OQA";
            model.UserID = AuthorityControl.GetUserProfile().userId; ;

            UpdateModelReq<UserFavorite> req = new UpdateModelReq<UserFavorite>();
            req.userId = AuthorityControl.GetUserProfile().userId;
            req.model = model;
            req.operateType = type;
            try
            {
                return WcfClient.UpdateUserFavorite(req);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ModelRsp<UserFavorite> rsp = new ModelRsp<UserFavorite>();
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

        public static void LoadUserFavoriteCtl(List<UserFavorite> list)
        {
            AuthorityControl.LoadUserFavoriteList(list);
        }
    }
}