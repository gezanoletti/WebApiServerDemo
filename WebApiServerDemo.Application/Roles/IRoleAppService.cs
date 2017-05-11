using System.Threading.Tasks;
using Abp.Application.Services;
using WebApiServerDemo.Roles.Dto;

namespace WebApiServerDemo.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
