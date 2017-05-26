using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Routing;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Web;
using Abp.WebApi;
using WebApiServerDemo.Students;

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

			Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
		}		
	}
}
