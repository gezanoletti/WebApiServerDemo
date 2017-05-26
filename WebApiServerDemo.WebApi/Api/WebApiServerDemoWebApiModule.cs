using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace WebApiServerDemo.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(WebApiServerDemoApplicationModule))]
    public class WebApiServerDemoWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(WebApiServerDemoApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof (WebApiServerDemoApplicationModule).Assembly, "app")
                .ForMethods(b =>
                {
                    if (b.Method.IsDefined(typeof (ActionNameAttribute)))
                    {
                        var s = b.ActionName;
                        Console.WriteLine(s);
                    }
                });

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
		}		
	}
}
