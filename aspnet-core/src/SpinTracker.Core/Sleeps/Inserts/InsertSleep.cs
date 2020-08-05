using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Sleeps.Inserts
{
    public class InsertSleep
    {
        public DateTime SleepTime { get; set; }
        public DateTime AwakeTime { get; set; }
        public int SleepQuality { get; set; }
        public bool Sofa { get; set; }

        public bool FellAsleep { get; set; }
        public int EntryDateId { get; set; }
        public EntryDate EntryDate { get; set; }
    }
}
