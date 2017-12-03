// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Linq;

namespace System.Data.Entity.Core.Common.Utils
{
    using System.Collections.Generic;
    using System.Data.Entity.Utilities;

    // <summary>
    // An implementation of IEqualityComparer{object} that compares byte[] instances by value, and
    // delegates all other equality comparisons to a specified IEqualityComparer. In the default case,
    // this provides by-value comparison for instances of the CLR equivalents of all EDM primitive types.
    // </summary>
    internal sealed class ByValueEqualityComparer : IEqualityComparer<object>
    {
        // <summary>
        // Provides by-value comparison for instances of the CLR equivalents of all EDM primitive types.
        // </summary>
        internal static readonly ByValueEqualityComparer Default = new ByValueEqualityComparer();

        private ByValueEqualityComparer()
        {
        }

        public new bool Equals(object x, object y)
        {
            if (object.Equals(x, y))
            {
                return true;
            }

            // If x and y are both non-null byte arrays, then perform a by-value comparison
            // based on length and element values, otherwise defer to the default comparison.
            //
            if (x is byte[] xBytes
                && y is byte[] yBytes)
            {
                return CompareBinaryValues(xBytes, yBytes);
            }

            return false;
        }

        public int GetHashCode(object obj)
        {
            if (obj is byte[] bytes)
            {
                return ComputeBinaryHashCode(bytes);
            }
            return obj.GetHashCode();
        }

        internal static int ComputeBinaryHashCode(byte[] bytes)
        {
            DebugCheck.NotNull(bytes);
            var hashCode = 0;
            for (int i = 0, n = Math.Min(bytes.Length, 7); i < n; i++)
            {
                hashCode = ((hashCode << 5) ^ bytes[i]);
            }
            return hashCode;
        }

        internal static bool CompareBinaryValues(byte[] first, byte[] second)
        {
            DebugCheck.NotNull(first);
            DebugCheck.NotNull(second);

            if (first.Length
                != second.Length)
            {
                return false;
            }

            return !first.Where((t, i) => t != second[i]).Any();
        }
    }
}
