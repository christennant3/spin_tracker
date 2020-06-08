using SpinTracker.Conditions;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Checkins
{


    public class Checkin
    {
        public int CheckinId { get; set; }

        public string Name { get; set; }

        public int ConditionId { get; set; }

        public Condition Condition { get; set; }

        public ICollection<CheckinScore> CheckinScores { get; set; }
    }



    public class CheckinScore
    {
        public int CheckinScoreId { get; set; }

        public string Score { get; set; }

        public int CheckinId { get; set; }

        public int EntryDateId { get; set; }

        public int TimeOfDayId { get; set; }

        public EntryDate EntryDate { get; set; }

        public Checkin Checkin { get; set; }

        public TimeOfDay TimeOfDay { get; set; }


    }

    public class TimeOfDay
    {
        public int TimeOfDayId { get; set; }

        public string Name { get; set; }

        public ICollection<CheckinScore> CheckinScores { get; set; }
    }

}


