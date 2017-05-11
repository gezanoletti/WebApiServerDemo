using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using WebApiServerDemo.EntityFramework;

namespace WebApiServerDemo
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(WebApiServerDemoCoreModule))]
    public class WebApiServerDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<WebApiServerDemoDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
