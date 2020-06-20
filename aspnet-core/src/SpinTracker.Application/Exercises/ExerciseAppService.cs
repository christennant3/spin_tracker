using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Exercises
{
    public class ExerciseAppService : CrudAppService<Exercise, ExerciseDto>
    {
            
        public ExerciseAppService(
            IRepository<Exercise, int> repository
            ) 
            
            : base(repository)
        {
            
        }
    }

}
