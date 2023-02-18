﻿// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using Nuke.Common.ValueInjection;

namespace Nuke.Common.Tooling
{
    public abstract class ToolInjectionAttributeBase : ValueInjectionAttributeBase
    {
        public override bool SuppressWarnings => true;
    }
}