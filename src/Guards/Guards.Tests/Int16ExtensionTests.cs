using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class Int16ExtensionTests
    {
        [TestCase(5, 5, true)]
        [TestCase(4, 5, false)]
        public void should_throw_on_equal_shorts(short shortA, short shortB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(shortA), shortA).EqualTo(shortB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(shortA), shortA).EqualTo(shortB));
            }
        }

        [TestCase(4, true)]
        [TestCase(5, false)]
        public void should_throw_if_short_is_even(short short1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(short1), short1).Even());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short1), short1).Even());
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_short_is_greater_than_value(short short1, short short2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(short1), short1)
                    .GreaterThan(short2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short1), short1).GreaterThan(short2));
            }
        }

        [TestCase(2, 4, false)]
        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_short_is_greater_than_or_equal_to(short short1, short short2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(short1), short1)
                    .GreaterThan(short2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short1), short1).GreaterThan(short2));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_short_is_less_than_value(short short1, short short2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(short2), short2)
                    .LessThan(short1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short2), short2).LessThan(short1));
            }
        }

        [TestCase(5, 6, false)]
        [TestCase(5, 5, true)]
        [TestCase(5, 4, true)]
        public void should_throw_if_short_is_less_than_or_equal_to(short short1, short short2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(short2), short2)
                    .LessThanOrEqualTo(short1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short2), short2).LessThanOrEqualTo(short1));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(4, 5, true)]
        public void should_throw_on_unequal_shorts(short shortA, short shortB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(shortA), shortA).NotEqualTo(shortB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(shortA), shortA).NotEqualTo(shortB));
            }
        }

        [TestCase(4, false)]
        [TestCase(5, true)]
        public void should_throw_if_short_is_odd(short short1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(short1), short1).Odd());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(short1), short1).Odd());
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_short_is_outside_set(short target, short rangeStart, short rangeEnd, bool shouldThrow)
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
        public void should_throw_if_short_is_outside_exclusive_range(short target, short rangeStart, short rangeEnd,
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
        public void should_throw_if_short_is_outside_inclusive_range(short target, short rangeStart, short rangeEnd,
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
        public void should_throw_if_short_is_within_set(short target, short rangeStart, short rangeEnd, bool shouldThrow)
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
        public void should_throw_if_short_is_within_exclusive_range(short target, short rangeStart, short rangeEnd,
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
        public void should_throw_if_short_is_within_inclusive_range(short target, short rangeStart, short rangeEnd,
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