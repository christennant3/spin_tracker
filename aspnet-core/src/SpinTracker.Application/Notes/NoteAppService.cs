using Abp.Application.Services;
using Abp.Domain.Repositories;
using SpinTracker.Notes.Dto;

namespace SpinTracker.Notes
{
    public class NoteAppService : CrudAppService<Note, NoteDto>
    {
       
       
        public NoteAppService(
            IRepository<Note, int> repository
            ) 
            
            : base(repository)
        {
            
        }
    }

 
}
