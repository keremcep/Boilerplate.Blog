using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boilerplate.Configuration.Dto;

namespace boilerplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : boilerplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
