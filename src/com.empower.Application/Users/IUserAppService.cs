using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using com.empower.Roles.Dto;
using com.empower.Users.Dto;

namespace com.empower.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
