using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace SpinTracker.Weathers
{
    [AutoMapFrom(typeof(Weather))]
    public class SleepDto : EntityDto<int>
    {
        public int SleepId { get; set; }
        public DateTime SleepTime { get; set; }
        public DateTime AwakeTime { get; set; }
        public int SleepQuality { get; set; }
        public bool Sofa { get; set; }
        public bool FellAsleep { get; set; }
        public int EntryDateId { get; set; }
    }

}

