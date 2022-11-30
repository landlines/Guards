using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>8-Bit Integer Extension.</summary>
    public static class ByteExtension
    {
        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> EqualTo(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.EqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> EqualTo(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument != comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefEqual, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is an even value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> Even(in this Guard<byte> @this)
        {
            return ref @this.Even(null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is an even value.
        /// </exception>
        public static ref readonly Guard<byte> Even(in this Guard<byte> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1) != 0) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefEven, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is greater than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> GreaterThan(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.GreaterThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is greater than the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> GreaterThan(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument <= comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefGreaterThan, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is greater than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> GreaterThanOrEqualTo(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.GreaterThanOrEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is greater than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> GreaterThanOrEqualTo(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument < comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefGreaterThanOrEqual, 
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is less than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> LessThan(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.LessThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is less than the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> LessThan(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument >= comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefLessThan, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is less than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> LessThanOrEqualTo(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.LessThanOrEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is less than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> LessThanOrEqualTo(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument > comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefLessThanOrEqual,
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is not equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> NotEqualTo(in this Guard<byte> @this, in byte comparandValue)
        {
            return ref @this.NotEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 8-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is not equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<byte> NotEqualTo(in this Guard<byte> @this, in byte comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == comparandValue) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefNotEqual,
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is an odd value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> Odd(in this Guard<byte> @this)
        {
            return ref @this.Odd(null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is an odd value.
        /// </exception>
        public static ref readonly Guard<byte> Odd(in this Guard<byte> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1) != 1) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefOdd, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> Outside(in this Guard<byte> @this, params byte[] set)
        {
            return ref @this.Outside(null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the set of values.
        /// </exception>
        public static ref readonly Guard<byte> Outside(in this Guard<byte> @this, string detailMessage,
            params byte[] set)
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
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefOutside, @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> OutsideExclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound)
        {
            return ref @this.OutsideExclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<byte> OutsideExclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound, string detailMessage)
        {
            if (@this.ParameterArgument > lowerBound && @this.ParameterArgument < upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefOutsideExclusive,
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> OutsideInclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound)
        {
            return ref @this.OutsideInclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<byte> OutsideInclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound, string detailMessage)
        {
            if (@this.ParameterArgument >= lowerBound && @this.ParameterArgument <= upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefOutsideInclusive,
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> Within(in this Guard<byte> @this, params byte[] set)
        {
            return ref @this.Within(null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the set of values.
        /// </exception>
        public static ref readonly Guard<byte> Within(in this Guard<byte> @this, string detailMessage,
            params byte[] set)
        {
            for (var index = 0; index < set.Length; ++index)
            {
                ref var local = ref set[index];
                if (@this.ParameterArgument != local) continue;
                throw new ArgumentOutOfRangeException(@this.ParameterName, 
                    detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefWithin,
                        @this.ParameterName));
            }

            return ref @this;
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> WithinExclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound)
        {
            return ref @this.WithinExclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<byte> WithinExclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound, string detailMessage)
        {
            if (@this.ParameterArgument <= lowerBound || @this.ParameterArgument >= upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefWithinExclusive,
                    @this.ParameterName));
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<byte> WithinInclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound)
        {
            return ref @this.WithinInclusiveRange(in lowerBound, in upperBound, null);
        }

        /// <summary>
        ///     Throw an Exception if a 8-bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 8-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 8-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 8-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<byte> WithinInclusiveRange(in this Guard<byte> @this, in byte lowerBound,
            in byte upperBound, string detailMessage)
        {
            if (@this.ParameterArgument < lowerBound || @this.ParameterArgument > upperBound) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.BriefWithinInclusive,
                    @this.ParameterName));
        }
    }
}