using NeonDX.DxLibApi.Debug;
using System.Collections.Generic;
//using System.Runtime.InteropServices;

using static DxLibDLL.DX;
using static System.Net.Mime.MediaTypeNames;

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

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetMainWindowText, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("text", $"{text}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetMainWindowText);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ウィンドウのアイコンを変更
        public static void SetWindowIconID(int icon_id)
        {
            int res = DxLibDLL.DX.SetWindowIconID(icon_id);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetWindowIconID, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("icon_id", $"{icon_id}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetWindowIconID);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ウィンドウモード
        public static EnumChangeScreenResult ChangeWindowMode(bool window_mode)
        {
            int res = DxLibDLL.DX.ChangeWindowMode(window_mode ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_ChangeWindowMode, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("window_mode", $"{window_mode}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_ChangeWindowMode);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            switch (res)
            {
                case DX_CHANGESCREEN_OK: // モードの移行は成功した
                    return EnumChangeScreenResult.OK;

                case DX_CHANGESCREEN_RETURN: // モードの変更は失敗し、元の画面モードに戻された
                    return EnumChangeScreenResult.Return;

                case DX_CHANGESCREEN_DEFAULT: // モードの変更は失敗しデフォルトの画面モードに変更された
                    return EnumChangeScreenResult.Default;
            }
            throw new NeonDxDxLibApiException($"DxLib returns invalid result: {res}", EnumDxLibApi.Window_ChangeWindowMode);
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

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetScreenFlipTargetWindow, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("hwnd", $"{hwnd}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetScreenFlipTargetWindow);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ScreenFlip描画対象ウィンドウ指定
        public static void SetScreenFlipTargetWindow(IntPtr hwnd)
        {
            int res = DxLibDLL.DX.SetScreenFlipTargetWindow(hwnd);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetScreenFlipTargetWindow, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("hwnd", $"{hwnd}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetScreenFlipTargetWindow);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }
    }
}
