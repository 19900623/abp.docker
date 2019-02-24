using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Bpo.Configuration;
using Bpo.Web;

namespace Bpo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BpoDbContextFactory : IDesignTimeDbContextFactory<BpoDbContext>
    {
        public BpoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BpoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BpoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BpoConsts.ConnectionStringName));

            return new BpoDbContext(builder.Options);
        }
    }
}
