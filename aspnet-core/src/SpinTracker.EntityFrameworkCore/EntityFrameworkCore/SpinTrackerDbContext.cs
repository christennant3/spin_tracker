using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SpinTracker.Authorization.Roles;
using SpinTracker.Authorization.Users;
using SpinTracker.MultiTenancy;
using SpinTracker.Weathers;
using SpinTracker.Sleeps;
using SpinTracker.EntryDates;
using SpinTracker.Meals;
using SpinTracker.Conditions;
using SpinTracker.Dizzys;
using SpinTracker.Treatments;
using SpinTracker.Medications;
using SpinTracker.Checkins;
using SpinTracker.Notes;
using SpinTracker.Exercises;

namespace SpinTracker.EntityFrameworkCore
{
    public class SpinTrackerDbContext : AbpZeroDbContext<Tenant, Role, User, SpinTrackerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<WeatherType> WeatherTypes { get; set; }
        public DbSet<Sleep> Sleeps { get; set; }

        public DbSet<EntryDate> EntryDates { get; set; }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealType> MealType { get; set; }

        public DbSet<ConsumeUnit> ConsumeUnits { get; set; }
      
        public DbSet<Consume> Consumes { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<DizzyBody> DizzyBodys { get; set; }

        public DbSet<DizzyAttack> DizzyAttacks { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<TreatmentActive> TreatmentActives { get; set; }
        
        public DbSet<TreatmentResult> TreatmentResults { get; set; }

        public DbSet<Medication> Medications { get; set; }

        public DbSet<MedicationList> MedicationLists { get; set; }

        public DbSet<Supplement> Supplements { get; set; }

        public DbSet<SupplementList> SupplementLists { get; set; }

        public DbSet<Checkin> Checkins { get; set; }

        public DbSet<CheckinScore> checkinScores { get; set; }

        public DbSet<TimeOfDay> TimeOfDays { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Exercise> Exercises { get; set; }





        public SpinTrackerDbContext(DbContextOptions<SpinTrackerDbContext> options)
            : base(options)
        {
        }
    }
}
