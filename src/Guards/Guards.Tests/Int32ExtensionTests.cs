using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class Int32ExtensionTests
    {
        [TestCase(5, 5, true)]
        [TestCase(4, 5, false)]
        public void should_throw_on_equal_int(int intA, int intB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(intA), intA).EqualTo(intB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(intA), intA).EqualTo(intB));
            }
        }

        [TestCase(4, true)]
        [TestCase(5, false)]
        public void should_throw_if_int_is_even(int int1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(int1), int1).Even());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int1), int1).Even());
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_int_is_greater_than_value(int int1, int int2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(int1), int1)
                    .GreaterThan(int2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int1), int1).GreaterThan(int2));
            }
        }

        [TestCase(2, 4, false)]
        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_int_is_greater_than_or_equal_to(int int1, int int2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(int1), int1)
                    .GreaterThan(int2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int1), int1).GreaterThan(int2));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_int_is_less_than_value(int int1, int int2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(int2), int2)
                    .LessThan(int1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int2), int2).LessThan(int1));
            }
        }

        [TestCase(5, 6, false)]
        [TestCase(5, 5, true)]
        [TestCase(5, 4, true)]
        public void should_throw_if_int_is_less_than_or_equal_to(int int1, int int2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(int2), int2)
                    .LessThanOrEqualTo(int1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int2), int2).LessThanOrEqualTo(int1));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(4, 5, true)]
        public void should_throw_on_unequal_ints(int intA, int intB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(intA), intA).NotEqualTo(intB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(intA), intA).NotEqualTo(intB));
            }
        }

        [TestCase(4, false)]
        [TestCase(5, true)]
        public void should_throw_if_int_is_odd(int int1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(int1), int1).Odd());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(int1), int1).Odd());
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_int_is_outside_set(int target, int rangeStart, int rangeEnd,
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
        public void should_throw_if_int_is_outside_exclusive_range(int target, int rangeStart, int rangeEnd,
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
        public void should_throw_if_int_is_outside_inclusive_range(int target, int rangeStart, int rangeEnd,
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
        public void should_throw_if_int_is_within_set(int target, int rangeStart, int rangeEnd,
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
        public void should_throw_if_int_is_within_exclusive_range(int target, int rangeStart, int rangeEnd,
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
        public void should_throw_if_int_is_within_inclusive_range(int target, int rangeStart, int rangeEnd,
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