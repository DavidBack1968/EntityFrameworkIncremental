// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Core.Metadata.Edm
{
    using System.Collections.Generic;
    using System.Data.Entity.Core.Common;
    using System.Data.Entity.Core.Mapping;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Utilities;

    // TODO: METADATA: Rename or remove?
    internal class DbDatabaseMapping
    {
        private readonly List<EntityContainerMapping> _entityContainerMappings
            = new List<EntityContainerMapping>();

        public EdmModel Model    { get; set; }
        public EdmModel Database { get; set; }

        public DbProviderInfo                  ProviderInfo              => Database.ProviderInfo;
        public DbProviderManifest              ProviderManifest         => Database.ProviderManifest;
        internal IList<EntityContainerMapping> EntityContainerMappings => _entityContainerMappings;

        internal void AddEntityContainerMapping(EntityContainerMapping entityContainerMapping)
        {
            Check.NotNull(entityContainerMapping, "entityContainerMapping");

            _entityContainerMappings.Add(entityContainerMapping);
        }
    }
}
