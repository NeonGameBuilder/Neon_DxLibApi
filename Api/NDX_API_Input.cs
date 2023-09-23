
namespace NeonDX.DxLibApi
{
    /**
     * DxDLLのラッパークラス: Input
     */
    public sealed class NDX_API_Input : NDX_API_Base
    {
        public const int KEY_INPUT_BACK = 14;
        public const int KEY_INPUT_TAB = 15;
        public const int KEY_INPUT_RETURN = 28;
        public const int KEY_INPUT_LSHIFT = 42;
        public const int KEY_INPUT_RSHIFT = 54;
        public const int KEY_INPUT_LCONTROL = 29;
        public const int KEY_INPUT_RCONTROL = 157;
        public const int KEY_INPUT_ESCAPE = 1;
        public const int KEY_INPUT_SPACE = 57;
        public const int KEY_INPUT_PGUP = 201;
        public const int KEY_INPUT_PGDN = 209;
        public const int KEY_INPUT_END = 207;
        public const int KEY_INPUT_HOME = 199;
        public const int KEY_INPUT_LEFT = 203;
        public const int KEY_INPUT_UP = 200;
        public const int KEY_INPUT_RIGHT = 205;
        public const int KEY_INPUT_DOWN = 208;
        public const int KEY_INPUT_INSERT = 210;
        public const int KEY_INPUT_DELETE = 211;
        public const int KEY_INPUT_MINUS = 12;
        public const int KEY_INPUT_YEN = 125;
        public const int KEY_INPUT_PREVTRACK = 144;
        public const int KEY_INPUT_PERIOD = 52;
        public const int KEY_INPUT_SLASH = 53;
        public const int KEY_INPUT_LALT = 56;
        public const int KEY_INPUT_RALT = 184;
        public const int KEY_INPUT_SCROLL = 70;
        public const int KEY_INPUT_SEMICOLON = 39;
        public const int KEY_INPUT_COLON = 146;
        public const int KEY_INPUT_LBRACKET = 26;
        public const int KEY_INPUT_RBRACKET = 27;
        public const int KEY_INPUT_AT = 145;
        public const int KEY_INPUT_BACKSLASH = 43;
        public const int KEY_INPUT_COMMA = 51;
        public const int KEY_INPUT_KANJI = 148;
        public const int KEY_INPUT_CONVERT = 121;
        public const int KEY_INPUT_NOCONVERT = 123;
        public const int KEY_INPUT_KANA = 112;
        public const int KEY_INPUT_APPS = 221;
        public const int KEY_INPUT_CAPSLOCK = 58;
        public const int KEY_INPUT_SYSRQ = 183;
        public const int KEY_INPUT_PAUSE = 197;
        public const int KEY_INPUT_LWIN = 219;
        public const int KEY_INPUT_RWIN = 220;
        public const int KEY_INPUT_NUMLOCK = 69;
        public const int KEY_INPUT_NUMPAD0 = 82;
        public const int KEY_INPUT_NUMPAD1 = 79;
        public const int KEY_INPUT_NUMPAD2 = 80;
        public const int KEY_INPUT_NUMPAD3 = 81;
        public const int KEY_INPUT_NUMPAD4 = 75;
        public const int KEY_INPUT_NUMPAD5 = 76;
        public const int KEY_INPUT_NUMPAD6 = 77;
        public const int KEY_INPUT_NUMPAD7 = 71;
        public const int KEY_INPUT_NUMPAD8 = 72;
        public const int KEY_INPUT_NUMPAD9 = 73;
        public const int KEY_INPUT_MULTIPLY = 55;
        public const int KEY_INPUT_ADD = 78;
        public const int KEY_INPUT_SUBTRACT = 74;
        public const int KEY_INPUT_DECIMAL = 83;
        public const int KEY_INPUT_DIVIDE = 181;
        public const int KEY_INPUT_NUMPADENTER = 156;
        public const int KEY_INPUT_F1 = 59;
        public const int KEY_INPUT_F2 = 60;
        public const int KEY_INPUT_F3 = 61;
        public const int KEY_INPUT_F4 = 62;
        public const int KEY_INPUT_F5 = 63;
        public const int KEY_INPUT_F6 = 64;
        public const int KEY_INPUT_F7 = 65;
        public const int KEY_INPUT_F8 = 66;
        public const int KEY_INPUT_F9 = 67;
        public const int KEY_INPUT_F10 = 68;
        public const int KEY_INPUT_F11 = 87;
        public const int KEY_INPUT_F12 = 88;
        public const int KEY_INPUT_A = 30;
        public const int KEY_INPUT_B = 48;
        public const int KEY_INPUT_C = 46;
        public const int KEY_INPUT_D = 32;
        public const int KEY_INPUT_E = 18;
        public const int KEY_INPUT_F = 33;
        public const int KEY_INPUT_G = 34;
        public const int KEY_INPUT_H = 35;
        public const int KEY_INPUT_I = 23;
        public const int KEY_INPUT_J = 36;
        public const int KEY_INPUT_K = 37;
        public const int KEY_INPUT_L = 38;
        public const int KEY_INPUT_M = 50;
        public const int KEY_INPUT_N = 49;
        public const int KEY_INPUT_O = 24;
        public const int KEY_INPUT_P = 25;
        public const int KEY_INPUT_Q = 16;
        public const int KEY_INPUT_R = 19;
        public const int KEY_INPUT_S = 31;
        public const int KEY_INPUT_T = 20;
        public const int KEY_INPUT_U = 22;
        public const int KEY_INPUT_V = 47;
        public const int KEY_INPUT_W = 17;
        public const int KEY_INPUT_X = 45;
        public const int KEY_INPUT_Y = 21;
        public const int KEY_INPUT_Z = 44;
        public const int KEY_INPUT_0 = 11;
        public const int KEY_INPUT_1 = 2;
        public const int KEY_INPUT_2 = 3;
        public const int KEY_INPUT_3 = 4;
        public const int KEY_INPUT_4 = 5;
        public const int KEY_INPUT_5 = 6;
        public const int KEY_INPUT_6 = 7;
        public const int KEY_INPUT_7 = 8;
        public const int KEY_INPUT_8 = 9;
        public const int KEY_INPUT_9 = 10;

        // キーボードのすべてのキーの押下状態を取得する
        public static void GetHitKeyStateAll(byte[] KeyStateBuf)
        {
            int res = DxLibDLL.DX.GetHitKeyStateAll(KeyStateBuf);
            VerifyDxLibResult(res, "GetHitKeyStateAll");
        }

        // 	入力が終了しているか取得する
        public static int CheckKeyInput(int InputHandle)
        {
            int res = DxLibDLL.DX.CheckKeyInput(InputHandle);
            VerifyDxLibResult(res, "CheckKeyInput");
            return res;
        }

        // 特定キーの入力状態を得る
        public static bool CheckHitKey(int KeyCode)
        {
            int res = DxLibDLL.DX.CheckHitKey(KeyCode);
            VerifyDxLibResult(res, "CheckHitKey");
            return res == 1;
        }

    }
}
