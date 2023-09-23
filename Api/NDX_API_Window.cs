using System.Collections.Generic;
//using System.Runtime.InteropServices;

using static DxLibDLL.DX;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: Window
     */
    public class NDX_API_Window : NDX_API_Base
    {
        // メインウィンドウテキストを変更
        public static void SetMainWindowText(string text)
        {
            int res = DxLibDLL.DX.SetMainWindowText(text);
            VerifyDxLibResult(res, "SetMainWindowText");
        }

        // ウィンドウのアイコンを変更
        public static void SetWindowIconID(int icon_id)
        {
            int res = DxLibDLL.DX.SetWindowIconID(icon_id);
            VerifyDxLibResult(res, "SetWindowIconID");
        }

        // ウィンドウモード
        public static EnumChangeScreenResult ChangeWindowMode(bool window_mode)
        {
            int res = DxLibDLL.DX.ChangeWindowMode(window_mode ? TRUE : FALSE);
            VerifyDxLibResult(res, "ChangeWindowMode");

            switch (res)
            {
                case DX_CHANGESCREEN_OK: // モードの移行は成功した
                    return EnumChangeScreenResult.OK;

                case DX_CHANGESCREEN_RETURN: // モードの変更は失敗し、元の画面モードに戻された
                    return EnumChangeScreenResult.Return;

                case DX_CHANGESCREEN_DEFAULT: // モードの変更は失敗しデフォルトの画面モードに変更された
                    return EnumChangeScreenResult.Default;
            }
            throw new NeonDxDxLibApiException($"DxLib returns invalid result: {res}");
        }

        // ウィンドウメッセージ処理
        public static int ProcessMessage()
        {
            int res = DxLibDLL.DX.ProcessMessage();
            return res;
        }

        // ScreenFlip描画対象ウィンドウ指定
        public static void SetScreenFlipTargetWindow(IntPtr hwnd, double scaleX, double scaleY)
        {
            int res = DxLibDLL.DX.SetScreenFlipTargetWindow(hwnd, scaleX, scaleY);
            VerifyDxLibResult(res, "SetScreenFlipTargetWindow");
        }
    }
}
