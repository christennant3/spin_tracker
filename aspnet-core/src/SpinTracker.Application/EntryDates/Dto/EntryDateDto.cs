using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SpinTracker.EntryDates
{
    [AutoMapFrom(typeof(EntryDate))]
    public class EntryDateDto : EntityDto<int>
    {
        public int EntryId { get; set; }
        public DateTime DateEntry { get; set; }
        public string UserId { get; set; }
    }
}
