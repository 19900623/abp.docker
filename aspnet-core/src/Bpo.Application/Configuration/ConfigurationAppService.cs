using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Bpo.Configuration.Dto;

namespace Bpo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BpoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
