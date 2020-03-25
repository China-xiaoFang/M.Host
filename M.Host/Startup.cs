using M.Helper.AppConfigurtaion;
using M.Helper.Http;
using M.Helper.Middleware;
using M.Model;
using M.Model.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace M.Host
{
    public class Startup
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Project_Name { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            // 设置版本号和项目名称
            Version = AppConfigurtaionService.Configuration["ProjectInfo:Version"];
            Project_Name = AppConfigurtaionService.Configuration["ProjectInfo:Project_Name"];
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #region 注册Swagger生成器

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(Version, new Info
                {
                    Version = Version,
                    Title = $"{Project_Name} 默认接口文档",
                    // Description = $"{_Project_Name} HTTP API " + _Version,
                    // TermsOfService = "None",
                    License = new License
                    {
                        Name = $"版权所有 ©{Project_Name}",
                        Url = "http://mchen.vip/"
                    }
                });
                // 为Swagger JSON 和 UI设置xml文档注释路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);// 获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                // 添加接口XML的路径
                var xmlPath = Path.Combine(basePath, "M.Application.xml");
                // 定义实体类XML的路径
                var entityXmlPath = Path.Combine(basePath, "M.Model.xml");
                // 如果需要显示控制器注释只需将第二个参数设置为true
                c.IncludeXmlComments(xmlPath);
                // c.IncludeXmlComments(xmlPath, true);
                // 添加实体的注释
                c.IncludeXmlComments(entityXmlPath);
                // 添加HttpHeader参数
                c.OperationFilter<HttpHeaderOperation>();
            });

            #endregion 注册Swagger生成器

            // 注册DB为服务
            services.AddDbContext<MChenVipDbContext>();

            // 配置跨域
            services.AddCors(corsOption =>
            {
                corsOption.AddPolicy("CustomCorsPolicy",
                    CorsPolicyBuilder =>
                    {
                        // 配置允许那些地方可以请求
                        CorsPolicyBuilder.WithOrigins(AppConfigurtaionService.Configuration["AllowedHosts:Url"])
                            .AllowAnyOrigin() // 允许任何主机请求
                            .AllowAnyMethod() // 允许任何请求方式
                            .AllowAnyHeader() // 允许任何请求头
                            .AllowCredentials(); //指定处理cookie
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MChenVipDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // 根据Migrations修改/创建数据库
            new DbInitializer().InitializeAsync(context);

            // 开启全局异常捕获
            //app.UseMiddleware<ExceptionHandlerMiddleware>();
            app.UseMiddleware(typeof(ExceptionHandlerMiddleware));

            app.UseHttpsRedirection();
            app.UseMvc();



            #region Swagger

            // 启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            // 启用中间件服务对Swagger-UI,指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{Version}/swagger.json", "默认接口文档");
            });

            #endregion Swagger

            // 开启跨域
            app.UseCors("CustomCorsPolicy");
        }
    }
}
