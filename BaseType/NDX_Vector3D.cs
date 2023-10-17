
namespace NeonDX.DxLibApi
{
    /**
     * 3Dベクトル
     * 
     * 取得元： NDX_Graphics3D
     */
    public sealed class NDX_Vector3D : NDX_Object
    {
        private float _x;
        private float _y;
        private float _z;

        /**
         * X座標
         */
        public float X
        {
            get { return _x; }
            set { _x = value; IsModified = true; }
        }

        /**
         * Y座標
         */
        public float Y
        {
            get { return _y; }
            set { _y = value; IsModified = true; }
        }

        /**
         * Z座標
         */
        public float Z
        {
            get { return _z; }
            set { _z = value; IsModified = true; }
        }

        /**
         * コンストラクタ
         */
        public NDX_Vector3D()
        {
            _x = 0.0f;
            _y = 0.0f;
            _z = 0.0f;
        }
        public NDX_Vector3D(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /**
         * to string
         */
        public override string ToString()
        {
            return $"<{_x}, {_y}, {_z}>";
        }
    }
}
