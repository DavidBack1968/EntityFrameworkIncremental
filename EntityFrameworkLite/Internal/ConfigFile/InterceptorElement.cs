// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal.ConfigFile
{
    using System.Configuration;
    using System.Data.Entity.Infrastructure.DependencyResolution;
    using System.Data.Entity.Infrastructure.Interception;
    using System.Data.Entity.Resources;
    using System.Data.Entity.Utilities;

    internal class InterceptorElement : ConfigurationElement
    {
        private const string TypeKey       = "type";
        private const string ParametersKey = "parameters";

        public 
            InterceptorElement(int key)
        {
            Key = key;
        }

        internal int Key { get; }

        [ConfigurationProperty(TypeKey, IsRequired = true)]
        public virtual string TypeName
        {
            get => (string)this[TypeKey];
            set => this[TypeKey] = value;
        }

        [ConfigurationProperty(ParametersKey)]
        public virtual ParameterCollection Parameters => (ParameterCollection)base[ParametersKey];

        public virtual IDbInterceptor CreateInterceptor()
        {
            object instance;
            try
            {
                instance = Activator.CreateInstance(Type.GetType(TypeName, throwOnError: true), Parameters.GetTypedParameterValues());
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(Strings.InterceptorTypeNotFound(TypeName), ex);
            }

            if (!(instance is IDbInterceptor asInterceptor))
            {
                throw new InvalidOperationException(Strings.InterceptorTypeNotInterceptor(TypeName));
            }

            return asInterceptor;
        }
    }
}
