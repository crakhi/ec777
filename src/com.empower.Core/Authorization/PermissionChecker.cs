using Abp.Authorization;
using com.empower.Authorization.Roles;
using com.empower.Authorization.Users;

namespace com.empower.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
