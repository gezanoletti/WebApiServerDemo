using System.Linq;
using WebApiServerDemo.EntityFramework;
using WebApiServerDemo.MultiTenancy;

namespace WebApiServerDemo.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly WebApiServerDemoDbContext _context;

        public DefaultTenantCreator(WebApiServerDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
