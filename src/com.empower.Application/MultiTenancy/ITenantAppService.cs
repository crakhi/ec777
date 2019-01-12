using Abp.Application.Services;
using Abp.Application.Services.Dto;
using com.empower.MultiTenancy.Dto;

namespace com.empower.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

