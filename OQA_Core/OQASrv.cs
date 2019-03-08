using OQAService.Contract;
using WcfClientCore.Utils.Authority;
using WcfClientCore.WcfSrv;
using WCFModels.Message;

namespace OQA_Core
{
    public class OQASrv : WcfSrv
    {
        public static readonly IOQAContract Call = GetSrvClient<IOQAContract>("OQASrv");

        private static void LoadUserProfile(UserProfile userProfile)
        {
            AuthorityControl.LoadUserProfile(userProfile);
        }
    }
}