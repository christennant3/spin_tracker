using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Medications
{
    public class Medication
    {
        public string Name { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class MedicationList
    {

        // could be used used give some auto fill options for medication name.
        public string Name { get; set; }

        public bool Active { get; set; }
      
    }

    public class Supplements
    {
        public string Name { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class SupplementList
    {

        // could be used used give some auto fill options for supplement name.
        public string Name { get; set; }

        public bool Active { get; set; }

    }
}
