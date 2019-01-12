using System.Threading.Tasks;
using Abp.Application.Services;
using com.empower.Sessions.Dto;

namespace com.empower.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
