using NeonDX.DxLibApi;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス
     */
    public abstract class NDX_API_Base
    {
        public const int TRUE = DxLibDLL.DX.TRUE;
        public const int FALSE = DxLibDLL.DX.FALSE;

        // 結果を検証
        protected static void VerifyDxLibResult(int res, string api)
        {
            if (res == -1)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}");
            }
        }
        protected static void VerifyDxLibResult(string res, string api)
        {
            if (res == null)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}");
            }
        }
        protected static void VerifyDxLibResult(float res, string api)
        {
            if (res == -1.0f)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}");
            }
        }

    }
}
