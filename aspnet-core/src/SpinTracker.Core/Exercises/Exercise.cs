using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Exercises
{
    public class Exercise : Entity<int>
    {

        public string ExerciseType { get; set; }

        public string Duration { get; set; }

        public string Notes { get; set; }

        public int EntryDateId { get; set; }
        public EntryDate EntryDate { get; set; }
    }
}
