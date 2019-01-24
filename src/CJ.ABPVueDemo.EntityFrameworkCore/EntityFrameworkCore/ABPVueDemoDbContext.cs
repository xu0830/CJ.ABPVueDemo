using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CJ.ABPVueDemo.Authorization.Roles;
using CJ.ABPVueDemo.Authorization.Users;
using CJ.ABPVueDemo.MultiTenancy;

namespace CJ.ABPVueDemo.EntityFrameworkCore
{
    public class ABPVueDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ABPVueDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPVueDemoDbContext(DbContextOptions<ABPVueDemoDbContext> options)
            : base(options)
        {
        }
    }
}
