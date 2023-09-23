using System;

namespace NeonDX.DxLibApi
{
    /**
     * フォントタイプ
     */
    public enum EnumFontType
    {
        Unknown,

        Normal,                 // ノーマルフォント
        Edge,                   // エッジつきフォント
        Antialiasing,           // アンチエイリアスフォント
        Antialiasing_4x4,       // アンチエイリアスフォント( 4x4サンプリング )
        Antialiasing_8x8,       // アンチエイリアスフォント( 8x8サンプリング )
        Antialiasing_Edge_4x4,  // アンチエイリアス＆エッジ付きフォント( 4x4サンプリング )
        Antialiasing_Edge_8x8,  // アンチエイリアス＆エッジ付きフォント( 8x8サンプリング ) )

    }
}
