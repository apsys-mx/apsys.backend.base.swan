using MediatR;
using $ext_safeprojectname$.authorization;
using $ext_safeprojectname$.repositories;

namespace $safeprojectname$.users
{
    public static class ApplicationUsersGetter
    {
        /// <summary>
        /// Query class
        /// </summary>
        public class Query : RequestBase<IEnumerable<ApplicationUser>>
        {
            public Query(string requestedBy)
                : base(requestedBy)
            {
            }
        }

        /// <summary>
        /// Handler class
        /// </summary>
        public class Handler : IRequestHandler<Query, IEnumerable<ApplicationUser>>
        {
            private readonly IUnitOfWork _unitOfWork;

            public Handler(IUnitOfWork unitOfWork)
            {
                this._unitOfWork = unitOfWork;
            }

            public Task<IEnumerable<ApplicationUser>> Handle(Query request, CancellationToken cancellationToken)
            {
                var allUsers = this._unitOfWork.Users.Get();
                return Task.FromResult(allUsers);
            }
        }
    }
}
