using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

