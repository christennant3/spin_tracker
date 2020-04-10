using System.Threading.Tasks;
using SpinTracker.Configuration.Dto;

namespace SpinTracker.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
