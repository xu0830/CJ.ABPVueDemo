using Abp.Authorization;
using CJ.ABPVueDemo.Authorization.Roles;
using CJ.ABPVueDemo.Authorization.Users;

namespace CJ.ABPVueDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
