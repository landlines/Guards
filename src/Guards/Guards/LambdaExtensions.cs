using System;
using System.Runtime.CompilerServices;
using Guards.Common;

namespace Guards
{
    /// <summary>
    /// Lambda assertion extensions.
    /// </summary>
    public static class LambdaExtensions
    {
        /// <summary>
        ///     Throw is the result of the provided lambda is false.
        /// </summary>
        /// <param name="this">An object to assert.</param>
        /// <param name="func">The assertion function.</param>
        /// <typeparam name="T">The object's type.</typeparam>
        /// <returns>The asserted object.</returns>
        /// <exception cref="ArgumentException">Thrown if the assertion function returns false.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T> False<T>(in this Guard<T> @this, Func<T, bool> func)
            where T : class
        {
            return ref @this.False(func, null);
        }

        /// <summary>
        ///     Throw is the result of the provided lambda is false.
        /// </summary>
        /// <param name="this">An object to assert.</param>
        /// <param name="func">The assertion function.</param>
        /// <param name="detailMessage">A detail message describing the reason the exception was thrown.</param>
        /// <typeparam name="T">The object's type.</typeparam>
        /// <returns>The asserted object.</returns>
        /// <exception cref="ArgumentException">Thrown if the assertion function returns false.</exception>       
        public static ref readonly Guard<T> False<T>(in this Guard<T> @this, Func<T, bool> func, string detailMessage)
            where T : class
        {
            if (func.Invoke(@this.ParameterArgument)) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.CustomValidator, @this.ParameterName), 
                @this.ParameterName);
        }

        /// <summary>
        ///     Throw is the result of the provided lambda is true.
        /// </summary>
        /// <param name="this">An object to assert.</param>
        /// <param name="func">The assertion function.</param>
        /// <typeparam name="T">The object's type.</typeparam>
        /// <returns>The asserted object.</returns>
        /// <exception cref="ArgumentException">Thrown if the assertion function returns true.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<T> True<T>(in this Guard<T> @this, Func<T, bool> func)
            where T : class
        {
            return ref @this.True(func, null);
        }

        /// <summary>
        ///     Throw is the result of the provided lambda is true.
        /// </summary>
        /// <param name="this">An object to assert.</param>
        /// <param name="func">The assertion function.</param>
        /// <param name="detailMessage">A detail message describing the reason the exception was thrown.</param>
        /// <typeparam name="T">The object's type.</typeparam>
        /// <returns>The asserted object.</returns>
        /// <exception cref="ArgumentException">Thrown if the assertion function returns true.</exception>
        public static ref readonly Guard<T> True<T>(in this Guard<T> @this, Func<T, bool> func, string detailMessage)
            where T : class
        {
            if (!func.Invoke(@this.ParameterArgument)) return ref @this;
            throw new ArgumentException(
                detailMessage ?? ErrorFormatter.GetDefaultMessage(MessageType.CustomValidator, @this.ParameterName), 
                @this.ParameterName);
        }
    }
}