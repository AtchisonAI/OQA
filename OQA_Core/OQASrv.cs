using OQAService.Contract;
using WcfClientCore.WcfSrv;

namespace OQA_Core
{
    public class OQASrv : WcfSrv
    {
        public static IOQAContract CallServer()
        {
            return GetSrvClient<IOQAContract>("OQASrv");
        }
    }
}
