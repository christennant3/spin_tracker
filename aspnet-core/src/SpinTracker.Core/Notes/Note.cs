using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Notes
{
    public class Note : Entity<int>
    {
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public int EntryDateId { get; set; }
        public EntryDate EntryDate { get; set; }
    }
}
