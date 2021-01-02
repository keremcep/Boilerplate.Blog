using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boilerplate.EntityFrameworkCore
{
    public static class boilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<boilerplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<boilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
