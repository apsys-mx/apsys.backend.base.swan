using FluentValidation;
using $safeprojectname$.authorization;

namespace $safeprojectname$.validators
{
    public class ApplicationUserValidator : AbstractValidator<ApplicationUser>
    {
        public ApplicationUserValidator()
        {
            RuleFor(x => x.UserName).NotNull().NotEmpty().WithMessage("The [UserName] cannot be null or empty");
        }
    }
}
