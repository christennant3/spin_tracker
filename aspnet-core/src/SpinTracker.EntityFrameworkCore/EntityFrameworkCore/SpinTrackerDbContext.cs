using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SpinTracker.Authorization.Roles;
using SpinTracker.Authorization.Users;
using SpinTracker.MultiTenancy;
using SpinTracker.Weathers;
using SpinTracker.Sleeps;
using SpinTracker.EntryDates;

namespace SpinTracker.EntityFrameworkCore
{
    public class SpinTrackerDbContext : AbpZeroDbContext<Tenant, Role, User, SpinTrackerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<WeatherType> WeatherTypes { get; set; }
        public DbSet<Sleep> Sleeps { get; set; }

        public DbSet<EntryDate> EntryDates { get; set; }

        public SpinTrackerDbContext(DbContextOptions<SpinTrackerDbContext> options)
            : base(options)
        {
        }
    }
}
