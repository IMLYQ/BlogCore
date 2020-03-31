using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Common
{
    public class SqlSugarHelper
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        private static readonly string connectionString = ConfigManager.getDBconnectionString("DefaultConnection");


        /// <summary>
        /// SqlSugar DB
        /// </summary>
        internal SqlSugarClient db = new SqlSugarClient(
        new ConnectionConfig()
        {

            ConnectionString = connectionString,
            DbType = DbType.SqlServer,//设置数据库类型
            IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
            InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
        });
    }
}
