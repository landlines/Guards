using System.Runtime.CompilerServices;

namespace Guards
{
    /// <summary>Parameter Guard.</summary>
    public static class Guard
    {
        /// <summary>Create a Parameter Guard.</summary>
        /// <typeparam name="T">The type of the parameter to assert.</typeparam>
        /// <param name="parameterName">
        ///     The name of the parameter to assert.
        /// </param>
        /// <param name="parameterArgument">
        ///     The argument passed to the parameter to assert.
        /// </param>
        /// <returns>A Parameter Guard.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guard<T> ThrowIf<T>(string parameterName, T parameterArgument)
        {
            return new Guard<T>(in parameterName, in parameterArgument);
        }
    }
}