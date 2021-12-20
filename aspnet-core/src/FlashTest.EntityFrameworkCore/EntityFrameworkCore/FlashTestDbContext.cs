using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FlashTest.Authorization.Roles;
using FlashTest.Authorization.Users;
using FlashTest.MultiTenancy;

namespace FlashTest.EntityFrameworkCore
{
    public class FlashTestDbContext : AbpZeroDbContext<Tenant, Role, User, FlashTestDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<DisplayNumberHistory.DisplayNumberHistory> DisplayNumberHistories { get; set; }

        public FlashTestDbContext(DbContextOptions<FlashTestDbContext> options)
            : base(options)
        {
        }
    }
}
