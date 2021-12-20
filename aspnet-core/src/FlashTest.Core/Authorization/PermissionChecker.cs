using Abp.Authorization;
using FlashTest.Authorization.Roles;
using FlashTest.Authorization.Users;

namespace FlashTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
