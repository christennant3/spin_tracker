using SpinTracker.Checkins;
using SpinTracker.Treatments;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Conditions
{
    public class Condition
    {
        public int ConditionId { get; set; }

        public string ConditionName { get; set; }

        public bool Active { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public ICollection<Checkin> Checkins { get; set; }

    }
}
