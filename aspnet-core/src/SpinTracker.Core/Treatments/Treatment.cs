using SpinTracker.Authorization.Users;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpinTracker.Treatments
{
    public class Treatment
    {

        //should make this a list of tratments with just a name field and active feald. 
        //Long term could be turned on and off depending on a condition
        public bool Meditation { get; set; }
        public bool Acupuncture { get; set; }

        public bool SelfMassage { get; set; }

        public bool Massage { get; set; }

        public bool Balance { get; set; }

        public bool HearingAids { get; set; }

        public bool WristBand { get; set; }

        public bool Antihistamine { get; set; }

        public bool CbdOil { get; set; }

        public bool CoconutCharcoal { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }

        public ICollection<TreatmentActive> TreatmentActives { get; set; }

    }

    public class TreatmentActive
    {
        public bool Active { get; set; }

        public int TreatmentId { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public TreatmentActive TreatmentActives { get; set; }

    }


}
