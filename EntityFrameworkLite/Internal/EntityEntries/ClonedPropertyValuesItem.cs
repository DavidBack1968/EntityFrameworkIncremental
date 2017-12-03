// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Internal
{
    // <summary>
    // An implementation of <see cref="IPropertyValuesItem" /> for an item in a <see cref="ClonedPropertyValues" />.
    // </summary>
    internal class ClonedPropertyValuesItem : IPropertyValuesItem
    {
        #region Constructors and fields

        // <summary>
        // Initializes a new instance of the <see cref="ClonedPropertyValuesItem" /> class.
        // </summary>
        // <param name="name"> The name. </param>
        // <param name="value"> The value. </param>
        // <param name="type"> The type. </param>
        // <param name="isComplex">
        // If set to <c>true</c> this item represents a complex property.
        // </param>
        public ClonedPropertyValuesItem(string name, object value, Type type, bool isComplex)
        {
            Name      = name;
            Type      = type;
            IsComplex = isComplex;
            Value     = value;
        }

        #endregion

        #region IPropertyValuesItem implementation

        // <summary>
        // Gets or sets the value of the property represented by this item.
        // </summary>
        // <value> The value. </value>
        public object Value { get; set; }

        // <summary>
        // Gets the name of the property.
        // </summary>
        // <value> The name. </value>
        public string Name { get; }

        // <summary>
        // Gets a value indicating whether this item represents a complex property.
        // </summary>
        // <value>
        // <c>true</c> If this instance represents a complex property; otherwise, <c>false</c> .
        // </value>
        public bool   IsComplex { get; }

        // <summary>
        // Gets the type of the underlying property.
        // </summary>
        // <value> The property type. </value>
        public Type   Type { get; }

        #endregion
    }
}
