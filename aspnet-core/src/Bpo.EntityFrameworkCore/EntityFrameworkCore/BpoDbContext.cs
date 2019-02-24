using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bpo.Authorization.Roles;
using Bpo.Authorization.Users;
using Bpo.MultiTenancy;

namespace Bpo.EntityFrameworkCore
{
    public class BpoDbContext : AbpZeroDbContext<Tenant, Role, User, BpoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BpoDbContext(DbContextOptions<BpoDbContext> options)
            : base(options)
        {
        }
    }
}
