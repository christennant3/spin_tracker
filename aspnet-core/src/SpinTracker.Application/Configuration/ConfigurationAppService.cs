using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SpinTracker.Configuration.Dto;

namespace SpinTracker.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SpinTrackerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
