using M.Helper.Http;
using M.Helper.Middleware;
using M.Helper.Swagger;
using M.Model;
using M.Model.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            Version = Configuration["ProjectInfo:Version"];
            Project_Name = Configuration["ProjectInfo:Project_Name"];
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #region JWT

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Audience:Secret"]));
            services.AddAuthentication("Bearer").AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    // 是否开启密钥认证和key值
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = signingKey,

                    // 是否开启发行人认证和发行人
                    ValidateIssuer = true,
                    ValidIssuer = Configuration["Audience:Issuer"],

                    // 是否开启订阅人认证和订阅人
                    ValidateAudience = true,
                    ValidAudience = Configuration["Audience:Audience"],

                    // 认证时间的偏移量
                    ClockSkew = TimeSpan.Zero,
                    //是否开启时间认证
                    ValidateLifetime = true,
                    // 是否该令牌必须带有过期时间
                    RequireExpirationTime = true
                };
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Mr.Fang", policy => policy.RequireRole("Mr.Fang").Build());
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System"));
            });

            #endregion JWT

            // 注册DB为服务
            services.AddDbContext<FangHuaHostDbContext>();

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
                        Url = "http://fanghua.host/"
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
                // 隐藏
                c.DocumentFilter<HiddenApiFilter>();
                // Token
                // c.OperationFilter<HttpHeaderOperationFilter>();

                #region Token

                //添加header验证信息
                //c.OperationFilter<SwaggerHeader>();
                var security = new Dictionary<string, IEnumerable<string>> { { "Mr.FangAPI", new string[] { } }, };
                c.AddSecurityRequirement(security);
                //方案名称“Blog.Core”可自定义，上下一致即可
                c.AddSecurityDefinition("Mr.FangAPI", new ApiKeyScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）",
                    Name = "Authorization",//jwt默认的参数名称
                    In = "header",//jwt默认存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });

                #endregion Token
            });

            #endregion 注册Swagger生成器

            // 配置跨域
            services.AddCors(corsOption =>
            {
                corsOption.AddPolicy("CustomCorsPolicy",
                    CorsPolicyBuilder => CorsPolicyBuilder
                    .AllowAnyOrigin() // 允许任何主机请求
                    .AllowAnyMethod() // 允许任何请求方式
                    .AllowAnyHeader() // 允许任何请求头
                    // .AllowCredentials() //指定处理cookie
                    );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FangHuaHostDbContext context)
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

            // JWT
            app.UseAuthentication();

            // 开启跨域
            app.UseCors("CustomCorsPolicy");

            app.UseMvc();

            #region Swagger

            // 启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            // 启用中间件服务对Swagger-UI,指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{Version}/swagger.json", "默认接口文档");
                // 路径配置，设置为空，表示直接访问该文件
                c.RoutePrefix = "";
            });

            #endregion Swagger
        }
    }
}