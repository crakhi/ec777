using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using com.empower.Configuration;
using com.empower.Web;

namespace com.empower.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class empowerDbContextFactory : IDesignTimeDbContextFactory<empowerDbContext>
    {
        public empowerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<empowerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            empowerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(empowerConsts.ConnectionStringName));

            return new empowerDbContext(builder.Options);
        }
    }
}
