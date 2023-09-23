using System;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス : System
     */
    public class NDX_API_System : NDX_API_Base
    {
        // ログファイルを出力するか
        public static void SetOutApplicationLogValidFlag(bool enabled)
        {
            int res = DxLibDLL.DX.SetOutApplicationLogValidFlag(enabled ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetOutApplicationLogValidFlag");
        }

        // バックグランドでも動作させるか
        public static void SetAlwaysRunFlag(bool flag)
        {
            int res = DxLibDLL.DX.SetAlwaysRunFlag(flag ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetAlwaysRunFlag");
        }

        // マウスカーソル表示
        public static void SetMouseDispFlag(bool show)
        {
            int res = DxLibDLL.DX.SetMouseDispFlag(show ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetMouseDispFlag");
        }

        // DXライブラリの初期化
        public static int DxLib_Init()
        {
            int res = DxLibDLL.DX.DxLib_Init();
            VerifyDxLibResult(res, "DxLib_Init");
            return res;
        }

        // DXライブラリの終了処理
        public static void DxLib_End()
        {
            int res = DxLibDLL.DX.DxLib_End();
            VerifyDxLibResult(res, "DxLib_End");
        }

        // ユーザウィンドウ
        public static void SetUserWindow(IntPtr hwnd)
        {
            int res = DxLibDLL.DX.SetUserWindow(hwnd);
            VerifyDxLibResult(res, "SetUserWindow");
        }
    }
}
