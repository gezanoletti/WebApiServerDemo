using WebApiServerDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace WebApiServerDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly WebApiServerDemoDbContext _context;

        public InitialHostDbBuilder(WebApiServerDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
