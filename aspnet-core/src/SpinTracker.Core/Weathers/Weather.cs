using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System.Collections.Generic;

namespace SpinTracker.Weathers
{

    public class Weather: Entity<int>    {
      
        public string Pollen { get; set; }
        public string Barometric { get; set; }
        public int Temperature { get; set; }
        public int WeatherTypeId { get; set; }
        public int EntryDateId { get; set; }

        public WeatherType WeatherType { get; set; }
        public EntryDate EntryDate { get; set; }
   
    }

    public class WeatherType : Entity<int>
    {
      
        public string Name { get; set; }

        public ICollection<Weather> Weathers { get; set; }


    }

}

