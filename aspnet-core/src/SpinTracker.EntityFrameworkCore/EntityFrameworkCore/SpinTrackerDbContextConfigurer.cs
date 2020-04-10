using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SpinTracker.EntityFrameworkCore
{
    public static class SpinTrackerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SpinTrackerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SpinTrackerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
