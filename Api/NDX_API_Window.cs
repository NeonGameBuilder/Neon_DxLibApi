using NeonDX.DxLibApi.Debug;

using static DxLibDLL.DX;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: Window
     */
    public class NDX_API_Window : NDX_API_Base
    {
        /**
         * <sumary>
         * メインウィンドウテキストを変更
         * </sumary>
         * <param name="text">ウィンドウテキスト</param>
         */
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

        /**
         * <sumary>
         * ウィンドウのアイコンを変更
         * </sumary>
         * <param name="icon_id">アイコンID</param>
         */
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

        /**
         * <sumary>
         * ウィンドウモードを変更する
         * </sumary>
         * <param name="window_mode">ウィンドウモードにするかどうか</param>
         */
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

        /**
         * <sumary>
         * ウィンドウメッセージ処理
         * </sumary>
         */
        public static int ProcessMessage()
        {
            int res = DxLibDLL.DX.ProcessMessage();
            return res;
        }

        /**
         * <sumary>
         * ScreenFlip描画対象ウィンドウ指定
         * </sumary>
         * <param name="hwnd">描画対象のウィンドウハンドル</param>
         * <param name="scaleX">X軸方向の描画倍率(デフォルト: 1.0)</param>
         * <param name="scaleY">Y軸方向の描画倍率(デフォルト: 1.0)</param>
         */
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

        /**
         * <sumary>
         * ScreenFlip描画対象ウィンドウ指定
         * </sumary>
         * <param name="hwnd">描画対象のウィンドウハンドル</param>
         */
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

        /**
         * <sumary>
         * Alt+F4や閉じるボタンで終了するかどうかのフラグを設定する
         * </sumary>
         * <param name="enabled">自動的に閉じる(デフォルト: TRUE)</param>
         */
        public static void SetWindowUserCloseEnableFlag(bool enabled)
        {
            int res = DxLibDLL.DX.SetWindowUserCloseEnableFlag(enabled ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetWindowUserCloseEnableFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("enabled", $"{enabled}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetWindowUserCloseEnableFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        /**
         * <sumary>
         * Alt+F4や閉じるボタンが押されたかどうかを取得する
         * </sumary>
         * <param name="StateResetFlag">フラグの読み取り状態をリセットするか(デフォルト: FALSE)</param>
         */
        public static bool GetWindowUserCloseFlag(bool StateResetFlag)
        {
            int res = DxLibDLL.DX.GetWindowUserCloseFlag(StateResetFlag ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_GetWindowUserCloseFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("StateResetFlag", $"{StateResetFlag}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_GetWindowUserCloseFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res == TRUE;
        }

        /**
         * <sumary>
         * 画面のサイズを変更できるようにするかどうかのフラグを設定する
         * </sumary>
         * <param name="Flag">変更を可能にするかどうか(デフォルト: FALSE)</param>
         * <param name="FitScreen">変更を可能にするかどうか(デフォルト: TRUE)</param>
         */
        public static void SetWindowSizeChangeEnableFlag(bool Flag, bool FitScreen)
        {
            int res = DxLibDLL.DX.SetWindowSizeChangeEnableFlag(Flag ? TRUE : FALSE, FitScreen ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Window_SetWindowSizeChangeEnableFlag, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("Flag", $"{Flag}"),
                    new NeonDxCallStack.ApiArg("FitScreen", $"{FitScreen}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Window_SetWindowSizeChangeEnableFlag);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }
    }
}
