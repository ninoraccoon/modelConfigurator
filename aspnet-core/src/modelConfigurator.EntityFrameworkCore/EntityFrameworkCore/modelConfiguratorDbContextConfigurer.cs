using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace modelConfigurator.EntityFrameworkCore
{
    public static class modelConfiguratorDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<modelConfiguratorDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<modelConfiguratorDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
