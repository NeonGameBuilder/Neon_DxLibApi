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
         * コンストラクタ
         */
        public NDX_Handle(int handle = 0)
        {
            _handle = handle;
        }

    }
}
