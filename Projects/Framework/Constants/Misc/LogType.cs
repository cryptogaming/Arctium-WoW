﻿// Copyright (c) Arctium Emulation.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Framework.Constants.Misc
{
    [Flags]
    public enum LogType
    {
        None     = 0x0,
        Init     = 0x1,
        Normal   = 0x2,
        Error    = 0x4,
        Debug    = 0x08,
        Packet   = 0x10,
        Database = 0x20,
    }
}
