using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Meals.Dto
{
    [AutoMapFrom(typeof(MealType))]
    public class ConsumeUnitDto : EntityDto<int>
    {
        public int ConsumeUnitId { get; set; }

        public string UnitType { get; set; }
    }
}
