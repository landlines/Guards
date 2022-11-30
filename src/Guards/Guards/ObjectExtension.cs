using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>Object Extension.</summary>
    public static class ObjectExtension
    {
        /// <summary>
        ///     Throw an Exception if an Object is Equal to its Default Value.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert.</typeparam>
        /// <param name="this">An object to assert.</param>
        /// <returns>The asserted object.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the object is equal to its default value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T> Default<T>(in this Guard<T> @this) where T : struct
        {
            return ref @this.Default(null);
        }

        /// <summary>
        ///     Throw an Exception if an Object is Equal to its Default Value.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert.</typeparam>
        /// <param name="this">An object to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted object.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the object is equal to its default value.
        /// </exception>
        public static ref readonly Guard<T> Default<T>(in this Guard<T> @this, string detailMessage) where T : struct
        {
            if (!@this.ParameterArgument.Equals(default(T))) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.ObjectDefault, @this.ParameterName), 
                @this.ParameterName);

        }

        /// <summary>
        ///     Throw an Exception if an Object is a Null Reference.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert.</typeparam>
        /// <param name="this">An object to assert.</param>
        /// <returns>The asserted object.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the object is a null reference.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T> Null<T>(in this Guard<T> @this) where T : class
        {
            return ref @this.Null(null);
        }

        /// <summary>
        ///     Throw an Exception if an Object is a Null Reference.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert.</typeparam>
        /// <param name="this">An object to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted object.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     Thrown if the object is a null reference.
        /// </exception>
        public static ref readonly Guard<T> Null<T>(in this Guard<T> @this, string detailMessage) where T : class
        {
            if (@this.ParameterArgument != null) return ref @this;
            throw new ArgumentNullException(@this.ParameterName, 
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.ObjectNull, @this.ParameterName));

        }
    }
}