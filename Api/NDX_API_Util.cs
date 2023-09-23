using System.Collections.Generic;
//using System.Runtime.InteropServices;

using static DxLibDLL.DX;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス : Util
     */
    public class NDX_API_Util : NDX_API_Base
    {
        // ランダムな値を取得
        public static int GetRand(int max)
        {
            int res = DxLibDLL.DX.GetRand(max);
            return res;
        }

        // FPSを取得
        public static float GetFPS()
        {
            float res = DxLibDLL.DX.GetFPS();
            return res;
        }

        // 高精度タイマー値を取得
        public static long GetNowHiPerformanceCount()
        {
            long res = DxLibDLL.DX.GetNowHiPerformanceCount();
            return res;
        }

        // 指定時間だけ待つ
        public static void WaitTimer(int msec)
        {
            int res = DxLibDLL.DX.WaitTimer(msec);
            VerifyDxLibResult(res, "WaitTimer");
        }

        // 浮動小数点型のカラー値を取得する
        public static COLOR_F GetColorF(float Red, float Green, float Blue, float Alpha)
        {
            COLOR_F res = DxLibDLL.DX.GetColorF(Red, Green, Blue, Alpha);
            return new COLOR_F()
            {
                r = res.r,
                g = res.g,
                b = res.b,
                a = res.a
            };
        }

        // 	色コードを取得する
        public static uint GetColor(int Red, int Green, int Blue)
        {
            uint res = DxLibDLL.DX.GetColor(Red, Green, Blue);
            return res;
        }

        // 	現在時刻を取得する
        public static void GetDateTime(NDX_DateTime datetime)
        {
            DATEDATA dt;
            int res = DxLibDLL.DX.GetDateTime(out dt);
            VerifyDxLibResult(res, "GetDateTime");
            datetime.Year = dt.Year;
            datetime.Month = dt.Mon;
            datetime.Day = dt.Day;
            datetime.Hour = dt.Hour;
            datetime.Minute = dt.Min;
            datetime.Second = dt.Sec;
        }
    }
}
