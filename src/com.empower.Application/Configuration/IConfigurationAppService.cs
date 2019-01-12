using System.Threading.Tasks;
using com.empower.Configuration.Dto;

namespace com.empower.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
