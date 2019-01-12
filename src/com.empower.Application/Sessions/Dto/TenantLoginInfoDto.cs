using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using com.empower.MultiTenancy;

namespace com.empower.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
