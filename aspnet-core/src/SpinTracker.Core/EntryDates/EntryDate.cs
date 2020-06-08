using Abp.Domain.Entities;
using SpinTracker.Authorization.Users;
using SpinTracker.Meals;
using SpinTracker.Medications;
using SpinTracker.Sleeps;
using SpinTracker.Treatments;
using SpinTracker.Weathers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.EntryDates
{
    public class EntryDate : Entity<int>
    {

        public DateTime DateEntry { get; set; }

        public long UserId { get; set; }

        public ICollection<Weather> Weathers { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public ICollection<Meal> Meals { get; set; }

        public ICollection<Consume> Consumes { get; set; }

        public ICollection<Sleep> Sleeps { get; set; }

        public ICollection<EntryDate> EntryDates { get; set; }

        public ICollection<Medication> Medications { get; set; }

        public ICollection<Supplement> Supplements { get; set; }

        public User User { get; set; }



    }
}
