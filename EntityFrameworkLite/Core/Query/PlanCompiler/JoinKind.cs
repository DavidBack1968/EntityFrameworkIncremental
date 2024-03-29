﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Core.Query.PlanCompiler
{
    // <summary>
    // The only join kinds we care about
    // </summary>
    internal enum JoinKind
    {
        Inner,
        LeftOuter
    }
}
