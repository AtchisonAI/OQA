using HiDM.FactoryWorks.Messages;
using HiDM.FactoryWorks.TibcoRV;
using System.ServiceModel;
using WcfContract;
using WCFModels;
using WCFModels.Frame;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WcfService.Services
{
    public class WcfService : BaseService, IWcfContract
    {
        #region 登陆&权限
        public ModelRsp<LoginRsp> Login(LoginReq loginReq)
        {
            ModelRsp<LoginRsp> loginRes = new ModelRsp<LoginRsp>();

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
                QueryReq req = new QueryReq();
                AddCondition(req, GetParaName<CUserAccessStringView>(q => q.userName), loginReq.userProfile.userId, LogicCondition.AndAlso, CompareType.Equal);
                AddCondition(req, GetParaName<CUserAccessStringView>(q => q.accessName), loginReq.userProfile.systemPrefix, LogicCondition.AndAlso, CompareType.Include);

                var res = Query<CUserAccessStringView>(req);
                foreach (CUserAccessStringView q in res.models)
                {
                    loginRes.model.userAccessString.Add(q.accessName);
                }

                //查询受控的control
                req.queryConditionList.Clear();
                AddCondition(req, GetParaName<ControlAccessString>(q => q.SysName), "OQA", LogicCondition.AndAlso, CompareType.Equal);
                loginRes.model.controlAccessString = Query<ControlAccessString>(req).models;

                //查询当前用户的自定义快捷菜单并权限过滤
                req.queryConditionList.Clear();
                AddCondition(req, GetParaName<UserFavorite>(q => q.UserID), loginReq.userProfile.userId, LogicCondition.AndAlso, CompareType.Equal);
                AddCondition(req, GetParaName<UserFavorite>(q => q.SysName), "OQA", LogicCondition.AndAlso, CompareType.Equal);
                loginRes.model.userFavorite = Query<UserFavorite>(req).models;

                loginRes._success = true;
            }
            else
            {
                loginRes._ErrorMsg = "OQA:账号密码验证失败，请重新输入";
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

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<ControlAccessString> UpdateControlAccessString(UpdateModelReq<ControlAccessString> updateReq)
        {
            ModelRsp<ControlAccessString> rsp = new ModelRsp<ControlAccessString>();
            UpdateModel(updateReq, rsp,false);

            return rsp;
        }

        public ModelListRsp<UserFavorite> QueryUserFavorite(QuerUserFavoriteReq querUserFavoriteReq)
        {
            QueryReq req = new QueryReq();
            AddCondition(req, GetParaName<UserFavorite>(q => q.UserID), querUserFavoriteReq.userId, LogicCondition.AndAlso, CompareType.Equal);
            AddCondition(req, GetParaName<UserFavorite>(q => q.SysName), "OQA", LogicCondition.AndAlso, CompareType.Equal);
            return Query<UserFavorite>(req);
        }

        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<UserFavorite> UpdateUserFavorite(UpdateModelReq<UserFavorite> updateReq)
        {
            ModelRsp<UserFavorite> rsp = new ModelRsp<UserFavorite>();
            UpdateModel(updateReq, rsp, false);
            return rsp;
        }

        public void Demo()
        {

            string sql = @" SELECT lot.lottype,
        lot.currentsite area,
        lot.productname productid,
        lot.appid LOTID,
        ws.stagename,
        ws.handle stepseq,
        ws.stepname,
        ws.trackinlocation eqid, 
        lot.priority pri,
        ws.currentqty qty,
        max(hr.holdtime) over(partition by lot.appid) maxholdtime,
        hr.userid holduser,
        he.dept_code holdmodule,
        to_date(substr(hr.holdtime, 0, 15), 'yyyymmdd hh24miss') holdtime,
        hr.reason holdcode,
        hr.reasondescription holdcomment,
        r.userid     releaseuser,
        re.dept_code releaseusermodule,
        r.holdtime   releasetime, 
        hr.holdtime holdtimestring
   FROM fwwipstep ws
   left join fwlot lot on ws.lotobject = lot.sysid
   LEFT JOIN FWWIPSTEPHISTORY HS ON HS.WIPSTEPREF = WS.SYSID
   left join fwwiptransaction hd on hd.wipstepref = hs.sysid
                                and (hd.sysid like '00003106.%' or
                                    hd.sysid like '00000e2b.%')
   left join fwholdrelease hr on hd.holdrelease = hr.sysid
   left join fwholdrelease r on hr.holdsysid = r.holdsysid
                            and hr.sysid != r.sysid
   left join emp he on hd.userid = he.id
   left join emp re on r.userid = re.id
  where lot.processingstatus = 'Hold'";

            var res1 = QueryRawSql(sql);
        }
        #endregion
    }
}