using AutoMapper;
using log4net;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using Yuebon.AspNetCore.SSO;
using Yuebon.Commons.Cache;
using Yuebon.Commons.Extensions;
using Yuebon.Commons.Filters;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.IoC;
using Yuebon.Commons.Log;
using Yuebon.Commons.Module;
using Yuebon.Commons.Options;
using Yuebon.UEditorNetCore;
//using Yuebon.Quartz;

namespace Yuebon.WebApp
{
    public class Startup
    {
        /// <summary>
        /// log4net �ִ���
        /// </summary>
        public static ILoggerRepository Logrepository { get; set; }
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //��ʼ��log4net
            Logrepository = LogManager.CreateRepository("NETCoreRepository");
            Log4NetHelper.SetConfig(Logrepository, "log4net.config");
            //��ʱ�������
            //YuebonScheduler.Start().GetAwaiter().GetResult();
            //��ʼ��ӳ���ϵ
            //SecurityMapper.Initialize();
        }
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //�ر�GDPR�淶
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //UEditor���ı��༭��
            services.AddUEditorService();
            //AutoMapper
            //services.AddAutoMapper();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.AddMvc(option =>
            {
                option.Filters.Add(new GlobalExceptionFilter());
            }).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore; //���Կ�ֵ
                options.SerializerSettings.Formatting = Formatting.Indented;
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            }).SetCompatibilityVersion(CompatibilityVersion.Latest).AddRazorRuntimeCompilation();
            //Session ����ʱ������
            var sessionOutTime = Configuration.GetValue<int>("AppSetting:SessionTimeOut", 30);
            //Session����
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(sessionOutTime);
            });
            services.AddDataProtection().SetDefaultKeyLifetime(TimeSpan.FromDays(14));

            ////����cookie������ע��
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options =>
            //    {//�Զ����½��ַ�������õĻ���Ĭ��Ϊhttp://localhost:5000/Account/Login
            //        options.LoginPath = "/Login/GetCheckUser";
            //    });
            return InitIoC(services);
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            IServiceProvider provider = app.ApplicationServices;
            AutoMapperService.UsePack(provider);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy();

            //Session,������ UseMvc ֮ǰ����
            app.UseSession();
            //app.UseAuthentication();
            //�� ���� IHttpContextAccessor ע�� HttpContextHelper ��̬������
            HttpContextHelper.Configure(app.ApplicationServices.GetRequiredService<IHttpContextAccessor>());
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapControllerRoute("default", "{controller=Login}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(name: "areas", "areas",pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            #region ���Ubuntu Nginx �����ܻ�ȡIP����
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            #endregion
        }


        /// <summary>
        /// IoC��ʼ��
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private IServiceProvider InitIoC(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();

            CacheProvider cacheProvider = new CacheProvider
            {
                IsUseRedis = Configuration.GetSection("CacheProvider:UseRedis").Value.ToBool(false),
                ConnectionString = Configuration.GetSection("CacheProvider:Redis_ConnectionString").Value,
                InstanceName = Configuration.GetSection("CacheProvider:Redis_InstanceName").Value
            };
            //�ж��Ƿ�ʹ��Redis�������ʹ�� Redis��Ĭ��ʹ�� MemoryCache
            if (cacheProvider.IsUseRedis)
            {
                //Use Redis
                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = cacheProvider.ConnectionString;
                    options.InstanceName = cacheProvider.InstanceName;
                });
                services.AddSingleton(typeof(ICacheService), new RedisCacheService(new RedisCacheOptions
                {
                    Configuration = cacheProvider.ConnectionString,
                    InstanceName = cacheProvider.InstanceName
                }, 0));
            }
            else
            {
                //Use MemoryCache
                services.AddSingleton<IMemoryCache>(factory =>
                {
                    var cache = new MemoryCache(new MemoryCacheOptions());
                    return cache;
                });
                services.AddSingleton<ICacheService, MemoryCacheService>();
            }
            var jwtConfig = Configuration.GetSection("Jwt");
            var jwtOption = new JwtOption
            {
                Issuer = jwtConfig["Issuer"],
                Expiration = Convert.ToInt16(jwtConfig["Expiration"]),
                Secret = jwtConfig["Secret"],
                Audience = jwtConfig["Audience"],
                refreshJwtTime = Convert.ToInt16(jwtConfig["refreshJwtTime"])
            };
            services.AddScoped(typeof(SSOAuthHelper));
            services.AddScoped(typeof(AuthHelper));
            IoCContainer.Register(cacheProvider);//ע�Ỻ������
            IoCContainer.Register(Configuration);//ע������
            IoCContainer.Register(jwtOption);//ע������
            IoCContainer.Register("Yuebon.Commons");
            IoCContainer.Register("Yuebon.AspNetCore");
            IoCContainer.Register("Yuebon.Security.Core");
           IoCContainer.Register("Yuebon.CMS.Core");
            IoCContainer.RegisterNew("Yuebon.Security.Core", "Yuebon.Security");
            IoCContainer.RegisterNew("Yuebon.CMS.Core", "Yuebon.CMS");

            List<Assembly> myAssembly = new List<Assembly>();
            myAssembly.Add(Assembly.Load("Yuebon.CMS.Core"));
            myAssembly.Add(Assembly.Load("Yuebon.Security.Core"));
            services.AddAutoMapper(myAssembly);
            services.AddScoped<IMapper, Mapper>();
            return MoudleService.LoaderMoudleService(services);
        }
    }
}
