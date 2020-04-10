using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SpinTracker.Configuration;
using SpinTracker.Web;

namespace SpinTracker.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SpinTrackerDbContextFactory : IDesignTimeDbContextFactory<SpinTrackerDbContext>
    {
        public SpinTrackerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SpinTrackerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SpinTrackerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SpinTrackerConsts.ConnectionStringName));

            return new SpinTrackerDbContext(builder.Options);
        }
    }
}
