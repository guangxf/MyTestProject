using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace SyncData
{
    public class DataFactory
    {
        /// 得到web.config里配置项的数据库连接字符串。
        private static readonly string ConnectionString = "server=localhost;port=3306;Charset=utf8;uid=root;pwd=123456;database=licensedb;SslMode=none;";
        /// 得到工厂提供器类型
        private static readonly string ProviderFactoryString = "MySql.Data.MySqlClient";
        private static DbProviderFactory df = null;
        /// <summary>
        /// 创建工厂提供器并且
        /// </summary>
        public static IDbConnection DbService()
        {
            if (df == null)
                df = DbProviderFactories.GetFactory(ProviderFactoryString);
            var connection = df.CreateConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();
            return connection;
        }
    }
}
