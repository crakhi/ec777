using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace com.empower.EntityFrameworkCore
{
    public static class empowerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<empowerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<empowerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
