using $ext_safeprojectname$.authorization;
using $ext_safeprojectname$.authorization.daos;

namespace $safeprojectname$
{
    public interface IApplicationUsersRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetByUserName(string userName);
        IdentityUserDao GetFromIdentityServer(string userName);
    }
}
