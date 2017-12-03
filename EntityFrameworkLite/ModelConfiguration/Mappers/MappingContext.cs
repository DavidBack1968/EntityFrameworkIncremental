// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Mappers
{
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Data.Entity.ModelConfiguration.Configuration;
    using System.Data.Entity.ModelConfiguration.Utilities;
    using System.Data.Entity.Utilities;

    internal sealed class MappingContext
    {
        private readonly ModelConfiguration       _modelConfiguration;
        private readonly ConventionsConfiguration _conventionsConfiguration;
        private readonly EdmModel                 _model;
        private readonly AttributeProvider        _attributeProvider;
        private readonly DbModelBuilderVersion    _modelBuilderVersion;

        public MappingContext(
            ModelConfiguration       modelConfiguration,
            ConventionsConfiguration conventionsConfiguration,
            EdmModel                 model,
            DbModelBuilderVersion    modelBuilderVersion = DbModelBuilderVersion.Latest,
            AttributeProvider        attributeProvider = null)
        {
            DebugCheck.NotNull(modelConfiguration);
            DebugCheck.NotNull(conventionsConfiguration);
            DebugCheck.NotNull(model);

            _modelConfiguration       = modelConfiguration;
            _conventionsConfiguration = conventionsConfiguration;
            _model                    = model;
            _modelBuilderVersion      = modelBuilderVersion;
            _attributeProvider        = attributeProvider ?? new AttributeProvider();
        }

        public ModelConfiguration       ModelConfiguration       => _modelConfiguration;
        public ConventionsConfiguration ConventionsConfiguration => _conventionsConfiguration;
        public EdmModel                 Model                    => _model;
        public AttributeProvider        AttributeProvider        => _attributeProvider;
        public DbModelBuilderVersion    ModelBuilderVersion      => _modelBuilderVersion;
    }
}
