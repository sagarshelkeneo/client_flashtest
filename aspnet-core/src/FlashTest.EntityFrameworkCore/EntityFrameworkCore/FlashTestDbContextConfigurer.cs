using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FlashTest.EntityFrameworkCore
{
    public static class FlashTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FlashTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FlashTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
