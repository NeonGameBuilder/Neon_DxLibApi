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
        protected static void VerifyDxLibResult(int result, EnumDxLibApi api)
        {
            if (result == -1)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}", api);
            }
        }
        protected static void VerifyDxLibResult(string result, EnumDxLibApi api)
        {
            if (result == null)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}", api);
            }
        }
        protected static void VerifyDxLibResult(float result, EnumDxLibApi api)
        {
            if (result == -1.0f)
            {
                throw new NeonDxDxLibApiException($"Failed to call DxLib function: {api}", api);
            }
        }

    }
}
