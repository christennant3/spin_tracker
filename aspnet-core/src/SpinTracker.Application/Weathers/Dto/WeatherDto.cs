using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SpinTracker.Weathers
{
    [AutoMapFrom(typeof(Weather))]
    public class WeatherDto : EntityDto<int>
    {
        public int WeatherId { get; set; }
        public string Pollen { get; set; }
        public string Barometric { get; set; }
        public int Temperature { get; set; }
        public int WeatherTypeId { get; set; }
        public int WeatherConditionsTypeId { get; set; }
    }



}

