﻿using System;

namespace NeonDX.DxLibApi
{
    /**
     * ワールドタイプ
     */
    public enum EnumWorldType
    {
        Unknown,

        Plain2D,        // 重力なし2D
        Physics2D,      // 重力あり2D
        Plain3D,        // 重力なし3D
        Physics3D,      // 重力あり3D
    }
}
