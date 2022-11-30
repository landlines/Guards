using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void should_throw_on_empty_string()
        {
            var str = string.Empty;
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str).Empty());
        }

        [TestCase(null, true)]
        [TestCase("  ", true)]
        [TestCase("guards.dev", false)]
        [TestCase("www.a.domain.co.uk", false)]
        public void should_throw_on_invalid_domain(string domain, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(domain), domain)
                    .InvalidDomain());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(domain),domain)
                    .InvalidDomain());
            }
        }

        [TestCase("alice@domain.com", false)]
        [TestCase("bob@domain.co.uk", false)]
        [TestCase("sally@ai", false)]
        [TestCase("jane@a.b.domain.com", false)]
        [TestCase("mary", true)]
        public void should_throw_on_invalid_email(string address, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(address), address)
                    .InvalidEmail());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(address),address)
                    .InvalidEmail());
            }
        }

        [TestCase(6, false)]
        [TestCase(5, false)]
        [TestCase(4, true)]
        public void should_throw_on_string_length(int maxLength, bool shouldThrow)
        {
            const string str = "Hello";
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str)
                    .LongerThan(maxLength));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(str), str).LongerThan(maxLength));
            }
        }

        [TestCase(6, true)]
        [TestCase(5, false)]
        [TestCase(4, false)]
        public void should_throw_on_string_shorter(int minLength, bool shouldThrow)
        {
            const string str = "Hello";
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str)
                    .ShorterThan(minLength));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(str), str).ShorterThan(minLength));
            }
        }
        
        [Test]
        public void should_throw_on_whitespace_string()
        {
            const string str = "    ";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str).Whitespace());
        }
    }
}