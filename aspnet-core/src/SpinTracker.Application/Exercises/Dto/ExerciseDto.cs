using System;
using System.Linq;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;


namespace SpinTracker.Exercises
{
    [AutoMapFrom(typeof(Exercise))]
    public class ExerciseDto : EntityDto<int>
    {
        public string ExerciseType { get; set; }

        public string Duration { get; set; }

        public string Notes { get; set; }

        public int EntryDateId { get; set; }
    }
}