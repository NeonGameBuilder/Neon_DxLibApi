
namespace NeonDX.DxLibApi
{
    /**
     * ライトタイプ
     */
    public sealed class NDX_LightType : NDX_Object
    {
        private EnumLightType _type;

        /**
         * タイプ
         */
        public EnumLightType Type
        {
            get { return _type; }
            set { _type = value; IsModified = true; }
        }

        /**
         * コンストラクタ
         */
        public NDX_LightType(EnumLightType type)
        {
            _type = type;
        }
    }
}
