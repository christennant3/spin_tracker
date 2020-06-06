using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Meals.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Meals
{
    public class MealAppService : CrudAppService<Meal, MealDto, int, ConsumeDto, MealTypeDto, ConsumeUnitDto>
    {
        private readonly IRepository<Consume, int> MealTypeRepository;
       
        public MealAppService(
            IRepository<Meal, int> repository, 
            IRepository<Consume, int> ConsumeRepository,
            IRepository<MealType, int> MealTypeRepository,
            IRepository<ConsumeUnit, int> ConsumeUnitRepository
            ) 
            
            : base(repository)
        {
            
        }
    }
}
