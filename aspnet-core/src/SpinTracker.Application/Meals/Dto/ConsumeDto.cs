using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SpinTracker.Meals.Dto
{
    [AutoMapFrom(typeof(Consume))]
    public class ConsumeDto : EntityDto<int>
    {
        public int ConsumeId { get; set; }
        public int Water { get; set; }

        public int Alcohol { get; set; }

        public int Tobacco { get; set; }

        public int ConsumeUnitWaterId { get; set; }

        public int ConsumeUnitAlcoholId { get; set; }

        public int EntryDateId { get; set; }
    }
}
