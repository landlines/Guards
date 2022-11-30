using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>
    ///     DateTime Extensions
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        ///     Throw an exception if a date is in the past.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<DateTime> IsInFuture(in this Guard<DateTime> @this)
        {
            return ref @this.IsInFuture(null);
        }

        /// <summary>
        ///     Throw an exception if a date is in the past.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>       
        public static ref readonly Guard<DateTime> IsInFuture(in this Guard<DateTime> @this, string detailMessage)
        {
            if (@this.ParameterArgument < DateTime.Now) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.DateInFuture, @this.ParameterName,
                    @this.ParameterArgument.ToString("O")));
        }

        /// <summary>
        ///     Throw an exception if a date is in the past using UTC.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<DateTime> IsInFutureUtc(in this Guard<DateTime> @this)
        {
            return ref @this.IsInFuture(null);
        }

        /// <summary>
        ///     Throw an exception if a date is in the past using UTC.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>              
        public static ref readonly Guard<DateTime> IsInFutureUtc(in this Guard<DateTime> @this, string detailMessage)
        {
            var utcTime = @this.ParameterArgument.ToUniversalTime();
            if (utcTime < DateTime.UtcNow) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.DateInFuture, @this.ParameterName,
                    utcTime.ToString("O")));
        }

        /// <summary>
        ///     Throw an exception if a date is in the past.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<DateTime> IsInPast(in this Guard<DateTime> @this)
        {
            return ref @this.IsInPast(null);
        }

        /// <summary>
        ///     Throw an exception if a date is in the past.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>       
        public static ref readonly Guard<DateTime> IsInPast(in this Guard<DateTime> @this, string detailMessage)
        {
            if (@this.ParameterArgument > DateTime.Now) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.DateInPast, @this.ParameterName,
                    @this.ParameterArgument.ToString("O")));
        }

        /// <summary>
        ///     Throw an exception if a date is in the past using UTC.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<DateTime> IsInPastUtc(in this Guard<DateTime> @this)
        {
            return ref @this.IsInPastUtc(null);
        }

        /// <summary>
        ///     Throw an exception if a date is in the past using UTC.
        /// </summary>
        /// <param name="this">A DateTime to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted DateTime</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the DateTime is in the past.
        /// </exception>              
        public static ref readonly Guard<DateTime> IsInPastUtc(in this Guard<DateTime> @this, string detailMessage)
        {
            var utcTime = @this.ParameterArgument.ToUniversalTime();
            if (utcTime > DateTime.UtcNow) return ref @this;
            throw new ArgumentOutOfRangeException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.DateInPast, @this.ParameterName,
                    utcTime.ToString("O")));
        }
    }
}