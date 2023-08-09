namespace $safeprojectname$
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicationUsersRepository Users { get; }
        IApplicationRolesRepository Roles { get; }
        void Commit();
        void Rollback();
        void ResetTransaction();
        bool IsActiveTransaction();
    }
}
