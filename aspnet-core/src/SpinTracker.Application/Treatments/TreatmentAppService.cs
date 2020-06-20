using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Treatments.Dto;

namespace SpinTracker.Treatments
{
    public class TreatmentAppService : CrudAppService<Treatment, TreatmentDto>
    {
  
        public TreatmentAppService(
            IRepository<Treatment, int> repository  

            )

            : base(repository)
        {

        }
    }

    public class TreatmentActiveAppService : CrudAppService<TreatmentActive, TreatmentActiveDto>
    {
        public TreatmentActiveAppService(IRepository<TreatmentActive, int> repository) : base(repository)
        {
        }
    }


    public class TreatmentResultAppService : CrudAppService<TreatmentResult, TreatmentResultDto>
    {
        public TreatmentResultAppService(IRepository<TreatmentResult, int> repository) : base(repository)
        {
        }
    }

}




