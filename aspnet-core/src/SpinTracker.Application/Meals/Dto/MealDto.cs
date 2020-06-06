using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SpinTracker.Meals.Dto
    
{
    [AutoMapFrom(typeof(Meal))]
    public class MealDto : EntityDto<int>
    {

        public int Salt { get; set; }

        public int Sugar { get; set; }

        public int EntryDateId { get; set; }
    }


}
