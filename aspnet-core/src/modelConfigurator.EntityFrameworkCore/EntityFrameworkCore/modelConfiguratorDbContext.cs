using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using modelConfigurator.Authorization.Roles;
using modelConfigurator.Authorization.Users;
using modelConfigurator.MultiTenancy;

namespace modelConfigurator.EntityFrameworkCore
{
    public class modelConfiguratorDbContext : AbpZeroDbContext<Tenant, Role, User, modelConfiguratorDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public modelConfiguratorDbContext(DbContextOptions<modelConfiguratorDbContext> options)
            : base(options)
        {
        }
    }
}
