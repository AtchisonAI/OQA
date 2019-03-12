using WcfService;

using System;

namespace OQAService.Services
{
    public class OQABaseService: BaseService
    {

        
        public OQABaseService():base("OQADB")
        {

        }

        //public IDatabase db;

        //private IDatabase GetDb()
        //{
        //    return db;
        //}

        public string GetSysTime()
        {
            DateTime.Now.ToShortTimeString();
            DateTime dt = DateTime.Now;
            string result = string.Format("{0:yyyyMMddHHmmss}", dt);
            return result;
        }
    }
}
