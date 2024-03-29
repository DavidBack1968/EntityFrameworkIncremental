﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

//using System.Configuration.Provider;

namespace System.Data.Entity.Internal.ConfigFile
{
    using Configuration;
    using Diagnostics.CodeAnalysis;

    // <summary>
    // Represents all Entity Framework related configuration
    // </summary>
    internal class EntityFrameworkSection : ConfigurationSection
    {
        private const string DefaultConnectionFactoryKey = "defaultConnectionFactory";
        private const string ContextsKey                 = "contexts";
        private const string ProviderKey                 = "providers";
        private const string ConfigurationTypeKey        = "codeConfigurationType";
        private const string InterceptorsKey             = "interceptors";
        private const string QueryCacheKey               = "queryCache";

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [ConfigurationProperty(DefaultConnectionFactoryKey)]
        public virtual DefaultConnectionFactoryElement DefaultConnectionFactory
        {
            get => (DefaultConnectionFactoryElement)this[DefaultConnectionFactoryKey];
            set => this[DefaultConnectionFactoryKey] = value;
        }

        [ConfigurationProperty(ConfigurationTypeKey)]
        public virtual string ConfigurationTypeName
        {
            get => (string)this[ConfigurationTypeKey];
            set => this[ConfigurationTypeKey] = value;
        }

        [ConfigurationProperty(ProviderKey)]
        public virtual ProviderCollection Providers => (ProviderCollection)base[ProviderKey];

        [ConfigurationProperty(ContextsKey)]
        public virtual ContextCollection Contexts => (ContextCollection)base[ContextsKey];

        [ConfigurationProperty(InterceptorsKey)]
        public virtual InterceptorsCollection Interceptors => (InterceptorsCollection)base[InterceptorsKey];

        [ConfigurationProperty(QueryCacheKey)]
        public virtual QueryCacheElement QueryCache
        {
            get => (QueryCacheElement)this[QueryCacheKey];
            set => this[QueryCacheKey] = value;
        }
    }
}
