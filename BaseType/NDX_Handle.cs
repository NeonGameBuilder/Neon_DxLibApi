using System;

namespace NeonDX.DxLibApi
{
    /**
     * ハンドル
     */
    public sealed class NDX_Handle
    {
        private int _handle;

        /**
         * ハンドル値
         */
        public int Value
        {
            get { return _handle; }
        }

        /**
         * NULLハンドル
         */
        public static NDX_Handle Null
        {
            get { return new NDX_Handle(); }
        }

        /**
         * コンストラクタ
         */
        public NDX_Handle(int handle = 0)
        {
            _handle = handle;
        }

    }
}
