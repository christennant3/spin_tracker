using System.Threading.Tasks;
using Abp.Application.Services;
using SpinTracker.Sessions.Dto;

namespace SpinTracker.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
