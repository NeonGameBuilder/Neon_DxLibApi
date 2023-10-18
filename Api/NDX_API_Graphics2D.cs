
using NeonDX.DxLibApi.Debug;
using System.ComponentModel;
using System;
using System.Drawing;
using static DxLibDLL.DX;
using static System.Net.Mime.MediaTypeNames;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: 2D Graphics
     */
    public class NDX_API_Graphics2D : NDX_API_Base
    {
        private static Dictionary<int, NDX_Handle> _loaded_graph_handles = new Dictionary<int, NDX_Handle>();

        /**
         * ロード済みハンドルテーブル
         */
        public static int LoadedGraphCount
        {
            get { return _loaded_graph_handles.Count; }
        }

        // 矩形を描画
        public static void DrawBox(int x1, int y1, int x2, int y2, NDX_Color color, bool FillFlag)
        {
            uint ucolor = color.ToColorUint();
            int res = DxLibDLL.DX.DrawBox(x1, y1, x2, y2, ucolor, FillFlag ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawBox, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x1", $"{x1}"),
                    new NeonDxCallStack.ApiArg("y1", $"{y1}"),
                    new NeonDxCallStack.ApiArg("x2", $"{x2}"),
                    new NeonDxCallStack.ApiArg("y2", $"{y2}"),
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                    new NeonDxCallStack.ApiArg("FillFlag", $"{FillFlag}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawBox);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // メモリに読みこんだグラフィックの描画
        public static void DrawGraph(int x, int y, NDX_Handle GrHandle, bool TransFlag)
        {
            int res = DxLibDLL.DX.DrawGraph(x, y, GrHandle.Value, TransFlag ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x", $"{x}"),
                    new NeonDxCallStack.ApiArg("y", $"{y}"),
                    new NeonDxCallStack.ApiArg("GrHandle", $"{GrHandle}"),
                    new NeonDxCallStack.ApiArg("TransFlag", $"{TransFlag}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	メモリに読みこんだグラフィックの拡大縮小描画
        public static void DrawExtendGraph(int x1, int y1, int x2, int y2, NDX_Handle GrHandle, bool TransFlag)
        {
            int res = DxLibDLL.DX.DrawExtendGraph(x1, y1, x2, y2, GrHandle.Value, TransFlag ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawExtendGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x1", $"{x1}"),
                    new NeonDxCallStack.ApiArg("y1", $"{y1}"),
                    new NeonDxCallStack.ApiArg("x2", $"{x2}"),
                    new NeonDxCallStack.ApiArg("y2", $"{y2}"),
                    new NeonDxCallStack.ApiArg("GrHandle", $"{GrHandle}"),
                    new NeonDxCallStack.ApiArg("TransFlag", $"{TransFlag}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawExtendGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // グラフィックのサイズを得る
        public static NDX_Size2D GetGraphSize(NDX_Handle GrHandle)
        {
            int width, height;
            int res = DxLibDLL.DX.GetGraphSize(GrHandle.Value, out width, out height);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_GetGraphSize, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GrHandle", $"{GrHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetGraphSize);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return new NDX_Size2D(width, height);
        }

        // 	画像ファイルのメモリへの読みこみ、及び動画ファイルのロード
        public static NDX_Handle LoadGraph(string FileName)
        {
            int res = DxLibDLL.DX.LoadGraph(FileName);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_LoadGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("FileName", $"{FileName}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_LoadGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            var handle = new NDX_Handle(res);
            _loaded_graph_handles[res] = handle;
            return handle;
        }

        // 	画像ファイルのメモリへの分割読みこみ
        public static List<NDX_Handle> LoadDivGraph(string FileName, int AllNum, int XNum, int YNum, int XSize, int YSize)
        {
            var handles = new List<NDX_Handle>(AllNum);
            int[] buffer = new int[AllNum];
            int res = DxLibDLL.DX.LoadDivGraph(FileName, AllNum, XNum, YNum, XSize, YSize, buffer);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_LoadDivGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("FileName", $"{FileName}"),
                    new NeonDxCallStack.ApiArg("AllNum", $"{AllNum}"),
                    new NeonDxCallStack.ApiArg("XNum", $"{XNum}"),
                    new NeonDxCallStack.ApiArg("YNum", $"{YNum}"),
                    new NeonDxCallStack.ApiArg("XSize", $"{XSize}"),
                    new NeonDxCallStack.ApiArg("YSize", $"{YSize}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_LoadDivGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            for (int i = 0; i < AllNum; i++)
            {
                var handle = new NDX_Handle(buffer[i]);
                handles.Add(handle);
                _loaded_graph_handles[buffer[i]] = handle;
            }
            return handles;
        }

        // 	描画対象にできるグラフィックを作成する
        public static NDX_Handle MakeScreen(int SizeX, int SizeY, bool UseAlphaChannel)
        {
            int res = DxLibDLL.DX.MakeScreen(SizeX, SizeY, UseAlphaChannel ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_MakeScreen, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("SizeX", $"{SizeX}"),
                    new NeonDxCallStack.ApiArg("SizeY", $"{SizeY}"),
                    new NeonDxCallStack.ApiArg("UseAlphaChannel", $"{UseAlphaChannel}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_MakeScreen);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return new NDX_Handle(res);
        }

        // 点を描画する
        public static void DrawPixel(int x, int y, NDX_Color color)
        {
            int res = DxLibDLL.DX.DrawPixel(x, y, color.ToColorUint());

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawPixel, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x", $"{x}"),
                    new NeonDxCallStack.ApiArg("y", $"{y}"),
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawPixel);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	文字列を描画する
        public static void DrawString(int x, int y, string text, NDX_Color color)
        {
            int res = DxLibDLL.DX.DrawString(x, y, text, color.ToColorUint());

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawString, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x", $"{x}"),
                    new NeonDxCallStack.ApiArg("y", $"{y}"),
                    new NeonDxCallStack.ApiArg("text", $"{text}"),
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawString);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 指定のフォントデータで文字列を描画する
        public static void DrawStringToHandle(int x, int y, string text, NDX_Color color, int FontHandle)
        {
            int res = DxLibDLL.DX.DrawStringToHandle(x, y, text, color.ToColorUint(), FontHandle);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawStringToHandle, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x", $"{x}"),
                    new NeonDxCallStack.ApiArg("y", $"{y}"),
                    new NeonDxCallStack.ApiArg("text", $"{text}"),
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                    new NeonDxCallStack.ApiArg("FontHandle", $"{FontHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DrawStringToHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	描画した時の文字列の幅(ドット単位)を得る
        public static int GetDrawStringWidth(string text, int length)
        {
            length = length > 0 ? length : text.Length;
            int res = DxLibDLL.DX.GetDrawStringWidth(text, length);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_GetDrawStringWidth, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("text", $"{text}"),
                    new NeonDxCallStack.ApiArg("length", $"{length}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetDrawStringWidth);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 指定のフォントデータで描画する文字列の幅(ドット単位)を得る
        public static int GetDrawStringWidthToHandle(string text, int length, int FontHandle)
        {
            length = length > 0 ? length : text.Length;
            int res = DxLibDLL.DX.GetDrawStringWidthToHandle(text, length, FontHandle);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_GetDrawStringWidthToHandle, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("text", $"{text}"),
                    new NeonDxCallStack.ApiArg("length", $"{length}"),
                    new NeonDxCallStack.ApiArg("FontHandle", $"{FontHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetDrawStringWidthToHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
            return res;
        }

        // 描画先に設定されているグラフィック領域から指定領域のグラフィックを読みこむ
        public static void GetDrawScreenGraph(int x1, int y1, int x2, int y2, NDX_Handle GrHandle)
        {
            int res = DxLibDLL.DX.GetDrawScreenGraph(x1, y1, x2, y2, GrHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_GetDrawScreenGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("x1", $"{x1}"),
                    new NeonDxCallStack.ApiArg("y1", $"{y1}"),
                    new NeonDxCallStack.ApiArg("x2", $"{x2}"),
                    new NeonDxCallStack.ApiArg("y2", $"{y2}"),
                    new NeonDxCallStack.ApiArg("GrHandle", $"{GrHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetDrawScreenGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 指定のグラフィックをメモリ上から削除する
        public static void DeleteGraph(NDX_Handle GrHandle)
        {
            int res = DxLibDLL.DX.DeleteGraph(GrHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DeleteGraph, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GrHandle", $"{GrHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_DeleteGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 描画先グラフィック領域の指定
        public static void SetDrawScreen(NDX_Handle DrawScreen)
        {
            int res = DxLibDLL.DX.SetDrawScreen(DrawScreen.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_SetDrawScreen, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("DrawScreen", $"{DrawScreen}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_SetDrawScreen);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }
        public static void SetDrawScreen(EnumScreen DrawScreen)
        {
            int scr = 0;
            switch (DrawScreen)
            {
                case EnumScreen.Back: scr = DX_SCREEN_BACK; break;
                case EnumScreen.Front: scr = DX_SCREEN_FRONT; break;
            }
            int res = DxLibDLL.DX.SetDrawScreen(scr);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_SetDrawScreen, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("DrawScreen", $"{DrawScreen}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_SetDrawScreen);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 画面モードの変更
        public static void SetGraphMode(int SizeX, int SizeY, int ColorBitNum)
        {
            int res = DxLibDLL.DX.SetGraphMode(SizeX, SizeY, ColorBitNum);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_SetGraphMode, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("SizeX", $"{SizeX}"),
                    new NeonDxCallStack.ApiArg("SizeY", $"{SizeY}"),
                    new NeonDxCallStack.ApiArg("ColorBitNum", $"{ColorBitNum}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_SetGraphMode);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 現在の画面の大きさとカラービット数を得る
        public static void GetScreenState(out int SizeX, out int SizeY, out int ColorBitDepth)
        {
            int res = DxLibDLL.DX.GetScreenState(out SizeX, out SizeY, out ColorBitDepth);
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetScreenState);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_DrawBox, res, new NeonDxCallStack.ApiArg[]
                {
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_GetScreenState);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 新しいフォントデータを作成
        public static int CreateFontToHandle(string font_name, int Size, int Thick, EnumFontType FontType)
        {
            var map = new Dictionary<EnumFontType, int>()
            {
                { EnumFontType.Normal, DX_FONTTYPE_NORMAL },        // ノーマルフォント
                { EnumFontType.Edge, DX_FONTTYPE_EDGE },            // エッジつきフォント
                { EnumFontType.Antialiasing, DX_FONTTYPE_ANTIALIASING },            // アンチエイリアスフォント
                { EnumFontType.Antialiasing_4x4, DX_FONTTYPE_ANTIALIASING_4X4 },            // アンチエイリアスフォント(4x4サンプリング)
                { EnumFontType.Antialiasing_8x8, DX_FONTTYPE_ANTIALIASING_8X8 },            // アンチエイリアスフォント(8x8サンプリング)
                { EnumFontType.Antialiasing_Edge_4x4, DX_FONTTYPE_ANTIALIASING_EDGE_4X4 },            // アンチエイリアス＆エッジ付きフォント(4x4サンプリング)
                { EnumFontType.Antialiasing_Edge_8x8, DX_FONTTYPE_ANTIALIASING_EDGE_8X8 },            // アンチエイリアス＆エッジ付きフォント(4x4サンプリング)
            };
            int nFontType = map.ContainsKey(FontType) ? map[FontType] : -1;
            int res = DxLibDLL.DX.CreateFontToHandle(font_name, Size, Thick, nFontType);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_CreateFontToHandle, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("font_name", $"{font_name}"),
                    new NeonDxCallStack.ApiArg("Size", $"{Size}"),
                    new NeonDxCallStack.ApiArg("Thick", $"{Thick}"),
                    new NeonDxCallStack.ApiArg("FontType", $"{FontType}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_CreateFontToHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 画面に描かれたものを消去する
        public static void ClearDrawScreen()
        {
            int res = DxLibDLL.DX.ClearDrawScreen();

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_ClearDrawScreen, res, new NeonDxCallStack.ApiArg[]
                {
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_ClearDrawScreen);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

        }

        // フリップ関数、画面の裏ページ（普段は表示されていない）を 表ページ（普段表示されている）に反映する
        public static void ScreenFlip()
        {
            int res = DxLibDLL.DX.ScreenFlip();

            /*
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_ScreenFlip, res, new NeonDxCallStack.ApiArg[]
                {
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_ScreenFlip);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
            */
        }

        // フルスクリーン時に縦横比を維持する
        public static void SetFullScreenResolutionMode(EnumResolutionMode resolution_mode)
        {
            int mode = 0;
            switch (resolution_mode)
            {
                case EnumResolutionMode.Native:
                    mode = DX_FSRESOLUTIONMODE_NATIVE;
                    break;
                case EnumResolutionMode.Desktop:
                    mode = DX_FSRESOLUTIONMODE_DESKTOP;
                    break;
                case EnumResolutionMode.Maximum:
                    mode = DX_FSRESOLUTIONMODE_MAXIMUM;
                    break;
            }
            int res = DxLibDLL.DX.SetFullScreenResolutionMode(mode);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_SetFullScreenResolutionMode, res, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("resolution_mode", $"{resolution_mode}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_SetFullScreenResolutionMode);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

    }
}
