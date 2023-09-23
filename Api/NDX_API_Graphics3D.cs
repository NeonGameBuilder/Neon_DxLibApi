
using static DxLibDLL.DX;

namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: 3D Graphics
     */
    public class NDX_API_Graphics3D : NDX_API_Base
    {
        // 標準ライトの有効、無効をセットする
        public static void SetLightEnable(bool enabled)
        {
            int res = DxLibDLL.DX.SetLightEnable(enabled ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetLightEnable");
        }

        // 標準ライトのアンビエントカラーを設定する
        public static void SetLightAmbColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightAmbColor(fcolor);
            VerifyDxLibResult(res, "SetLightAmbColor");
        }

        // 標準ライトのディフューズカラーを設定する
        public static void SetLightDifColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightDifColor(fcolor);
            VerifyDxLibResult(res, "SetLightDifColor");
        }

        // 標準ライトのスペキュラカラーを設定する
        public static void SetLightSpcColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightSpcColor(fcolor);
            VerifyDxLibResult(res, "SetLightSpcColor");
        }

        // 	標準ライトのタイプをディレクショナルライトにする
        public static void ChangeLightTypeDir(NDX_Vector3D dir)
        {
            VECTOR _dir = new VECTOR() { x = dir.X, y = dir.Y, z = dir.Z };
            int res = DxLibDLL.DX.ChangeLightTypeDir(_dir);
            VerifyDxLibResult(res, "ChangeLightTypeDir");
        }

        // 標準ライトのタイプをポイントライトにする
        public static void ChangeLightTypePoint(NDX_Vector3D pos, float Range, float Atten0, float Atten1, float Atten2)
        {
            VECTOR _pos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            int res = DxLibDLL.DX.ChangeLightTypePoint(_pos, Range, Atten0, Atten1, Atten2);
            VerifyDxLibResult(res, "ChangeLightTypePoint");
        }

        // 標準ライトのタイプをスポットライトにする
        public static void ChangeLightTypeSpot(NDX_Vector3D pos, NDX_Vector3D dir, float OutAngle, float InAngle, float Range, float Atten0, float Atten1, float Atten2)
        {
            VECTOR _pos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            VECTOR _dir = new VECTOR() { x = dir.X, y = dir.Y, z = dir.Z };
            int res = DxLibDLL.DX.ChangeLightTypeSpot(_pos, _dir, OutAngle, InAngle, Range, Atten0, Atten1, Atten2);
            VerifyDxLibResult(res, "ChangeLightTypeSpot");
        }

        // 	ライトハンドルのライトの有効、無効を設定する
        public static void SetLightEnableHandle(int LHandle, bool enabled)
        {
            int res = DxLibDLL.DX.SetLightEnableHandle(LHandle, enabled ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetLightEnableHandle");
        }

        // ライトハンドルのライトのアンビエントカラーを設定する
        public static void SetLightAmbColorHandle(int LHandle, NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightAmbColorHandle(LHandle, fcolor);
            VerifyDxLibResult(res, "SetLightAmbColorHandle");
        }

        // ライトハンドルのタイプを変更する
        public static void SetLightTypeHandle(int LHandle, NDX_LightType LightType)
        {
            var map = new Dictionary<EnumLightType, int>()
            {
                { EnumLightType.DirectionalLight, DX_LIGHTTYPE_DIRECTIONAL },
                { EnumLightType.Point, DX_LIGHTTYPE_POINT },
                { EnumLightType.Spot, DX_LIGHTTYPE_SPOT },
            };
            int ltype = map.ContainsKey(LightType.Type) ? map[LightType.Type] : -1;
            int res = DxLibDLL.DX.SetLightTypeHandle(LHandle, ltype);
            VerifyDxLibResult(res, "SetLightTypeHandle");
        }

        // ライティング計算処理を使用するかどうかを設定する
        public static void SetUseLighting(bool use_light)
        {
            int res = DxLibDLL.DX.SetUseLighting(use_light ? TRUE : FALSE);
            VerifyDxLibResult(res, "SetUseLighting");
        }

        // グローバルアンビエントライトカラーを設定する
        public static void SetGlobalAmbientLight(NDX_Color color)
        {
            COLOR_F fclor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetGlobalAmbientLight(fclor);
            VerifyDxLibResult(res, "SetGlobalAmbientLight");
        }

        // 	モデルの読み込み
        public static NDX_Handle MV1LoadModel(string filename)
        {
            int res = DxLibDLL.DX.MV1LoadModel(filename);
            VerifyDxLibResult(res, "MV1LoadModel");
            var handle = new NDX_Handle(res);
            return handle;
        }

        // モデルで使用しているマテリアルの数を取得する
        public static int MV1GetMaterialNum(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1GetMaterialNum(MHandle.Value);
            VerifyDxLibResult(res, "MV1GetMaterialNum");
            return res;
        }

        // 	モデルのアニメーションの数を取得する
        public static int MV1GetAnimNum(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1GetAnimNum(MHandle.Value);
            VerifyDxLibResult(res, "MV1GetAnimNum");
            return res;
        }

        // 	指定番号のアニメーション名を取得する
        public static string MV1GetAnimName(NDX_Handle MHandle, int AnimIndex)
        {
            string res = DxLibDLL.DX.MV1GetAnimName(MHandle.Value, AnimIndex);
            VerifyDxLibResult(res, "MV1GetAnimName");
            return res;
        }

        // 指定番号のアニメーションの総時間を得る
        public static float MV1GetAnimTotalTime(NDX_Handle MHandle, int AnimIndex)
        {
            float res = DxLibDLL.DX.MV1GetAnimTotalTime(MHandle.Value, AnimIndex);
            VerifyDxLibResult(res, "MV1GetAnimTotalTime");
            return res;
        }

        // 	アニメーションをアタッチする
        public static int MV1AttachAnim(NDX_Handle MHandle, int AnimIndex, int AnimSrcMHandle, bool NameCheck)
        {
            int res = DxLibDLL.DX.MV1AttachAnim(MHandle.Value, AnimIndex, AnimSrcMHandle, NameCheck ? TRUE : FALSE);
            VerifyDxLibResult(res, "MV1AttachAnim");
            return res;
        }

        // 	アタッチしているアニメーションの総時間を取得する
        public static float MV1GetAttachAnimTotalTime(NDX_Handle MHandle, int AttachIndex)
        {
            float res = DxLibDLL.DX.MV1GetAttachAnimTotalTime(MHandle.Value, AttachIndex);
            VerifyDxLibResult(res, "MV1GetAttachAnimTotalTime");
            return res;
        }

        // 	アタッチしているアニメーションの再生時間を設定する
        public static void MV1SetAttachAnimTime(NDX_Handle MHandle, int AttachIndex, float Time)
        {
            int res = DxLibDLL.DX.MV1SetAttachAnimTime(MHandle.Value, AttachIndex, Time);
            VerifyDxLibResult(res, "MV1SetAttachAnimTime");
        }

        // モデルの座標をセットする
        public static void MV1SetPosition(NDX_Handle MHandle, NDX_Vector3D pos)
        {
            VECTOR vpos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            float res = DxLibDLL.DX.MV1SetPosition(MHandle.Value, vpos);
            VerifyDxLibResult(res, "MV1SetPosition");
        }

        // モデルの拡大値をセットする
        public static void MV1SetScale(NDX_Handle MHandle, NDX_Vector3D scale)
        {
            VECTOR vscale = new VECTOR() { x = scale.X, y = scale.Y, z = scale.Z };
            float res = DxLibDLL.DX.MV1SetScale(MHandle.Value, vscale);
            VerifyDxLibResult(res, "MV1SetScale");
        }

        // モデルの回転値をセットする
        public static void MV1SetRotationXYZ(NDX_Handle MHandle, NDX_Vector3D rot)
        {
            VECTOR vrot = new VECTOR() { x = rot.X, y = rot.Y, z = rot.Z };
            float res = DxLibDLL.DX.MV1SetRotationXYZ(MHandle.Value, vrot);
            VerifyDxLibResult(res, "MV1SetRotationXYZ");
        }

        // モデルを描画する
        public static void MV1DrawModel(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1DrawModel(MHandle.Value);
            VerifyDxLibResult(res, "MV1DrawModel");
        }

        // 	モデルを削除する
        public static void MV1DeleteModel(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1DeleteModel(MHandle.Value);
            VerifyDxLibResult(res, "MV1DeleteModel");
        }

        // カメラの視点、注視点を設定する( 上方向はＹ軸から算出 )
        public static void SetCameraPositionAndTarget_UpVecY(NDX_Vector3D pos, NDX_Vector3D look_at)
        {
            VECTOR vpos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            VECTOR vlook_at = new VECTOR() { x = look_at.X, y = look_at.Y, z = look_at.Z };
            int res = DxLibDLL.DX.SetCameraPositionAndTarget_UpVecY(vpos, vlook_at);
            VerifyDxLibResult(res, "SetCameraPositionAndTarget_UpVecY");
        }

        // カメラの 手前クリップ距離と 奥クリップ距離を設定する
        public static void SetCameraNearFar(float Near, float Far)
        {
            int res = DxLibDLL.DX.SetCameraNearFar(Near, Far);
            VerifyDxLibResult(res, "SetCameraNearFar");
        }

        // 指定のマテリアルのトゥーンレンダリングで使用する輪郭線の太さを設定する
        public static void MV1SetMaterialOutLineWidth(NDX_Handle MHandle, int MaterialIndex, float Width)
        {
            int res = DxLibDLL.DX.MV1SetMaterialOutLineWidth(MHandle.Value, MaterialIndex, Width);
            VerifyDxLibResult(res, "MV1SetMaterialOutLineWidth");
        }

        // 指定のマテリアルで法線マップとして使用されているテクスチャ番号を取得する
        public static int MV1GetMaterialNormalMapTexture(NDX_Handle MHandle, int MaterialIndex)
        {
            int res = DxLibDLL.DX.MV1GetMaterialNormalMapTexture(MHandle.Value, MaterialIndex);
            VerifyDxLibResult(res, "MV1GetMaterialNormalMapTexture");
            return res;
        }

    }
}
