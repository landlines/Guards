using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        [TestCase(-5, true)]
        [TestCase(5, false)]
        public void should_throw_on_past_date(int offset, bool shouldThrow)
        {
            var date = DateTime.Now.AddDays(offset);
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(date), date).IsInPast());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(date), date).IsInPast());
            }
        }

        [TestCase(-5, true)]
        [TestCase(5, false)]
        public void should_throw_on_past_date_utc(int offset, bool shouldThrow)
        {
            var date = DateTime.Now.AddDays(offset);
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(date), date).IsInPastUtc());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(date), date).IsInPastUtc());
            }
        }

        [TestCase(-5, false)]
        [TestCase(5, true)]
        public void should_throw_on_future_date(int offset, bool shouldThrow)
        {
            var date = DateTime.Now.AddDays(offset);
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(date), date).IsInFuture());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(date), date).IsInFuture());
            }
        }

        [TestCase(-5, false)]
        [TestCase(5, true)]
        public void should_throw_on_future_date_utc(int offset, bool shouldThrow)
        {
            var date = DateTime.Now.AddDays(offset);
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(date), date).IsInFutureUtc());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(date), date).IsInFutureUtc());
            }
        }
    }
}