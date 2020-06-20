
using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SpinTracker.Treatments
{
    [AutoMapFrom(typeof(Treatment))]
    public class TreatmentDto : EntityDto<int>
    {
        //public int TreatmentId { get; set; }

        public string TreatmentName { get; set; }

        public bool Active { get; set; }

        public int ConditionId { get; set; }

    }
    [AutoMapFrom(typeof(TreatmentActive))]
    public class TreatmentActiveDto : EntityDto<int>
    {
        //public int TreatmentActiveId { get; set; }

        public bool Active { get; set; }

        public int TreatmentId { get; set; }

        public long UserId { get; set; }
    }

    [AutoMapFrom(typeof(TreatmentResult))]
    public class TreatmentResultDto : EntityDto<int>
    {
        //public int TreatmentResultId { get; set; }

        public bool Completed { get; set; }

        public int TreatmentId { get; set; }

        public int EntryDateId { get; set; }

    }
}