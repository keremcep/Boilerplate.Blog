using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using boilerplate.Configuration;
using boilerplate.Web;

namespace boilerplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class boilerplateDbContextFactory : IDesignTimeDbContextFactory<boilerplateDbContext>
    {
        public boilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<boilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            boilerplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(boilerplateConsts.ConnectionStringName));

            return new boilerplateDbContext(builder.Options);
        }
    }
}
