//using System.Runtime.InteropServices;

using NeonDX.DxLibApi.Debug;
using static DxLibDLL.DX;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: 2D Graphics
     */
    public class NDX_API_Movie : NDX_API_Base
    {
        // 動画を再生する
        public static void PlayMovie(string FileName, int ExRate, EnumMoviePlayType play_type = EnumMoviePlayType.Normal)
        {
            int PlayType = 0;
            switch (play_type)
            {
                case EnumMoviePlayType.Normal:
                    PlayType = DX_MOVIEPLAYTYPE_NORMAL; break;
                case EnumMoviePlayType.ButtonCancel:
                    PlayType = DX_MOVIEPLAYTYPE_BCANCEL; break;
            }
            int res = DxLibDLL.DX.PlayMovie(FileName, ExRate, PlayType);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Movie_PlayMovie, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("FileName", $"{FileName}"),
                    new NeonDxCallStack.ApiArg("ExRate", $"{ExRate}"),
                    new NeonDxCallStack.ApiArg("play_type", $"{play_type}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Movie_PlayMovie);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 動画を再生する
        public static void PlayMovieToGraph(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.PlayMovieToGraph(GraphHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Movie_PlayMovieToGraph, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GraphHandle", $"{GraphHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Movie_PlayMovieToGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 動画の総フレーム数を取得
        public static int GetMovieTotalFrames(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.GetMovieTotalFrameToGraph(GraphHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Movie_GetMovieTotalFrameToGraph, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GraphHandle", $"{GraphHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Movie_GetMovieTotalFrameToGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 動画の1フレームあたりの時間を取得
        public static long GetMovieOneFrameTime(NDX_Handle GraphHandle)
        {
            long res = DxLibDLL.DX.GetOneFrameTimeMovieToGraph(GraphHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Movie_GetOneFrameTimeMovieToGraphm, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GraphHandle", $"{GraphHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Movie_GetOneFrameTimeMovieToGraphm);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 動画の再生状態を取得
        public static int GetMovieStateToGraph(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.GetMovieStateToGraph(GraphHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Movie_GetMovieStateToGraph, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("GraphHandle", $"{GraphHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Movie_GetMovieStateToGraph);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }
    }
}
