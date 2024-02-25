using System;

namespace NeonDX.DxLibApi
{
    /**
     * ハンドル
     */
    public sealed class NDX_Handle
    {
        private EnumHandleType _type;
        private int _handle;

        /**
         * ハンドルタイプ
         */
        public EnumHandleType Type
        {
            get { return _type; }
        }

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
        public NDX_Handle(EnumHandleType type = EnumHandleType.Null, int handle = 0)
        {
            _type = type;
            _handle = handle;
        }

        /**
         * 文字列表現
         */
        public override string ToString()
        {
            return $"Handle({_type},{_handle})";
        }
    }
}
