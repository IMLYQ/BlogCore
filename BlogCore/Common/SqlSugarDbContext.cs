using BlogCore.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Common
{
    public class SqlSugarDbContext
    {
        private static readonly string connectionString = ConfigManager.getDBconnectionString("DefaultConnection");
        public SqlSugarDbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connectionString,
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了

            });
            Db.Aop.OnLogExecuted = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                   Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }

        public SqlSugarClient Db;

        public SimpleClient<BK_Articles> ArticlesDB { get { return new SimpleClient<BK_Articles>(Db); } }


        public SimpleClient<BK_Users> UserDB { get { return new SimpleClient<BK_Users>(Db); } }
    }
}
