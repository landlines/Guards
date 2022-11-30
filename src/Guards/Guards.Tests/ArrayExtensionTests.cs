using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [TestCase(new int[] {1, 2, 3}, true)]
        [TestCase(new int[] {1, 2, 3, 4}, false)]
        public void should_throw_on_length_equal_to(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array).LengthEqualTo(3));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array).LengthEqualTo(3));
            }
        }

        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 4}, true)]
        public void should_throw_on_array_greater_than(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array).LengthGreaterThan(3));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array).LengthGreaterThan(3));
            }
        }

        [TestCase(new int[] {1, 2}, false)]
        [TestCase(new int[] {1, 2, 3}, true)]
        [TestCase(new int[] {1, 2, 3, 4}, true)]
        public void should_throw_on_array_greater_than_or_equal_to(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array)
                    .LengthGreaterThanOrEqualTo(3));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array)
                    .LengthGreaterThanOrEqualTo(3));
            }
        }

        [TestCase(new int[] {1, 2, 3}, true)]
        [TestCase(new int[] {1, 2, 3, 4}, false)]
        public void should_throw_on_array_less_than(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array).LengthLessThan(4));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array).LengthLessThan(4));
            }
        }

        [TestCase(new int[] {1, 2}, true)]
        [TestCase(new int[] {1, 2, 3}, true)]
        [TestCase(new int[] {1, 2, 3, 4}, false)]
        public void should_throw_on_array_less_than_or_equal_to(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array)
                    .LengthLessThanOrEqualTo(3));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array)
                    .LengthLessThanOrEqualTo(3));
            }
        }

        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 4}, true)]
        public void should_throw_on_length_not_equal_to(int[] array, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(array), array).LengthNotEqualTo(3));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(array), array).LengthNotEqualTo(3));
            }
        }
    }
}