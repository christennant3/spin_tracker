using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Weathers.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Weathers
{
    public class WeatherAppService : CrudAppService<Weather, WeatherDto, int, WeatherType, WeatherTypeDto>
    {
        private readonly IRepository<WeatherType, int> WeatherTypeRepository;
        public WeatherAppService(IRepository<Weather, int> repository, IRepository<WeatherType, int> weatherTypeRepository) : base(repository)
        {
            this.WeatherTypeRepository = weatherTypeRepository;
        }
    }
}
