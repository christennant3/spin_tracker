using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Meals.Dto
{
    [AutoMapFrom(typeof(MealType))]
    public class MealType : EntityDto<int>
    {
        public int MealTypeId { get; set; }

        public string Name { get; set; }
    }
}
