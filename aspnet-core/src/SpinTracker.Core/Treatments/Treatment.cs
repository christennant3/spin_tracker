using Abp.Domain.Entities;
using SpinTracker.Authorization.Users;
using SpinTracker.Conditions;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpinTracker.Treatments
{
    public class Treatment : Entity<int>
    {

        //public int TreatmentId { get; set; }

        public string TreatmentName { get; set; }

        public bool Active { get; set; }

        public int ConditionId { get; set; }

        public Condition Condition { get; set; }

        public ICollection<TreatmentActive> TreatmentActives { get; set; }


        //should make this a list of tratments with just a name field and active feald. 
        //Long term could be turned on and off depending on a condition


        //public bool Meditation { get; set; }
        //public bool Acupuncture { get; set; }

        //public bool SelfMassage { get; set; }

        //public bool Massage { get; set; }

        //public bool Balance { get; set; }

        //public bool HearingAids { get; set; }

        //public bool WristBand { get; set; }

        //public bool Antihistamine { get; set; }

        //public bool CbdOil { get; set; }

        //public bool CoconutCharcoal { get; set; }

        //public int EntryDateId { get; set; }

        //public EntryDate EntryDate { get; set; }

     

    }

    public class TreatmentActive : Entity<int>
    {
        //public int TreatmentActiveId { get; set; }

        public bool Active { get; set; }

        public int TreatmentId { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public TreatmentActive TreatmentActives { get; set; }

    }

    public class TreatmentResult : Entity<int>
    {
        //public int TreatmentResultId { get; set; }

        public bool Completed { get; set; }

        public int TreatmentId { get; set; }

        public int EntryDateId { get; set; }

        public Treatment Treatment { get; set; }

        public EntryDate EntryDate { get; set; }

    }


}
