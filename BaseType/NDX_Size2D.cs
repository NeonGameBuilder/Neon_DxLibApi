
namespace NeonDX.DxLibApi
{
    /**
     * サイズ
     */
    public sealed class NDX_Size2D : NDX_Object
    {
        private int _width;
        private int _height;

        /**
         * 幅
         */
        public int Width
        {
            get { return _width; }
            set { _width = value; IsModified = true; }
        }

        /**
         * 高さ
         */
        public int Height
        {
            get { return _height; }
            set { _height = value; IsModified = true; }
        }

        /**
         * コンストラクタ
         */
        public NDX_Size2D()
        {
            _width = 0;
            _height = 0;
        }
        public NDX_Size2D(NDX_Size2D size)
        {
            _width = size.Width;
            _height = size.Height;
        }
        public NDX_Size2D(int width, int height)
        {
            _width = width;
            _height = height;
        }

    }
}
