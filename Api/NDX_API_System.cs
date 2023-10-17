using NeonDX.DxLibApi.Debug;
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

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_SetOutApplicationLogValidFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("enabled", $"{enabled}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_SetOutApplicationLogValidFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // バックグランドでも動作させるか
        public static void SetAlwaysRunFlag(bool flag)
        {
            int res = DxLibDLL.DX.SetAlwaysRunFlag(flag ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_SetAlwaysRunFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("flag", $"{flag}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_SetAlwaysRunFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // マウスカーソル表示
        public static void SetMouseDispFlag(bool show)
        {
            int res = DxLibDLL.DX.SetMouseDispFlag(show ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_SetMouseDispFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("show", $"{show}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_SetMouseDispFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // DXライブラリの初期化
        public static int DxLib_Init()
        {
            int res = DxLibDLL.DX.DxLib_Init();

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_DxLib_Init, res, new NeonDxCallStack.ApiArg[]
                {
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_DxLib_Init);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // DXライブラリの終了処理
        public static void DxLib_End()
        {
            int res = DxLibDLL.DX.DxLib_End();

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_DxLib_End, res, new NeonDxCallStack.ApiArg[]
                {
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_DxLib_End);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ユーザウィンドウ
        public static void SetUserWindow(IntPtr hwnd)
        {
            int res = DxLibDLL.DX.SetUserWindow(hwnd);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.System_SetUserWindow, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("hwnd", $"{hwnd}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.System_SetUserWindow);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }
    }
}
