using System.Threading.Tasks;
using Abp.Application.Services;
using SpinTracker.Authorization.Accounts.Dto;

namespace SpinTracker.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
