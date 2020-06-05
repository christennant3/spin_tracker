using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Sleeps
{
    public class Sleep : Entity<int>
    {
        //public int SleepId { get; set; }
        public DateTime SleepTime { get; set; }
        public DateTime AwakeTime { get; set; }
        public int SleepQuality { get; set; }
       
        public int EntryDateId { get; set; }
        public EntryDate EntryDate { get; set; }

    }
}
