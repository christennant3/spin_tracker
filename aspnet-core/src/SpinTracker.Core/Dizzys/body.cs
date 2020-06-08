using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpinTracker.Dizzys
{
    public class Body
    {
        public int BodyId { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int Stress { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int ShoulderStiffness { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int Headache { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class Attack
    {
        public int AttackId { get; set; }

        public bool Vertigo { get; set; }

        public bool Drop { get; set; }

        public bool Electricity { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int VertigoIntensity { get; set; }

        public int VertigoDuration { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int DropIntensity { get; set; }

        [Range(typeof(decimal), "0", "10")]
        public int ElectricityIntensity { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }
    }

    public class Checkin
    {

    }

    public class TimeOfDay
    {

    }

 
}
