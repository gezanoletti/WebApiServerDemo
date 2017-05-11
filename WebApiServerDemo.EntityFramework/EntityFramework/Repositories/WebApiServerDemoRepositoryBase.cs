using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WebApiServerDemo.EntityFramework.Repositories
{
    public abstract class WebApiServerDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WebApiServerDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WebApiServerDemoRepositoryBase(IDbContextProvider<WebApiServerDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WebApiServerDemoRepositoryBase<TEntity> : WebApiServerDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WebApiServerDemoRepositoryBase(IDbContextProvider<WebApiServerDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
