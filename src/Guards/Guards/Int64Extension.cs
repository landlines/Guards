using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>64-Bit Integer Extension.</summary>
    public static class Int64Extension
    {
        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> EqualTo(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.EqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<long> EqualTo(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument != comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.Equal, @this.ParameterName,
                    comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is an even value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> Even(in this Guard<long> @this)
        {
            return ref @this.Even(null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is an even value.
        /// </exception>
        public static ref readonly Guard<long> Even(in this Guard<long> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1L) != 0L) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.Even, @this.ParameterName,
                    @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is greater than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> GreaterThan(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.GreaterThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is greater than the comparand value.
        /// </exception>
        public static ref readonly Guard<long> GreaterThan(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument <= comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.GreaterThan, @this.ParameterName,
                    comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is greater than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> GreaterThanOrEqualTo(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.GreaterThanOrEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is greater than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<long> GreaterThanOrEqualTo(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument < comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.GreaterThanOrEqual,
                    @this.ParameterName, comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is less than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> LessThan(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.LessThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is less than the comparand value.
        /// </exception>
        public static ref readonly Guard<long> LessThan(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument >= comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LessThan, @this.ParameterName,
                    comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is less than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> LessThanOrEqualTo(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.LessThanOrEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is less than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<long> LessThanOrEqualTo(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument > comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LessThanOrEqual,
                    @this.ParameterName, comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is not equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> NotEqualTo(in this Guard<long> @this, in long comparandValue)
        {
            return ref @this.NotEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 64-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is not equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<long> NotEqualTo(in this Guard<long> @this, in long comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.NotEqual, @this.ParameterName,
                    comparandValue, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is an odd value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> Odd(in this Guard<long> @this)
        {
            return ref @this.Odd(null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is an odd value.
        /// </exception>
        public static ref readonly Guard<long> Odd(in this Guard<long> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1L) != 1L) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.Odd, @this.ParameterName,
                    @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> Outside(in this Guard<long> @this, params long[] set)
        {
            return ref @this.Outside(null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the set of values.
        /// </exception>
        public static ref readonly Guard<long> Outside(in this Guard<long> @this, string detailMessage,
            params long[] set)
        {
            var flag = false;
            for (var index = 0; index < set.Length; ++index)
            {
                ref var local = ref set[index];
                if (@this.ParameterArgument == local)
                {
                    flag = false;
                    break;
                }

                flag = true;
            }

            if (!flag) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.Outside, @this.ParameterName,
                    set.Join(","), @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> OutsideExclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound)
        {
            return ref @this.OutsideExclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<long> OutsideExclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound, string detailMessage)
        {
            if (@this.ParameterArgument > lowerBound && @this.ParameterArgument < upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.OutsideExclusive,
                    @this.ParameterName, lowerBound, upperBound, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> OutsideInclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound)
        {
            return ref @this.OutsideInclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<long> OutsideInclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound, string detailMessage)
        {
            if (@this.ParameterArgument >= lowerBound && @this.ParameterArgument <= upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.OutsideInclusive,
                    @this.ParameterName, lowerBound, upperBound, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> Within(in this Guard<long> @this, params long[] set)
        {
            return ref @this.Within(null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the set of values.
        /// </exception>
        public static ref readonly Guard<long> Within(in this Guard<long> @this, string detailMessage,
            params long[] set)
        {
            for (var index = 0; index < set.Length; ++index)
            {
                ref var local = ref set[index];
                if (@this.ParameterArgument != local) continue;
                throw new ArgumentOutOfRangeException(@this.ParameterName, 
                    detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.Within, @this.ParameterName,
                        set.Join(","), @this.ParameterArgument));
            }

            return ref @this;
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> WithinExclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound)
        {
            return ref @this.WithinExclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<long> WithinExclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound, string detailMessage)
        {
            if (@this.ParameterArgument <= lowerBound || @this.ParameterArgument >= upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.WithinExclusive,
                    @this.ParameterName, lowerBound, upperBound, @this.ParameterArgument));
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<long> WithinInclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound)
        {
            return ref @this.WithinInclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 64-bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 64-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 64-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 64-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<long> WithinInclusiveRange(in this Guard<long> @this, in long lowerBound,
            in long upperBound, string detailMessage)
        {
            if (@this.ParameterArgument < lowerBound || @this.ParameterArgument > upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.WithinInclusive,
                    @this.ParameterName, lowerBound, upperBound, @this.ParameterArgument));
        }
    }
}