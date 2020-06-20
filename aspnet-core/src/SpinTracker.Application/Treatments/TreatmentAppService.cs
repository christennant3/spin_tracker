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
}
