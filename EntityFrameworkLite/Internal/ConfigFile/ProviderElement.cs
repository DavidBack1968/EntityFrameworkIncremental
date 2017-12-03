// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal.ConfigFile
{
    using Configuration;

    internal class ProviderElement : ConfigurationElement
    {
        private const string InvariantNameKey = "invariantName";
        private const string TypeKey           = "type";

        [ConfigurationProperty(InvariantNameKey, IsRequired = true)]
        public string InvariantName
        {
            get => (string)this[InvariantNameKey];
            set => this[InvariantNameKey] = value;
        }

        [ConfigurationProperty(TypeKey, IsRequired = true)]
        public string ProviderTypeName
        {
            get => (string)this[TypeKey];
            set => this[TypeKey] = value;
        }
    }
}
