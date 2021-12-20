using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FlashTest.Configuration;
using FlashTest.Web;

namespace FlashTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FlashTestDbContextFactory : IDesignTimeDbContextFactory<FlashTestDbContext>
    {
        public FlashTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FlashTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FlashTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FlashTestConsts.ConnectionStringName));

            return new FlashTestDbContext(builder.Options);
        }
    }
}
