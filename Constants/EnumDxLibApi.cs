using System;

namespace NeonDX.DxLibApi
{
    /**
     * DxLibAPI
     */
    public enum EnumDxLibApi
    {
        Unknown,

        //===============================
        // System
        //===============================
        System_DxLib_Init,
        System_DxLib_End,
        System_SetUserWindow,
        System_SetOutApplicationLogValidFlag,
        System_SetAlwaysRunFlag,
        System_SetMouseDispFlag,

        //===============================
        // Util
        //===============================
        Util_WaitTimer,
        Util_GetDateTime,

        //===============================
        // Window
        //===============================
        Window_SetMainWindowText,
        Window_SetWindowIconID,
        Window_ChangeWindowMode,
        Window_SetScreenFlipTargetWindow,
        Window_SetWindowUserCloseEnableFlag,
        Window_GetWindowUserCloseFlag,
        Window_SetFullScreenResolutionMode,
        Window_SetWindowSizeChangeEnableFlag,

        //===============================
        // Graphics2D
        //===============================
        Graphics2D_DrawBox,
        Graphics2D_DrawGraph,
        Graphics2D_DrawExtendGraph,
        Graphics2D_GetGraphSize,
        Graphics2D_LoadGraph,
        Graphics2D_LoadDivGraph,
        Graphics2D_MakeScreen,
        Graphics2D_DrawPixel,
        Graphics2D_DrawString,
        Graphics2D_DrawStringToHandle,
        Graphics2D_GetDrawStringWidth,
        Graphics2D_GetDrawStringWidthToHandle,
        Graphics2D_GetDrawScreenGraph,
        Graphics2D_DeleteGraph,
        Graphics2D_SetDrawScreen,
        Graphics2D_SetGraphMode,
        Graphics2D_GetScreenState,
        Graphics2D_CreateFontToHandle,
        Graphics2D_ClearDrawScreen,
        Graphics2D_ScreenFlip,

        //===============================
        // Graphics3D
        //===============================
        Graphics3D_SetLightEnable,
        Graphics3D_SetLightAmbColor,
        Graphics3D_SetLightDifColor,
        Graphics3D_SetLightSpcColor,
        Graphics3D_ChangeLightTypeDir,
        Graphics3D_ChangeLightTypePoint,
        Graphics3D_ChangeLightTypeSpot,
        Graphics3D_SetLightEnableHandle,
        Graphics3D_SetLightAmbColorHandle,
        Graphics3D_SetLightTypeHandle,
        Graphics3D_SetUseLighting,
        Graphics3D_SetGlobalAmbientLight,
        Graphics3D_MV1LoadModel,
        Graphics3D_MV1GetMaterialNum,
        Graphics3D_MV1GetAnimNum,
        Graphics3D_MV1GetAnimName,
        Graphics3D_MV1GetAnimTotalTime,
        Graphics3D_MV1AttachAnim,
        Graphics3D_MV1GetAttachAnimTotalTime,
        Graphics3D_MV1SetAttachAnimTime,
        Graphics3D_MV1SetPosition,
        Graphics3D_MV1SetScale,
        Graphics3D_MV1SetRotationXYZ,
        Graphics3D_MV1DrawModel,
        Graphics3D_MV1DeleteModel,
        Graphics3D_SetCameraPositionAndTarget_UpVecY,
        Graphics3D_SetCameraNearFar,
        Graphics3D_MV1SetMaterialOutLineWidth,
        Graphics3D_MV1GetMaterialNormalMapTexture,

        //===============================
        // Input
        //===============================
        Input_GetHitKeyStateAll,
        Input_CheckKeyInput,
        Input_CheckHitKey,

        //===============================
        // Movie
        //===============================
        Movie_PlayMovie,
        Movie_PlayMovieToGraph,
        Movie_GetMovieTotalFrameToGraph,
        Movie_GetOneFrameTimeMovieToGraphm,
        Movie_GetMovieStateToGraph,
    }
}
