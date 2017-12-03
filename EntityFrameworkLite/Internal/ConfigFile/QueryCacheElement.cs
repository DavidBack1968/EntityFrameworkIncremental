// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal.ConfigFile
{
    using Configuration;
    using Diagnostics.CodeAnalysis;

    [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses")]
    internal class QueryCacheElement : ConfigurationElement
    {
        private const string SizeKey                      = "size";
        private const string CleaningIntervalInSecondsKey = "cleaningIntervalInSeconds";

        [ConfigurationProperty(SizeKey),
        IntegerValidator(MinValue = 0, MaxValue = Int32.MaxValue)]
        public int Size
        {
            get => (int)this[SizeKey];
            set => this[SizeKey] = value;
        }

        [ConfigurationProperty(CleaningIntervalInSecondsKey),
        IntegerValidator(MinValue = 0, MaxValue = Int32.MaxValue)]
        public int CleaningIntervalInSeconds
        {
            get => (int)this[CleaningIntervalInSecondsKey];
            set => this[CleaningIntervalInSecondsKey] = value;
        }
    }
}
