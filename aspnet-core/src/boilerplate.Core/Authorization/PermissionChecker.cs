using Abp.Authorization;
using boilerplate.Authorization.Roles;
using boilerplate.Authorization.Users;

namespace boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
