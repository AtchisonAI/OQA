using OQA_Core.OQAService;
using Utils;

namespace OQA_Core
{
    public class OQASrv
    {
        public static OQAContractClient CallServer()
        {
            return SingletonT<OQAContractClient>.Instance;
        }
    }
}
