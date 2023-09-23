//using System.Runtime.InteropServices;

using static DxLibDLL.DX;

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
            VerifyDxLibResult(res, "PlayMovie");
        }

        // 動画を再生する
        public static void PlayMovieToGraph(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.PlayMovieToGraph(GraphHandle.Value);
            VerifyDxLibResult(res, "PlayMovieToGraph");
        }

        // 動画の総フレーム数を取得
        public static int GetMovieTotalFrames(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.GetMovieTotalFrameToGraph(GraphHandle.Value);
            VerifyDxLibResult(res, "GetMovieTotalFrameToGraph");
            return res;
        }

        // 動画の1フレームあたりの時間を取得
        public static long GetMovieOneFrameTime(NDX_Handle GraphHandle)
        {
            long res = DxLibDLL.DX.GetOneFrameTimeMovieToGraph(GraphHandle.Value);
            VerifyDxLibResult(res, "GetOneFrameTimeMovieToGraph");
            return res;
        }

        // 動画の再生状態を取得
        public static int GetMovieStateToGraph(NDX_Handle GraphHandle)
        {
            int res = DxLibDLL.DX.GetMovieStateToGraph(GraphHandle.Value);
            VerifyDxLibResult(res, "GetMovieStateToGraph");
            return res;
        }
    }
}
