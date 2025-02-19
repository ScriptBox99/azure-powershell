// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Support
{

    /// <summary>The data type of the parameter.</summary>
    public partial struct ParameterType :
        System.IEquatable<ParameterType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType Array = @"Array";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType Boolean = @"Boolean";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType DateTime = @"DateTime";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType Float = @"Float";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType Integer = @"Integer";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType Object = @"Object";

        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType String = @"String";

        /// <summary>the value for an instance of the <see cref="ParameterType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ParameterType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ParameterType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ParameterType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ParameterType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ParameterType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ParameterType && Equals((ParameterType)obj);
        }

        /// <summary>Returns hashCode for enum ParameterType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ParameterType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ParameterType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ParameterType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ParameterType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ParameterType" />.</param>

        public static implicit operator ParameterType(string value)
        {
            return new ParameterType(value);
        }

        /// <summary>Implicit operator to convert ParameterType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ParameterType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ParameterType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e1, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ParameterType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e1, Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType e2)
        {
            return e2.Equals(e1);
        }
    }
}