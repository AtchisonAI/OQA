using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using System.Web.Services;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WcfClient.WcfService;

namespace OQAMain
{

    public static class Svr
    {

        /// <summary>
        /// 调用OQA服务
        /// </summary>
        public static WcfContractClient CallService()
        {
            return SingletonT<WcfContractClient>.Instance;
        }
    }
}
