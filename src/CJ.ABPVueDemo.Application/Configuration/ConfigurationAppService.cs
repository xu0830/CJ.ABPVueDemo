using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CJ.ABPVueDemo.Configuration.Dto;

namespace CJ.ABPVueDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPVueDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
