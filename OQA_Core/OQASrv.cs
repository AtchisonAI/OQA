using OQAService.Contract;
using WcfClientCore.WcfSrv;

namespace OQA_Core
{
    public class OQASrv : WcfSrv
    {
        public static readonly IOQAContract Call = GetSrvClient<IOQAContract>("OQASrv");
    }
}