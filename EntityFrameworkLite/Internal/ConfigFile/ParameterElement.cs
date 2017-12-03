// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal.ConfigFile
{
    using Configuration;
    using Diagnostics.CodeAnalysis;
    using Globalization;

    // <summary>
    // Represents a parameter to be passed to a method
    // </summary>
    internal class ParameterElement : ConfigurationElement
    {
        private const string ValueKey = "value";
        private const string TypeKey  = "type";

        public ParameterElement(int key)
        {
            Key = key;
        }

        internal int Key { get; }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [ConfigurationProperty(ValueKey, IsRequired = true)]
        public string ValueString
        {
            get => (string)this[ValueKey];
            set => this[ValueKey] = value;
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [ConfigurationProperty(TypeKey, DefaultValue = "System.String")]
        public string TypeName
        {
            get => (string)this[TypeKey];
            set => this[TypeKey] = value;
        }

        public object GetTypedParameterValue()
        {
            var type = Type.GetType(TypeName, throwOnError: true);

            return Convert.ChangeType(ValueString, type, CultureInfo.InvariantCulture);
        }
    }
}
