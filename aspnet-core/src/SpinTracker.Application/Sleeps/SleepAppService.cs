using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace SpinTracker.Sleeps
{
    public class SleepAppService : CrudAppService<Sleep, SleepDto>
    {
        public SleepAppService(IRepository<Sleep, int> repository) : base(repository)
        {
        }
    }
}
