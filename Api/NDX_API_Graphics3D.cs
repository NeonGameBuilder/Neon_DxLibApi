
using NeonDX.DxLibApi.Debug;
using System.Drawing;
using static DxLibDLL.DX;
using static System.Formats.Asn1.AsnWriter;

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

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightEnable, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("enabled", $"{enabled}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightEnable);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 標準ライトのアンビエントカラーを設定する
        public static void SetLightAmbColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightAmbColor(fcolor);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightAmbColor, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightAmbColor);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 標準ライトのディフューズカラーを設定する
        public static void SetLightDifColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightDifColor(fcolor);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightDifColor, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightDifColor);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 標準ライトのスペキュラカラーを設定する
        public static void SetLightSpcColor(NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightSpcColor(fcolor);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightSpcColor, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightSpcColor);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	標準ライトのタイプをディレクショナルライトにする
        public static void ChangeLightTypeDir(NDX_Vector3D dir)
        {
            VECTOR _dir = new VECTOR() { x = dir.X, y = dir.Y, z = dir.Z };
            int res = DxLibDLL.DX.ChangeLightTypeDir(_dir);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_ChangeLightTypeDir, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("dir", $"{dir}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_ChangeLightTypeDir);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 標準ライトのタイプをポイントライトにする
        public static void ChangeLightTypePoint(NDX_Vector3D pos, float Range, float Atten0, float Atten1, float Atten2)
        {
            VECTOR _pos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            int res = DxLibDLL.DX.ChangeLightTypePoint(_pos, Range, Atten0, Atten1, Atten2);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_ChangeLightTypePoint, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("pos", $"{pos}"),
                    new NeonDxCallStack.ApiArg("Range", $"{Range}"),
                    new NeonDxCallStack.ApiArg("Atten0", $"{Atten0}"),
                    new NeonDxCallStack.ApiArg("Atten1", $"{Atten1}"),
                    new NeonDxCallStack.ApiArg("Atten2", $"{Atten2}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_ChangeLightTypePoint);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 標準ライトのタイプをスポットライトにする
        public static void ChangeLightTypeSpot(NDX_Vector3D pos, NDX_Vector3D dir, float OutAngle, float InAngle, float Range, float Atten0, float Atten1, float Atten2)
        {
            VECTOR _pos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            VECTOR _dir = new VECTOR() { x = dir.X, y = dir.Y, z = dir.Z };
            int res = DxLibDLL.DX.ChangeLightTypeSpot(_pos, _dir, OutAngle, InAngle, Range, Atten0, Atten1, Atten2);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_ChangeLightTypeSpot, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("pos", $"{pos}"),
                    new NeonDxCallStack.ApiArg("dir", $"{dir}"),
                    new NeonDxCallStack.ApiArg("OutAngle", $"{OutAngle}"),
                    new NeonDxCallStack.ApiArg("InAngle", $"{InAngle}"),
                    new NeonDxCallStack.ApiArg("Range", $"{Range}"),
                    new NeonDxCallStack.ApiArg("Atten0", $"{Atten0}"),
                    new NeonDxCallStack.ApiArg("Atten1", $"{Atten1}"),
                    new NeonDxCallStack.ApiArg("Atten2", $"{Atten2}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_ChangeLightTypeSpot);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	ライトハンドルのライトの有効、無効を設定する
        public static void SetLightEnableHandle(int LHandle, bool enabled)
        {
            int res = DxLibDLL.DX.SetLightEnableHandle(LHandle, enabled ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightEnableHandle, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("LHandle", $"{LHandle}"),
                    new NeonDxCallStack.ApiArg("enabled", $"{enabled}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightEnableHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ライトハンドルのライトのアンビエントカラーを設定する
        public static void SetLightAmbColorHandle(int LHandle, NDX_Color color)
        {
            COLOR_F fcolor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetLightAmbColorHandle(LHandle, fcolor);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightAmbColorHandle, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("LHandle", $"{LHandle}"),
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightAmbColorHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
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

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetLightTypeHandle, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("LHandle", $"{LHandle}"),
                    new NeonDxCallStack.ApiArg("LightType", $"{LightType}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetLightTypeHandle);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // ライティング計算処理を使用するかどうかを設定する
        public static void SetUseLighting(bool use_light)
        {
            int res = DxLibDLL.DX.SetUseLighting(use_light ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetUseLighting, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("use_light", $"{use_light}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetUseLighting);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // グローバルアンビエントライトカラーを設定する
        public static void SetGlobalAmbientLight(NDX_Color color)
        {
            COLOR_F fclor = new COLOR_F() { r = color.R, g = color.G, b = color.B, a = color.A };
            int res = DxLibDLL.DX.SetGlobalAmbientLight(fclor);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetGlobalAmbientLight, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("color", $"{color}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetGlobalAmbientLight);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	モデルの読み込み
        public static NDX_Handle MV1LoadModel(string filename)
        {
            int res = DxLibDLL.DX.MV1LoadModel(filename);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1LoadModel, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("filename", $"{filename}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1LoadModel);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            var handle = new NDX_Handle(res);
            return handle;
        }

        // モデルで使用しているマテリアルの数を取得する
        public static int MV1GetMaterialNum(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1GetMaterialNum(MHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetMaterialNum, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetMaterialNum);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 	モデルのアニメーションの数を取得する
        public static int MV1GetAnimNum(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1GetAnimNum(MHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetAnimNum, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetAnimNum);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 	指定番号のアニメーション名を取得する
        public static string MV1GetAnimName(NDX_Handle MHandle, int AnimIndex)
        {
            string res = DxLibDLL.DX.MV1GetAnimName(MHandle.Value, AnimIndex);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetAnimName, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("AnimIndex", $"{AnimIndex}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetAnimName);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 指定番号のアニメーションの総時間を得る
        public static float MV1GetAnimTotalTime(NDX_Handle MHandle, int AnimIndex)
        {
            float res = DxLibDLL.DX.MV1GetAnimTotalTime(MHandle.Value, AnimIndex);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetAnimTotalTime, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("AnimIndex", $"{AnimIndex}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetAnimTotalTime);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 	アニメーションをアタッチする
        public static int MV1AttachAnim(NDX_Handle MHandle, int AnimIndex, int AnimSrcMHandle, bool NameCheck)
        {
            int res = DxLibDLL.DX.MV1AttachAnim(MHandle.Value, AnimIndex, AnimSrcMHandle, NameCheck ? TRUE : FALSE);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1AttachAnim, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("AnimIndex", $"{AnimIndex}"),
                    new NeonDxCallStack.ApiArg("AnimSrcMHandle", $"{AnimSrcMHandle}"),
                    new NeonDxCallStack.ApiArg("NameCheck", $"{NameCheck}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1AttachAnim);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 	アタッチしているアニメーションの総時間を取得する
        public static float MV1GetAttachAnimTotalTime(NDX_Handle MHandle, int AttachIndex)
        {
            float res = DxLibDLL.DX.MV1GetAttachAnimTotalTime(MHandle.Value, AttachIndex);
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetAttachAnimTotalTime);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetAttachAnimTotalTime, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("AttachIndex", $"{AttachIndex}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetAttachAnimTotalTime);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

        // 	アタッチしているアニメーションの再生時間を設定する
        public static void MV1SetAttachAnimTime(NDX_Handle MHandle, int AttachIndex, float Time)
        {
            int res = DxLibDLL.DX.MV1SetAttachAnimTime(MHandle.Value, AttachIndex, Time);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1SetAttachAnimTime, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("AttachIndex", $"{AttachIndex}"),
                    new NeonDxCallStack.ApiArg("Time", $"{Time}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1SetAttachAnimTime);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // モデルの座標をセットする
        public static void MV1SetPosition(NDX_Handle MHandle, NDX_Vector3D pos)
        {
            VECTOR vpos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            float res = DxLibDLL.DX.MV1SetPosition(MHandle.Value, vpos);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1SetPosition, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("pos", $"{pos}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1SetPosition);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // モデルの拡大値をセットする
        public static void MV1SetScale(NDX_Handle MHandle, NDX_Vector3D scale)
        {
            VECTOR vscale = new VECTOR() { x = scale.X, y = scale.Y, z = scale.Z };
            float res = DxLibDLL.DX.MV1SetScale(MHandle.Value, vscale);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics2D_ClearDrawScreen, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("scale", $"{scale}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics2D_ClearDrawScreen);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // モデルの回転値をセットする
        public static void MV1SetRotationXYZ(NDX_Handle MHandle, NDX_Vector3D rot)
        {
            VECTOR vrot = new VECTOR() { x = rot.X, y = rot.Y, z = rot.Z };
            float res = DxLibDLL.DX.MV1SetRotationXYZ(MHandle.Value, vrot);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1SetRotationXYZ, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("rot", $"{rot}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1SetRotationXYZ);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // モデルを描画する
        public static void MV1DrawModel(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1DrawModel(MHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1DrawModel, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1DrawModel);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 	モデルを削除する
        public static void MV1DeleteModel(NDX_Handle MHandle)
        {
            int res = DxLibDLL.DX.MV1DeleteModel(MHandle.Value);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1DeleteModel, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1DeleteModel);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // カメラの視点、注視点を設定する( 上方向はＹ軸から算出 )
        public static void SetCameraPositionAndTarget_UpVecY(NDX_Vector3D pos, NDX_Vector3D look_at)
        {
            VECTOR vpos = new VECTOR() { x = pos.X, y = pos.Y, z = pos.Z };
            VECTOR vlook_at = new VECTOR() { x = look_at.X, y = look_at.Y, z = look_at.Z };
            int res = DxLibDLL.DX.SetCameraPositionAndTarget_UpVecY(vpos, vlook_at);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetCameraPositionAndTarget_UpVecY, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("pos", $"{pos}"),
                    new NeonDxCallStack.ApiArg("look_at", $"{look_at}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetCameraPositionAndTarget_UpVecY);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // カメラの 手前クリップ距離と 奥クリップ距離を設定する
        public static void SetCameraNearFar(float Near, float Far)
        {
            int res = DxLibDLL.DX.SetCameraNearFar(Near, Far);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_SetCameraNearFar, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("Near", $"{Near}"),
                    new NeonDxCallStack.ApiArg("Far", $"{Far}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_SetCameraNearFar);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 指定のマテリアルのトゥーンレンダリングで使用する輪郭線の太さを設定する
        public static void MV1SetMaterialOutLineWidth(NDX_Handle MHandle, int MaterialIndex, float Width)
        {
            int res = DxLibDLL.DX.MV1SetMaterialOutLineWidth(MHandle.Value, MaterialIndex, Width);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1SetMaterialOutLineWidth, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("MaterialIndex", $"{MaterialIndex}"),
                    new NeonDxCallStack.ApiArg("Width", $"{Width}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1SetMaterialOutLineWidth);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }
        }

        // 指定のマテリアルで法線マップとして使用されているテクスチャ番号を取得する
        public static int MV1GetMaterialNormalMapTexture(NDX_Handle MHandle, int MaterialIndex)
        {
            int res = DxLibDLL.DX.MV1GetMaterialNormalMapTexture(MHandle.Value, MaterialIndex);

            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Push(EnumDxLibApi.Graphics3D_MV1GetMaterialNormalMapTexture, new NeonDxCallStack.ApiArg[]
                {
                    new NeonDxCallStack.ApiArg("MHandle", $"{MHandle}"),
                    new NeonDxCallStack.ApiArg("MaterialIndex", $"{MaterialIndex}"),
                });
            }
            VerifyDxLibResult(res, EnumDxLibApi.Graphics3D_MV1GetMaterialNormalMapTexture);
            if (NeonDxLibApi.IsDebug)
            {
                NeonDxCallStack.Pop();
            }

            return res;
        }

    }
}
