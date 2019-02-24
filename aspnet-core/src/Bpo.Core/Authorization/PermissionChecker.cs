using Abp.Authorization;
using Bpo.Authorization.Roles;
using Bpo.Authorization.Users;

namespace Bpo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
