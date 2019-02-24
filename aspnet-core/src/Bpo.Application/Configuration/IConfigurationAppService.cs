using System.Threading.Tasks;
using Bpo.Configuration.Dto;

namespace Bpo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
