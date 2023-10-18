using System;

namespace NeonDX.DxLibApi
{
    /**
     * 解像度モード
     */
    public enum EnumResolutionMode
    {
        Native,             // モニターの解像度を SetGraphMode で指定した解像度に変更するモード 
        Desktop,            // モニターの解像度をデスクトップ画面と同じにして SetGraphMode で指定した解像度の画面を拡大して表示するモード（デフォルト）
        Maximum,            // モニターの解像度を最大にして、SetGraphMode で指定した解像度の画面を拡大して表示するモード
    }
}
