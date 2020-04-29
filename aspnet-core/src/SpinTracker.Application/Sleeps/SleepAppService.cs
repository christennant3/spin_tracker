using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Sleeps;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Weathers
{
    public class SleepAppService : CrudAppService<Sleep, SleepDto>
    {
        public SleepAppService(IRepository<Sleep, int> repository) : base(repository)
        {
        }
    }
}
