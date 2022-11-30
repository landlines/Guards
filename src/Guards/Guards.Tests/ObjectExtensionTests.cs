using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class ObjectExtensionTests
    {
        [Test]
        public void should_throw_on_null()
        {
            string a = null;
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIf(nameof(a), a).Null());
        }

        [Test]
        public void should_not_throw_on_not_null()
        {
            string a = "abc";
            Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(a), a).Null());
        }
    }
}