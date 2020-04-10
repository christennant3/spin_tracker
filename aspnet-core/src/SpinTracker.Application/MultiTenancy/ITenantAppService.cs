using Abp.Application.Services;
using SpinTracker.MultiTenancy.Dto;

namespace SpinTracker.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

