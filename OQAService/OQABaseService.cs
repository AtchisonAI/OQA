using NPoco;
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

        //public string GetTime()
        //{
        //    string src = (new DataTime()).ToString();
        //    string result = src.tostring("yyyyMMddHHmmssfff");
        //    return result;
        //}
    }
}
