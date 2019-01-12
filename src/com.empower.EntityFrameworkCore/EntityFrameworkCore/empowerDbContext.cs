using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using com.empower.Authorization.Roles;
using com.empower.Authorization.Users;
using com.empower.MultiTenancy;

namespace com.empower.EntityFrameworkCore
{
    public class empowerDbContext : AbpZeroDbContext<Tenant, Role, User, empowerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public empowerDbContext(DbContextOptions<empowerDbContext> options)
            : base(options)
        {
        }
    }
}
