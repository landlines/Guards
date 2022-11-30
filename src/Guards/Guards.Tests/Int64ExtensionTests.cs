using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class Int64ExtensionTests
    {
        [TestCase(5, 5, true)]
        [TestCase(4, 5, false)]
        public void should_throw_on_equal_long(long longA, long longB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(longA), longA).EqualTo(longB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(longA), longA).EqualTo(longB));
            }
        }

        [TestCase(4, true)]
        [TestCase(5, false)]
        public void should_throw_if_long_is_even(long long1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(long1), long1).Even());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long1), long1).Even());
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_long_is_greater_than_value(long long1, long long2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(long1), long1)
                    .GreaterThan(long2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long1), long1).GreaterThan(long2));
            }
        }

        [TestCase(2, 4, false)]
        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_long_is_greater_than_or_equal_to(long long1, long long2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(long1), long1)
                    .GreaterThan(long2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long1), long1).GreaterThan(long2));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_long_is_less_than_value(long long1, long long2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(long2), long2)
                    .LessThan(long1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long2), long2).LessThan(long1));
            }
        }

        [TestCase(5, 6, false)]
        [TestCase(5, 5, true)]
        [TestCase(5, 4, true)]
        public void should_throw_if_long_is_less_than_or_equal_to(long long1, long long2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(long2), long2)
                    .LessThanOrEqualTo(long1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long2), long2).LessThanOrEqualTo(long1));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(4, 5, true)]
        public void should_throw_on_unequal_longs(long longA, long longB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(longA), longA).NotEqualTo(longB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(longA), longA).NotEqualTo(longB));
            }
        }

        [TestCase(4, false)]
        [TestCase(5, true)]
        public void should_throw_if_long_is_odd(long long1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(long1), long1).Odd());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(long1), long1).Odd());
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_long_is_outside_set(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .Outside(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .Outside(rangeStart, rangeEnd));
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(6, 5, 7, false)]
        [TestCase(5, 5, 7, true)]
        public void should_throw_if_long_is_outside_exclusive_range(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .OutsideExclusiveRange(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .OutsideExclusiveRange(rangeStart, rangeEnd));
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(6, 5, 7, false)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_long_is_outside_inclusive_range(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .OutsideInclusiveRange(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .OutsideInclusiveRange(rangeStart, rangeEnd));
            }
        }

        [TestCase(4, 5, 7, false)]
        [TestCase(5, 5, 7, true)]
        public void should_throw_if_long_is_within_set(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .Within(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .Within(rangeStart, rangeEnd));
            }
        }

        [TestCase(4, 5, 7, false)]
        [TestCase(6, 5, 7, true)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_long_is_within_exclusive_range(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .WithinExclusiveRange(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .WithinExclusiveRange(rangeStart, rangeEnd));
            }
        }

        [TestCase(4, 5, 7, false)]
        [TestCase(6, 5, 7, true)]
        [TestCase(5, 5, 7, true)]
        public void should_throw_if_long_is_within_inclusive_range(long target, long rangeStart, long rangeEnd,
            bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(target), target)
                    .WithinInclusiveRange(rangeStart, rangeEnd));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(target), target)
                    .WithinInclusiveRange(rangeStart, rangeEnd));
            }
        }
    }
}