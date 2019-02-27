using System;
using System.Configuration;
using System.Data.OracleClient;
using System.Data;

#pragma warning disable 0618

//使用實例
//在配置文件中增加OracleConnString配置項
//<connectionStrings>
//  <add name = "OracleConnString" connectionString="Data Source=FWTSTDB_TEST;User ID=fwtst1;Password=123456;Integrated Security=no;" providerName="System.Data.OracleClient" />
//</connectionStrings>
//string sql = "select * from emp";
//DataTable result = OracleDBhelper.ExcuteDataTable(sql);
//int nResult = OracleDBhelper.ExecuteCommand(sql);

namespace Utils.db
{
    public static class OracleDBhelper
    {
        private static OracleConnection cnn = null;
        //private static DbBase dbBase = new DbBase("OracleConnString");
        /// <summary>
        /// 连接数据库
        /// </summary>
        public static OracleConnection Cnn
        {
            get
            {
                if (cnn == null)
                {
                    string cnnstr = ConfigurationManager.ConnectionStrings["OracleConnString"].ConnectionString;
                    cnn = new OracleConnection(cnnstr);
                    cnn.Open();
                }
                else if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                else if (cnn.State == ConnectionState.Broken)
                {
                    cnn.Close();
                    cnn.Open();
                }
                return cnn;
            }
         }


        /// <summary>
        /// int 增删改功能的Oracle语句。实现增删改功能，返回受影响行数。
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string Oracle)
        {
            int intResult = 0;
            try
            {
                string cnnstr = ConfigurationManager.ConnectionStrings["OracleConnString"].ConnectionString;
                Console.Write(cnnstr);
                cnn = new OracleConnection(cnnstr);
                cnn.Open();
                OracleCommand cmm = new OracleCommand(Oracle, cnn);
                intResult = cmm.ExecuteNonQuery();
                cmm.Dispose();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw ex;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return intResult;
        }

        /// <summary>
        /// int 增删改功能的Oracle语句。实现增删改功能，返回受影响行数。
        /// [where条件时绑定数据，防止注入式攻击]
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string Oracle, OracleParameter[] sp)
        {
            int intResult = 0;
            try
            {
                OracleCommand cmm = new OracleCommand(Oracle, Cnn);
                cmm.Parameters.AddRange(sp);
                intResult = cmm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
            return intResult;
        }

        /// <summary>
        /// string 查询返回单行单列的Oracle语句。（ 例：select count(*) from 表名或 select name from 表名 ）。
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string Oracle)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            return cmm.ExecuteScalar().ToString();
        }

        /// <summary>
        /// string 查询返回单行单列的Oracle语句。（ 例：select count(*) from 表名或 select name from 表名 ）。
        ///  [where条件时绑定数据，防止注入式攻击]
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static string ExecuteScalar(string Oracle, OracleParameter[] sp)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            cmm.Parameters.AddRange(sp);
            return cmm.ExecuteScalar().ToString();
        }

        /// <summary>
        /// OracleDataReader 查询返回符合条件的记录 每次返回一行
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteDataReader(string Oracle)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            return cmm.ExecuteReader();
        }

        /// <summary>
        /// OracleDataReader 查询返回符合条件的记录 每次返回一行.
        ///  [where条件时绑定数据，防止注入式攻击]
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteDataReader(string Oracle, OracleParameter[] sp)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            cmm.Parameters.AddRange(sp);
            return cmm.ExecuteReader();
        }

        /// <summary>
        /// DataTable 查询返回符合条件的记录表
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static DataTable ExcuteDataTable(string Oracle)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            OracleDataAdapter da = new OracleDataAdapter(cmm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// DataTable 查询返回符合条件的记录表
        ///  [where条件时绑定数据，防止注入式攻击]
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static DataTable ExcuteDataTable(string Oracle, OracleParameter[] sp)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            cmm.Parameters.AddRange(sp);
            OracleDataAdapter da = new OracleDataAdapter(cmm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// DataTable 查询返回DataTable 带有分页参数，startRecord 开始记录数，maxRecords 最大记录数 适用于分页控件
        /// startRecord ：(AspNetPager1.CurrnetPageIndex - 1 )*AspNetPager1.Pagesize
        ///  maxRecords：AspNetPager1.pagesize
        /// </summary>
        /// <param name="Oracle"></param>
        /// <param name="startRecord"></param>
        /// <param name="maxRecords"></param>
        /// <returns></returns>
        public static DataTable DataTablePage(string Oracle, int startRecord, int maxRecords)
        {
            OracleCommand cmm = new OracleCommand(Oracle, Cnn);
            OracleDataAdapter sdp = new OracleDataAdapter(cmm);
            DataTable dt = new DataTable();
            sdp.Fill(startRecord, maxRecords, dt);
            return dt;
        }

        /// <summary>
        /// DataTable 查询返回【存储过程的Oracle语句】
        /// 
        /// </summary>
        /// <param name="Oracle"></param>
        /// <returns></returns>
        public static DataTable ExcuteDataTableByProcedure(string procedure, OracleParameter[] sp)
        {
            OracleCommand cmm = new OracleCommand(procedure, Cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddRange(sp);
            OracleDataAdapter da = new OracleDataAdapter(cmm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}