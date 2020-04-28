using Abp.AutoMapper;
using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpinTracker.Weathers
{
    
    public class Weather: Entity<int>    {
        public int WeatherId { get; set; }
        public string Pollen { get; set; }
        public string Barometric { get; set; }
        public int Temperature { get; set; }
        public int WeatherTypeId { get; set; }
        public int WeatherConditionsTypeId { get; set; }
        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }

    }

}

