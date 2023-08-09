using FluentAssertions;
using NUnit.Framework;
using $ext_safeprojectname$.authorization;
using $safeprojectname$;

namespace $ext_safeprojectname$.authorization
{
    internal class ApplicationRoleTests : AbstractBaseTests<ApplicationRole>
    {
        [TestCase(null)]
        [TestCase("")]
        public void IsValid_InvalidNumber_ReturnFalse(string roleNumber)
        {
            /// Arrange
            this.ClassUnderTest.Name = roleNumber;
            /// Act and Assert
            this.ClassUnderTest.IsValid().Should().BeFalse();
        }

        internal override void ArrangeFullEntity()
        {
        }
    }
}
