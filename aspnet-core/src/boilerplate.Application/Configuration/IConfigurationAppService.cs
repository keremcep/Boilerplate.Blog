using System.Threading.Tasks;
using boilerplate.Configuration.Dto;

namespace boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
