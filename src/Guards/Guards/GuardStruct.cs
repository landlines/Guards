using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Guards
{
    /// <summary>Parameter Guard.</summary>
    /// <typeparam name="T">The type of the parameter to assert.</typeparam>
    public readonly struct Guard<T>
    {
        /// <summary>Get Parameter Argument.</summary>
        /// <remarks>
        ///     Represents the argument passed to the parameter to assert.
        /// </remarks>
        public T ParameterArgument { get; }

        /// <summary>Get Parameter Name.</summary>
        /// <remarks>Represents the name of the parameter to assert.</remarks>
        public string ParameterName { get; }

        /// <summary>Create a Parameter Guard.</summary>
        /// <param name="parameterName">
        ///     The name of the parameter to assert.
        /// </param>
        /// <param name="parameterArgument">
        ///     The argument passed to the parameter to assert.
        /// </param>
        public Guard(in string parameterName, in T parameterArgument)
        {
            ParameterArgument = parameterArgument;
            ParameterName = parameterName;
        }

        /// <summary>
        ///     Determine if This Object is Equal to Another Object.
        /// </summary>
        /// <param name="object">
        ///     An object to compare to. Should not be a null reference.
        /// </param>
        /// <returns>
        ///     A boolean true if this object is equal to the object. A boolean false otherwise.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        ///     Thrown always.
        /// </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ExcludeFromCodeCoverage]
        public override bool Equals(object @object)
        {
            throw new NotSupportedException();
        }

        /// <summary>Get Object's Hash Code.</summary>
        /// <returns>The object's hash code.</returns>
        /// <exception cref="T:System.NotSupportedException">
        ///     Thrown always.
        /// </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ExcludeFromCodeCoverage]
        public override int GetHashCode()
        {
            throw new NotSupportedException();
        }

        /// <summary>Get Object's String Representation.</summary>
        /// <returns>The object's string representation.</returns>
        /// <exception cref="T:System.NotSupportedException">
        ///     Thrown always.
        /// </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            throw new NotSupportedException();
        }
    }
}