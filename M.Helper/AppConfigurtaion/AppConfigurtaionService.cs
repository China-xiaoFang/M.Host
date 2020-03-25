using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace M.Helper.AppConfigurtaion
{
    /// <summary>
    /// AppConfigurtaion服务
    /// 读取 appsettings.json 文件节点内容
    /// 读取一级节点配置 AppConfigurtaionServices.Configuration["ServiceUrl"];
    /// 读取二级子节点配置 AppConfigurtaionServices.Configuration["Appsettings:SystemName"];
    /// </summary>
    public class AppConfigurtaionService
    {
        public static IConfiguration Configuration { get; set; }

        static AppConfigurtaionService()
        {
            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
                .Build();
        }

        /*
         * 读取一级节点配置
         * AppConfigurtaionServices.Configuration["ServiceUrl"];
         * 读取二级子节点配置
         * AppConfigurtaionServices.Configuration["Appsettings:SystemName"];
         */
    }
}
