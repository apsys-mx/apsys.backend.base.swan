using FluentAssertions;
using NUnit.Framework;
using $ext_safeprojectname$.authorization;
using $safeprojectname$;

namespace $safeprojectname$.authorization
{
    internal class ApplicationUserTests : AbstractBaseTests<ApplicationUser>
    {
        [TestCase(null)]
        [TestCase("")]
        public void IsValid_InvalidPartnerNumber_ReturnFalse(string partnerNumber)
        {
            /// Arrange
            this.ClassUnderTest.UserName = partnerNumber;
            /// Act and Assert
            this.ClassUnderTest.IsValid().Should().BeFalse();
        }

        internal override void ArrangeFullEntity()
        {
        }
    }
}
