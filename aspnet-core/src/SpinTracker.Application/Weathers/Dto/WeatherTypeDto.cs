using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Weathers.Dto
{
    [AutoMapFrom(typeof(WeatherType))]
    public class WeatherTypeDto : EntityDto<int>
    {
        public int WeatherTypeId { get; set; }

        public string Name { get; set; }
    }
}
