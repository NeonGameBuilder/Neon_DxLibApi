
namespace NeonDX.DxLibApi
{
    /**
     * NeonDx基本オブジェクト
     */
    public abstract class NDX_Object
    {
        private bool _modified = false;

        private NDX_Handle _handle;

        /**
         * 前回の描画フレームから変更されたか
         */
        public bool IsModified
        {
            get { return _modified; }
            set { _modified = value; }
        }

        /**
         * ハンドル
         */
        public NDX_Handle Handle
        {
            get { return _handle; }
            set { _handle = value; }
        }

        /**
         * コンストラクタ
         */
        public NDX_Object()
        {
            _handle = NDX_Handle.Null;
        }
        public NDX_Object(NDX_Handle handle)
        {
            _handle = handle;
        }

        /**
         * 初期化
         */
        public virtual void Init()
        {
        }

        /**
         * 更新
         */
        public virtual void Update()
        {
        }

        /**
         * 終了処理
         */
        public virtual void Terminate()
        {
        }

    }
}
