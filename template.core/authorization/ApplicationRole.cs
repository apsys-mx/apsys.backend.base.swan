using FluentValidation;
using $safeprojectname$.contracts;
using $safeprojectname$.validators;

namespace $safeprojectname$.authorization
{
    public class ApplicationRole : AbstractDomainObject, ITestable
    {
        public virtual string Name { get; set; }

        public override IValidator GetValidator()
            => new ApplicationRoleValidator();

        public virtual void SetMockData()
        {
            Name = "ADMINISTRATOR";
        }
    }
}
