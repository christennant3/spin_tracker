using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SpinTracker.Authorization.Roles;
using SpinTracker.Authorization.Users;
using SpinTracker.MultiTenancy;
using SpinTracker.Weathers;

namespace SpinTracker.EntityFrameworkCore
{
    public class SpinTrackerDbContext : AbpZeroDbContext<Tenant, Role, User, SpinTrackerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Weather> Weathers { get; set; }

        public SpinTrackerDbContext(DbContextOptions<SpinTrackerDbContext> options)
            : base(options)
        {
        }
    }
}
