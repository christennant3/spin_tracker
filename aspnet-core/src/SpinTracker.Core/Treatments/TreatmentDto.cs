using System;
using System.Linq;

namespace SpinTracker.Treatments.Dto
{
    public class TreatmentDto
    {
        public int TreatmentId { get; set; }

        public string TreatmentName { get; set; }

        public bool Active { get; set; }

        public int ConditionId { get; set; }


    }

    public class TreatmentActiveDto
    {
        public int TreatmentActiveId { get; set; }

        public bool Active { get; set; }

        public int TreatmentId { get; set; }

        public long UserId { get; set; }
    }


    public class TreatmentResultDto
    {
        public int TreatmentResultId { get; set; }

        public bool Completed { get; set; }

        public int TreatmentId { get; set; }

        public int EntryDateId { get; set; }

    }
}