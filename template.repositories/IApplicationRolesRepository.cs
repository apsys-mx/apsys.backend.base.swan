using $ext_safeprojectname$.authorization;

namespace $safeprojectname$
{
    public interface IApplicationRolesRepository : IRepository<ApplicationRole>
    {
        ApplicationRole GetByName(string name);
        void AddUserToRole(string userName, string roleName);
    }
}
