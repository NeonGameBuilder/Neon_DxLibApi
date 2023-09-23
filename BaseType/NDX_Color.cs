using System;
using System.Drawing;

namespace NeonDX.DxLibApi
{
    /**
     * 色（各成分は0.0～1.0）
     */
    public sealed class NDX_Color : NDX_Object
    {
        private float _r;
        private float _g;
        private float _b;
        private float _a;

        /**
         * 赤
         */
        public float R
        {
            get { return _r; }
            set { _r = value; }
        }

        /**
         * 緑
         */
        public float G
        {
            get { return _g; }
            set { _g = value; }
        }

        /**
         * 青
         */
        public float B
        {
            get { return _b; }
            set { _b = value; }
        }

        /**
         * 透明度
         */
        public float A
        {
            get { return _a; }
            set { _a = value; }
        }

        /**
         * 白
         */
        public static NDX_Color White = new NDX_Color(Color.White);

        /**
         * 赤
         */
        public static NDX_Color Red = new NDX_Color(Color.Red);

        /**
         * 青
         */
        public static NDX_Color Blue = new NDX_Color(Color.Blue);

        /**
         * 黄色
         */
        public static NDX_Color Yellow = new NDX_Color(Color.Yellow);

        /**
         * マゼンタ
         */
        public static NDX_Color Magenta = new NDX_Color(Color.Magenta);

        /**
         * コンストラクタ
         */
        public NDX_Color(int r, int g, int b)
        {
            _r = ((float)r) / 255.0f;
            _g = ((float)g) / 255.0f;
            _b = ((float)b) / 255.0f;
            _a = 1.0f;
        }
        public NDX_Color(Color color)
        {
            _r = ((float)color.R) / 255.0f;
            _g = ((float)color.G) / 255.0f;
            _b = ((float)color.B) / 255.0f;
            _a = ((float)color.A) / 255.0f;
        }

        /**
         * unsigned int に変換
         */
        public uint ToColorUint()
        {
            return NDX_API_Util.GetColor((int)_r * 255, (int)_g * 255, (int)_b * 255);
        }
    }
}
