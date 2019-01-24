using System.Threading.Tasks;
using CJ.ABPVueDemo.Configuration.Dto;

namespace CJ.ABPVueDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
