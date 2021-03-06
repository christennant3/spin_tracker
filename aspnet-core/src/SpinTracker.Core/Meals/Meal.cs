﻿using Abp.Domain.Entities;
using SpinTracker.EntryDates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpinTracker.Meals
{
    public class Meal : Entity<int>
    {


        public int Salt { get; set; }

        public int Sugar { get; set; }

        public int EntryDateId { get; set; }
        public EntryDate EntryDate { get; set; }

        public MealType MealType { get; set; }

       
    }

    public class Consume : Entity<int>
    {
  
        public int Water { get; set; }

        public int Alcohol { get; set; }

        public int Tobacco { get; set; }

        public int ConsumeUnitWaterId { get; set; }

        public int ConsumeUnitAlcoholId { get; set; }

        public int EntryDateId { get; set; }

        public EntryDate EntryDate { get; set; }

        public ConsumeUnit ConsumeUnit { get; set; }


    }

    public class MealType : Entity<int>
    {

   

        public string Name { get; set; }

        public ICollection<Meal> Meals { get; set; }
    }

    public class ConsumeUnit : Entity<int>
    {


        public string UnitType { get; set; }

        public ICollection<Consume> Consumes { get; set; }
    }

   
}
