using System;

namespace NeonDX.DxLibApi
{
    public enum EnumChangeScreenResult
    {
        OK,             // モードの移行は成功した
        Return,         // モードの変更は失敗し、元の画面モードに戻された
        Default,        // モードの変更は失敗しデフォルトの画面モードに変更された
    }
}
