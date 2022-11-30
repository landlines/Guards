using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class ByteExtensionTests
    {
        [TestCase(5, 5, true)]
        [TestCase(4, 5, false)]
        public void should_throw_on_equal_bytes(byte byteA, byte byteB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(byteA), byteA).EqualTo(byteB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byteA), byteA).EqualTo(byteB));
            }
        }

        [TestCase(4, true)]
        [TestCase(5, false)]
        public void should_throw_if_byte_is_even(byte byte1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(byte1), byte1).Even());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte1), byte1).Even());
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_byte_is_greater_than_value(byte byte1, byte byte2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(byte1), byte1)
                    .GreaterThan(byte2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte1), byte1).GreaterThan(byte2));
            }
        }

        [TestCase(2, 4, false)]
        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_byte_is_greater_than_or_equal_to(byte byte1, byte byte2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(byte1), byte1)
                    .GreaterThan(byte2));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte1), byte1).GreaterThan(byte2));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(5, 4, true)]
        public void should_throw_if_byte_is_less_than_value(byte byte1, byte byte2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(byte2), byte2)
                    .LessThan(byte1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte2), byte2).LessThan(byte1));
            }
        }

        [TestCase(5, 6, false)]
        [TestCase(5, 5, true)]
        [TestCase(5, 4, true)]
        public void should_throw_if_byte_is_less_than_or_equal_to(byte byte1, byte byte2, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIf(nameof(byte2), byte2)
                    .LessThanOrEqualTo(byte1));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte2), byte2).LessThanOrEqualTo(byte1));
            }
        }

        [TestCase(5, 5, false)]
        [TestCase(4, 5, true)]
        public void should_throw_on_unequal_bytes(byte byteA, byte byteB, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(byteA), byteA).NotEqualTo(byteB));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byteA), byteA).NotEqualTo(byteB));
            }
        }

        [TestCase(4, false)]
        [TestCase(5, true)]
        public void should_throw_if_byte_is_odd(byte byte1, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => Guard.ThrowIf(nameof(byte1), byte1).Odd());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(byte1), byte1).Odd());
            }
        }

        [TestCase(4, 5, 7, true)]
        [TestCase(5, 5, 7, false)]
        public void should_throw_if_byte_is_outside_set(byte target, byte rangeStart, byte rangeEnd, bool shouldThrow)
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
        public void should_throw_if_byte_is_outside_exclusive_range(byte target, byte rangeStart, byte rangeEnd,
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
        public void should_throw_if_byte_is_outside_inclusive_range(byte target, byte rangeStart, byte rangeEnd,
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
        public void should_throw_if_byte_is_within_set(byte target, byte rangeStart, byte rangeEnd, bool shouldThrow)
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
        public void should_throw_if_byte_is_within_exclusive_range(byte target, byte rangeStart, byte rangeEnd,
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
        public void should_throw_if_byte_is_within_inclusive_range(byte target, byte rangeStart, byte rangeEnd,
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