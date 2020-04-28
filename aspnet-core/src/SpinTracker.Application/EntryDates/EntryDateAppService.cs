using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.EntryDates
{
    public class EntryDateAppService : CrudAppService<EntryDate, EntryDateDto>
    {
        public EntryDateAppService(IRepository<EntryDate, int> repository) : base(repository)
        {
        }
    }
}
