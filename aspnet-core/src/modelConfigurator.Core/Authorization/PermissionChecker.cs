using Abp.Authorization;
using modelConfigurator.Authorization.Roles;
using modelConfigurator.Authorization.Users;

namespace modelConfigurator.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
