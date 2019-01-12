using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using com.empower.Configuration.Dto;

namespace com.empower.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : empowerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
