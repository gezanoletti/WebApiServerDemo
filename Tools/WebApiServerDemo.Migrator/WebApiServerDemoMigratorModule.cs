using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using WebApiServerDemo.EntityFramework;

namespace WebApiServerDemo.Migrator
{
    [DependsOn(typeof(WebApiServerDemoDataModule))]
    public class WebApiServerDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<WebApiServerDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}