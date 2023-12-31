# 用途

 [Dxライブラリ](https://dxlib.xsrv.jp/index.html) をラップしてクラスにまとめたC#ライブラリです。


## NDX_API_Base

 Dxライブラリが返す結果コードを検証します。Dxライブラリは呼び出しません。

## NDX_API_Graphics2D

 2Dグラフィックスに関連するDxライブラリの関数を呼び出します。

## NDX_API_Graphics3D

 3Dグラフィックスに関連するDxライブラリの関数を呼び出します。

## NDX_API_Input

 入力に関連するDxライブラリの関数を呼び出します。
 
## NDX_API_Movie

 動画に関連するDxライブラリの関数を呼び出します。
 
## NDX_API_System

 アプリケーションやDxライブラリの初期化コードなどに関連するDxライブラリの関数を呼び出します。

# 使用方法

### ウィンドウモードの場合
```
// DXライブラリの初期化
NDX_API_System.DxLib_Init();

// ウィンドウモード
NDX_API_Window.ChangeWindowMode(true);

while(true)
{
    // 裏画面をクリア
    NDX_API_Graphics2D.ClearDrawScreen();

    // ESCキーが押されていたら終了
    if (NDX_API_Input.CheckHitKey(NDX_API_Input.KEY_INPUT_ESCAPE))
    {
        break;
    }

    // 描画をここに書きます

    // 裏画面に反映
    NDX_API_Graphics2D.ScreenFlip();
}

// DXライブラリの終了
NDX_API_System.DxLib_End();
```

また、[Neon_DxLibApi_Sample](https://github.com/NeonGameBuilder/Neon_DxLibApi_Sample)にNeonDxLibApiを使用したサンプルプログラムを公開しています。

# デバッグモードとコールスタック

NeonDxLibApiはDXライブラリのコール履歴を保持するスタックを持っています。このスタックはグローバルなbool型変数(NeonDxLibApi.IsDebug)をtrueに設定することで機能します。

```
// デバッグモードをONにする
NeonDxLibApi.IsDebug = true;
```

デバッグモード有効時、すべてのDXライブラリのAPI呼び出しは引数情報や実行結果コードとともにコールスタックに記録されます。API呼び出しが失敗した場合はcatchハンドラでこのコールスタックをダンプすることができます。
DXライブラリの呼び出しが階層的に行われている場合を除き、DXライブラリの呼び出しが成功するとコールスタックの呼び出し情報はスタックから自動的に削除されます。
つまり、例外発生時にNeonDxCallStack.Dumpによって表示されたコールスタックは最後の行で失敗したことを表します。

```
// デバッグモードをONにする
NeonDxLibApi.IsDebug = true;

// try～catchでDXライブラリの呼び出し失敗を捕捉する
try{
    // DXライブラリの呼び出し処理
}
catch(NeonDxDxLibApiException ex)
{
    // DXライブラリの呼び出し履歴(失敗に至るまで呼び出されたAPI)を表示
    NeonDxCallStack.Dump((string str) =>
    {
        Debug.WriteLine(str);
    });
}
```

<<出力ウィンドウのログ例>>
```
[Graphics2D_LoadGraph:-1]FileName=C:\\Tmp\\sample.mp4
```

<<ログフォーマット>>
```
[API名:結果コード]引数１=引数１の値, 引数2=引数2の値, ...
```


# 実行環境

.Net 6
.Net 7

# インストール方法

## Nuget経由

「ソリューションのNuGetパッケージの管理」から"NeonDxLibApi"で検索、インストール

https://www.nuget.org/packages/NeonDxLibApi

# 依存ライブラリ

Neon_DxLibApiの実行にはDXライブラリのモジュール(DxLib.dll/DxLib_x64.dll)が必要です。下記のパッケージ(DxLib.NETDLL)に含まれているので実行モジュール(Exe)作成時に参照を追加してください。


DxLib.NETDLL
 - Web: https://dxlib.xsrv.jp/index.html
 - Nuget: https://www.nuget.org/packages/DxLib.NETDLL/

# ライセンス(License)

MITライセンス
(詳細はLICENSEを参照)

