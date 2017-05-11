using Abp.Authorization;
using WebApiServerDemo.Authorization.Roles;
using WebApiServerDemo.MultiTenancy;
using WebApiServerDemo.Users;

namespace WebApiServerDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
