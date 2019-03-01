using OQAService.Contract;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        public PageModelRsp<Emp> QueryEmpInfo(QueryEmpReq queryEmpReq)
        {
            return PageQuery<Emp>(queryEmpReq);
        }

    }

}
