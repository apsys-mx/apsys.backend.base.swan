using FluentAssertions;
using NUnit.Framework;
using $ext_safeprojectname$.contracts;

namespace $safeprojectname$
{
    public abstract class AbstractBaseTests<T> where T : AbstractDomainObject, IValidable, ITestable
    {
        protected T ClassUnderTest { get; set; }

        [SetUp]
        public void Setup()
        {
            this.ClassUnderTest = (T)Activator.CreateInstance(typeof(T));
            this.ClassUnderTest.SetMockData();
            this.ArrangeFullEntity();
        }

        [Test]
        public void IsValid_ValidInstance_ReturnTrue()
        {
            var isValid = this.ClassUnderTest.IsValid();
            isValid.Should().BeTrue();
        }

        internal abstract void ArrangeFullEntity();

    }
}