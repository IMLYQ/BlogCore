using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace BlogCore.Common
{
    /// <summary>
    /// 读取appsettings.json配置文件
    /// </summary>
    public class ConfigManager
    {
        public static IConfiguration Configuration { get; set; }

        static ConfigManager()
        {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载            

            #region 方式1（ok）

            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource
                {
                    Path = "appsettings.json",
                    ReloadOnChange = true
                }).Build();

            #endregion
            #region 方式2（ok）

            //Configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json").Build();

            #endregion
        }
        /// <summary>
        /// 获取数据库的连接字符串
        /// </summary>
        /// <param name="connectName">数据库连接名称</param>
        /// <returns></returns>
        public static string getDBconnectionString(string connectName)
        {

            if (string.IsNullOrEmpty(Configuration.GetConnectionString(connectName)))
            {
                return "";
            }
            else
            {
                return Configuration.GetConnectionString(connectName);
            }
        }
    }
}
