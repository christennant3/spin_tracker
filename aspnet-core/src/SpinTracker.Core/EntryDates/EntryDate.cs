using Abp.Domain.Entities;
using SpinTracker.Authorization.Users;
using SpinTracker.Weathers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.EntryDates
{
    public class EntryDate : Entity<int>
    {

        public int EntryId { get; set; }
        public DateTime DateEntry { get; set; }
        public long UserId { get; set; }

        public ICollection<Weather> Weathers { get; set; }

        public User User { get; set; }



    }
}
