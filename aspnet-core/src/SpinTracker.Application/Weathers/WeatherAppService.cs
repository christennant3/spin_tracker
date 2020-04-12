using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Weathers
{
    public class WeatherAppService : CrudAppService<Weather, WeatherDto>
    {
        public WeatherAppService(IRepository<Weather, int> repository) : base(repository)
        {
        }
    }
}
