﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal.ConfigFile
{
    using Configuration;
    using Diagnostics.CodeAnalysis;

    // <summary>
    // Represents setting the default connection factory
    // </summary>
    [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses")]
    internal class 
       DefaultConnectionFactoryElement : ConfigurationElement
    {
        private const string TypeKey       = "type";
        private const string ParametersKey = "parameters";

        [ConfigurationProperty(TypeKey, IsRequired = true)]
        public string FactoryTypeName
        {
            get => (string)this[TypeKey];
            set => this[TypeKey] = value;
        }

        [ConfigurationProperty(ParametersKey)]
        public ParameterCollection Parameters => (ParameterCollection)base[ParametersKey];

        public Type GetFactoryType()
        {
            return Type.GetType(FactoryTypeName, throwOnError: true);
        }
    }
}
