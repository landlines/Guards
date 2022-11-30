using System;
using System.IO;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class LambdaExtensionTests
    {
        [Test]
        public void should_throw_on_false_validator()
        {
            string path = "/tmp1";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(path), path)
                .False(Directory.Exists));
        }

        [Test]
        public void should_not_throw_on_false_validator()
        {
            string path = "/tmp";
            Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(path), path)
                .False(Directory.Exists));
        }

        [Test]
        public void should_throw_on_true_validator()
        {
            string path = "/tmp";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(path), path)
                .True(Directory.Exists));
        }

        [Test]
        public void should_not_throw_on_true_validator()
        {
            string path = "/tmp1";
            Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(path), path)
                .True(Directory.Exists));
        }
    }
}