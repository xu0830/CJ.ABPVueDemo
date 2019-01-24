using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CJ.ABPVueDemo.Configuration;
using CJ.ABPVueDemo.Web;

namespace CJ.ABPVueDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPVueDemoDbContextFactory : IDesignTimeDbContextFactory<ABPVueDemoDbContext>
    {
        public ABPVueDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPVueDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPVueDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPVueDemoConsts.ConnectionStringName));

            return new ABPVueDemoDbContext(builder.Options);
        }
    }
}
