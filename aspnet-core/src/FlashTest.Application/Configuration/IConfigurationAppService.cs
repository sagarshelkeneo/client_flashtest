using System.Threading.Tasks;
using FlashTest.Configuration.Dto;

namespace FlashTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
