using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>Array Extension.</summary>
    public static class ArrayExtension
    {
        /// <summary>
        ///     Throw an Exception if an Array's Length is Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthEqualTo<T>(in this Guard<T[]> @this, in int comparandValue)
        {
            return ref @this.LengthEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthEqualTo<T>(in this Guard<T[]> @this, in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length != comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthEqual, @this.ParameterName,
                    comparandValue, @this.ParameterArgument.Length), @this.ParameterName);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Greater Than a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is greater than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthGreaterThan<T>(in this Guard<T[]> @this, in int comparandValue)
        {
            return ref @this.LengthGreaterThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Greater Than a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is greater than the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthGreaterThan<T>(in this Guard<T[]> @this, in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length <= comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthGreaterThan, @this.ParameterName,
                    comparandValue, @this.ParameterArgument.Length), @this.ParameterName);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is greater than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthGreaterThanOrEqualTo<T>(in this Guard<T[]> @this,
            in int comparandValue)
        {
            return ref @this.LengthGreaterThanOrEqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is greater than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthGreaterThanOrEqualTo<T>(in this Guard<T[]> @this,
            in int comparandValue, string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length < comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthGreaterThanOrEqual,
                    @this.ParameterName, comparandValue, @this.ParameterArgument), @this.ParameterName);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Less Than a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is less than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthLessThan<T>(in this Guard<T[]> @this, in int comparandValue)
        {
            return ref @this.LengthLessThan(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Less Than a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is less than the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthLessThan<T>(in this Guard<T[]> @this, in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length >= comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthLessThan, @this.ParameterName,
                    comparandValue, @this.ParameterArgument.Length), @this.ParameterName);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is less than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthLessThanOrEqualTo<T>(in this Guard<T[]> @this, in int comparandValue)
        {
            return ref @this.LengthLessThanOrEqualTo(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is less than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthLessThanOrEqualTo<T>(in this Guard<T[]> @this, in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length > comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthLessThanOrEqual, 
                    @this.ParameterName, comparandValue, @this.ParameterArgument.Length), @this.ParameterName);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Not Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is not equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T[]> LengthNotEqualTo<T>(in this Guard<T[]> @this, in int comparandValue)
        {
            return ref @this.LengthNotEqualTo(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if an Array's Length is Not Equal to a Comparand Value.
        /// </summary>
        /// <typeparam name="T">The array's type.</typeparam>
        /// <param name="this">An array to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the array's length.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted array.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the array's length is not equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<T[]> LengthNotEqualTo<T>(in this Guard<T[]> @this, in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument.Length == comparandValue) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.LengthNotEqual, @this.ParameterName,
                    comparandValue, @this.ParameterArgument.Length), @this.ParameterName);
        }
    }
}