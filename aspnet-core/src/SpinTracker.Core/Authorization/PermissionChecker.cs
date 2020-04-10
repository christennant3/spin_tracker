using Abp.Authorization;
using SpinTracker.Authorization.Roles;
using SpinTracker.Authorization.Users;

namespace SpinTracker.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
