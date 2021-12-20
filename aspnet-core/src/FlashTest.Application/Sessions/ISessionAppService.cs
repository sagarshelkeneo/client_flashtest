using System.Threading.Tasks;
using Abp.Application.Services;
using FlashTest.Sessions.Dto;

namespace FlashTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
