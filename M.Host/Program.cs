using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace M.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                // 发布程序出现错误帮助定位详细错误信息
                //.UseKestrel()
                //.UseContentRoot(Directory.GetCurrentDirectory())
                //.UseSetting("detailedErrors", "true")
                //.UseIISIntegration()

                .CaptureStartupErrors(true)
                .UseStartup<Startup>();

        //.UseStartup<Startup>();
    }
}