using NPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;

namespace WcfService
{
    public class MyDB : Database
    {
        public MyDB (string connectStringName) : base(connectStringName)
        {

        }

        public override DbCommand CreateCommand(DbConnection connection, CommandType commandType, string sql, params object[] args)
        {
            Console.WriteLine(sql);
            return base.CreateCommand(connection, commandType, sql, args);
        }
    }
}