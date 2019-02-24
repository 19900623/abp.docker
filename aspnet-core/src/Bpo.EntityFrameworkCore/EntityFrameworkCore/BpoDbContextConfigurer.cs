using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Bpo.EntityFrameworkCore
{
    public static class BpoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BpoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BpoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
