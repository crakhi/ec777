using System.Threading.Tasks;
using Abp.Application.Services;
using com.empower.Authorization.Accounts.Dto;

namespace com.empower.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
