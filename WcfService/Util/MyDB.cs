using NPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace WcfService
{
    public class MyDB : Database
    {
        public MyDB (string connectStringName) : base(connectStringName)
        {
            Console.WriteLine("*******");

        }

        public override DbCommand CreateCommand(DbConnection connection, CommandType commandType, string sql, params object[] args)
        {
            Console.WriteLine(sql);
            return base.CreateCommand(connection, commandType, sql, args);
        }
    }
}