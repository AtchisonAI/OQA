using HiDM.FactoryWorks.Messages;
using HiDM.FactoryWorks.TibcoRV;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WcfService.Contract;

namespace WcfService.Services
{
    public class WcfService : BaseService, IWcfContract
    {
        #region 登陆&权限

        public ModelListRsp<string> Login(LoginReq loginReq)
        {
            ModelListRsp<string> loginRes = new ModelListRsp<string>();
            //首先使用tibco 验证登陆

            MessageService.Initialize();

            QRYUSERRULE qryUserRule = new QRYUSERRULE();
            qryUserRule.UserID = loginReq.userProfile.userId;
            qryUserRule.Password = loginReq.userProfile.passwd;
            qryUserRule.IsCheckPassowrd = true;

            var result = MessageService.SendRequest(qryUserRule.ToString());

            FWTxnRepMessage reply = new FWTxnRepMessage()
            {
                RepliedString = result
            };
            MessageService.Terminate();

            if (reply.IsSuccess)
            {
                //登陆成功，查询相应的access string
                BeginTrans();
                QueryReq req = new QueryReq();
                AddCondition(req, GetParaName<CUserAccessStringView>(q => q.userName), loginReq.userProfile.userId, LogicCondition.AndAlso, CompareType.Equal);
                AddCondition(req, GetParaName<CUserAccessStringView>(q => q.accessName), loginReq.userProfile.systemPrefix,  LogicCondition.AndAlso, CompareType.Include);

                var res = Query<CUserAccessStringView>(req);
                foreach (CUserAccessStringView q in res.models)
                {
                    loginRes.models.Add(q.accessName);
                }

                loginRes._success = true;

                EndTrans();
            }
            return loginRes;
        }

        public ModelListRsp<ControlAccessString>QueryControlAccessString(QueryReq queryReq)
        {
            return Query<ControlAccessString>(queryReq);
        }

        public PageModelRsp<ControlAccessString> PageQueryControlAccessString(PageQueryReq pageQueryReq)
        {
            return PageQuery<ControlAccessString>(pageQueryReq);
        }

        public ModelRsp<ControlAccessString> UpdateControlAccessString(UpdateModelReq<ControlAccessString> updateReq)
        {
            ModelRsp<ControlAccessString> rsp = new ModelRsp<ControlAccessString>();
            UpdateModel(updateReq, rsp,false);

            return rsp;
        }

        #endregion
    }
}
