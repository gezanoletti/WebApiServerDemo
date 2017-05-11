using System.Data.Common;
using Abp.Zero.EntityFramework;
using WebApiServerDemo.Authorization.Roles;
using WebApiServerDemo.MultiTenancy;
using WebApiServerDemo.Users;

namespace WebApiServerDemo.EntityFramework
{
    public class WebApiServerDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WebApiServerDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WebApiServerDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WebApiServerDemoDbContext since ABP automatically handles it.
         */
        public WebApiServerDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WebApiServerDemoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public WebApiServerDemoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
