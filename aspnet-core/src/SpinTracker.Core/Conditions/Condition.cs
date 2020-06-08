using SpinTracker.Treatments;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Conditions
{
    public class Condition
    {
        public string ConditionName { get; set; }

        public bool Active { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

    }
}
