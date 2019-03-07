using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFModels;
using WCFModels.Message;
using WcfService;

namespace OQAService.Services
{
    public class OQABaseService: BaseService
    {
        public OQABaseService():base("OQADB")
        {

        }
    }
}
