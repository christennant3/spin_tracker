using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Meals.Dto;

namespace SpinTracker.Meals
{
    public class MealAppService : CrudAppService<Meal, MealDto>
    {
       
       
        public MealAppService(
            IRepository<Meal, int> repository
            ) 
            
            : base(repository)
        {
            
        }
    }

    public class MealTypeAppService : CrudAppService<MealType, MealTypeDto>
    {
        public MealTypeAppService(IRepository<MealType, int> repository) : base(repository)
        {
        }
    }

    public class ConsumeUnitAppService : CrudAppService<ConsumeUnit, ConsumeUnitDto>
    {
        public ConsumeUnitAppService(IRepository<ConsumeUnit, int> repository) : base(repository)
        {
        }
    }


    public class ConsumeAppService : CrudAppService<Consume, ConsumeDto>
    {
        public ConsumeAppService(IRepository<Consume, int> repository) : base(repository)
        {
        }
    }
}
