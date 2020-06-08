using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Medications
{
    public class Medication       
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class MedicationList
    {

    // could be used used give some auto fill options for medication name.

        public int MedicationListId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
      
    }

    public class Supplement
    {

        public int SupplementId { get; set; }

        public string Name { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class SupplementList
    {

        // could be used used give some auto fill options for supplement name.

        public int SupplementListId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

    }
}
