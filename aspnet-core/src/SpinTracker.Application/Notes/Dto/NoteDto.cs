using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using System;

namespace SpinTracker.Notes.Dto
{
    [AutoMapFrom(typeof(Note))]
    public class NoteDto : EntityDto<int>
    {
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int EntryDateId { get; set; }
    }
}