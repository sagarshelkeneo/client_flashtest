using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FlashTest.Configuration.Dto;

namespace FlashTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FlashTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
