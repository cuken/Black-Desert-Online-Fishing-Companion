//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace BDO_Fishing_Companion
//{
//    class Keyboard
//    {
//        [DllImport("user32.dll", SetLastError = true)]
//        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

//        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
//        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
//        public const int VK_LCONTROL = 0xA2; //Left Control key code
//        public const int SPACE = 0x040; // Space key
//        public const int BANG = 0x21; // ! key
//        public const int QOUTE = 0x22; // " key
//        public const int POUND = 0x23; // # key
//        public const int DOLLAR = 0x24; // $ key
//        public const int PERCENT = 0x25; // % key
//        public const int AMPER = 0x26; // & key
//        public const int APOSTRAPHE = 0x27; // ' key
//        public const int LEFTPAREN = 0x28; // ( key
//        public const int RIGHTPAREN = 0x29; // ) key
//        public const int ASTERIK = 0x2a; // * key
//        public const int PLUS = 0x2b; // + key
//        public const int COMMA = 0x2c; // , key
//        public const int MINUS = 0x2d; // - key
//        public const int PERIOD = 0x2e; // . key
//        public const int FSLASH = 0x2f; // / key
//        public const int N0 = 0x30; // 0 key
//        public const int N1 = 0x31; // 1 key
//        public const int N2 = 0x32; // 2 key
//        public const int N3 = 0x33; // 3 key
//        public const int N4 = 0x34; // 4 key
//        public const int N5 = 0x35; // 5 key
//        public const int N6 = 0x36; // 6 key
//        public const int N7 = 0x37; // 7 key
//        public const int N8 = 0x38; // 8 key
//        public const int N9 = 0x39; // 9 key
//        public const int COLON = 0x3a; // : key
//        public const int SEMICOLON = 0x3b; // ; key
//        public const int LESSTHAN = 0x3c; // < key
//        public const int EQUAL = 0x3d; // = key
//        public const int GREATERTHAN = 0x3e; // > key
//        public const int QUESTION = 0x3f; // ? key
//        public const int ATSYMBOL = 0x40; // @ key
//        public const int A = 0x41; // A key
//        public const int B = 0x42; // B key
//        public const int C = 0x43; // C key
//        public const int D = 0x44; // D key
//        public const int E = 0x45; // E key
//        public const int F = 0x46; // F key
//        public const int G = 0x47; // G key
//        public const int H = 0x48; // H key
//        public const int I = 0x49; // I key
//        public const int J = 0x4a; // J key
//        public const int K = 0x4b; // K key
//        public const int L = 0x4c; // L key
//        public const int M = 0x4d; // M key
//        public const int N = 0x4e; // N key
//        public const int O = 0x4f; // O key
//        public const int P = 0x50; // P key
//        public const int Q = 0x51; // Q key
//        public const int R = 0x52; // R key
//        public const int S = 0x53; // S key
//        public const int T = 0x54; // T key
//        public const int U = 0x55; // U key
//        public const int V = 0x56; // V key
//        public const int W = 0x57; // W key
//        public const int X = 0x58; // X key
//        public const int Y = 0x59; // Y key
//        public const int Z = 0x5a; // Z key
//        public const int LBRACKET = 0x5b; // [ key
//        public const int BSLASH = 0x5c; // \ key
//        public const int RBRACKET = 0x5d; // ] key
//        public const int CARROT = 0x5e; // ^ key
//        public const int UNDERSCORE = 0x5f; // _ key
//        public const int GRAVE = 0x60; // ` key
//        public const int a = 0x61; // a key
//        public const int b = 0x62; // b key
//        public const int c = 0x63; // c key
//        public const int d = 0x64; // d key
//        public const int e = 0x65; // e key
//        public const int f = 0x66; // f key
//        public const int g = 0x67; // g key
//        public const int h = 0x68; // h key
//        public const int i = 0x69; // i key
//        public const int j = 0x6a; // j key
//        public const int k = 0x6b; // k key
//        public const int l = 0x6c; // l key
//        public const int m = 0x6d; // m key
//        public const int n = 0x6e; // n key
//        public const int o = 0x6f; // o key
//        public const int p = 0x70; // p key
//        public const int q = 0x71; // q key
//        public const int r = 0x72; // r key
//        public const int s = 0x73; // s key
//        public const int t = 0x74; // t key
//        public const int u = 0x75; // u key
//        public const int v = 0x76; // v key
//        public const int w = 0x77; // w key
//        public const int x = 0x78; // x key
//        public const int y = 0x79; // y key
//        public const int z = 0x7a; // z key
//        public const int LCHEV = 0x7b; // { key
//        public const int PIPE = 0x7c; // | key
//        public const int RCHEV = 0x7d; // } key
//        public const int TILDE = 0x7e; // ~ key

//        public static void PressKey(char character)
//        {
//            byte press;       
                
//                switch(character)
//                {
//                    case '!':
//                        press = BANG;
//                        break;
//                    case '"':
//                        press = QOUTE;
//                        break;
//                    case '#':
//                        press = POUND;
//                        break;
//                    case '$':
//                        press = DOLLAR;
//                        break;
//                    case '%':
//                        press = PERCENT;
//                        break;
//                    case '&':
//                        press = QOUTE;
//                        break;
//                    case '\'':
//                        press = APOSTRAPHE;
//                        break;
//                    case '(':
//                        press = LEFTPAREN;
//                        break;
//                    case ')':
//                        press = RIGHTPAREN;
//                        break;
//                    case '*':
//                        press = ASTERIK;
//                        break;
//                    case '+':
//                        press = PLUS;
//                        break;
//                    case ',':
//                        press = COMMA;
//                        break;
//                    case '-':
//                        press = MINUS;
//                        break;
//                    case '.':
//                        press = PERIOD;
//                        break;
//                    case '/':
//                        press = FSLASH;
//                        break;
//                    case '0':
//                        press = N0;
//                        break;
//                    case '1':
//                        press = N1;
//                        break;
//                    case '2':
//                        press = N2;
//                        break;
//                    case '3':
//                        press = N3;
//                        break;
//                    case '4':
//                        press = N4;
//                        break;
//                    case '5':
//                        press = N5;
//                        break;
//                    case '6':
//                        press = N6;
//                        break;
//                    case '7':
//                        press = N7;
//                        break;
//                    case '8':
//                        press = N8;
//                        break;
//                    case '9':
//                        press = N9;
//                        break;
//                    case ':':
//                        press = COLON;
//                        break;
//                    case ';':
//                        press = SEMICOLON;
//                        break;
//                    case '<':
//                        press = LESSTHAN;
//                        break;
//                    case '=':
//                        press = EQUAL;
//                        break;
//                    case '>':
//                        press = GREATERTHAN;
//                        break;
//                    case '?':
//                        press = QUESTION;
//                        break;
//                    case '@':
//                        press = ATSYMBOL;
//                        break;
//                    case 'A':
//                        press = A;
//                        break;
//                    case 'B':
//                        press = B;
//                        break;
//                    case 'C':
//                        press = C;
//                        break;
//                    case 'D':
//                        press = D;
//                        break;
//                    case 'E':
//                        press = E;
//                        break;
//                    case 'F':
//                        press = F;
//                        break;
//                    case 'G':
//                        press = G;
//                        break;
//                    case 'H':
//                        press = H;
//                        break;
//                    case 'I':
//                        press = I;
//                        break;
//                    case 'J':
//                        press = J;
//                        break;
//                    case 'K':
//                        press = K;
//                        break;
//                    case 'L':
//                        press = L;
//                        break;
//                    case 'M':
//                        press = M;
//                        break;
//                    case 'N':
//                        press = N;
//                        break;
//                    case 'O':
//                        press = O;
//                        break;
//                    case 'P':
//                        press = P;
//                        break;
//                    case 'Q':
//                        press = Q;
//                        break;
//                    case 'R':
//                        press = R;
//                        break;
//                    case 'S':
//                        press = S;
//                        break;
//                    case 'T':
//                        press = T;
//                        break;
//                    case 'U':
//                        press = U;
//                        break;
//                    case 'V':
//                        press = V;
//                        break;
//                    case 'W':
//                        press = W;
//                        break;
//                    case 'X':
//                        press = X;
//                        break;
//                    case 'Y':
//                        press = Y;
//                        break;
//                    case 'Z':
//                        press = Z;
//                        break;
//                    case '[':
//                        press = LBRACKET;
//                        break;
//                    case '\\':
//                        press = BSLASH;
//                        break;
//                    case ']':
//                        press = RBRACKET;
//                        break;
//                    case '^':
//                        press = CARROT;
//                        break;
//                    case '_':
//                        press = UNDERSCORE;
//                        break;
//                    case '`':
//                        press = GRAVE;
//                        break;
//                    case 'a':
//                        press = a;
//                        break;
//                    case 'b':
//                        press = b;
//                        break;
//                    case 'c':
//                        press = c;
//                        break;
//                    case 'd':
//                        press = d;
//                        break;
//                    case 'e':
//                        press = e;
//                        break;
//                    case 'f':
//                        press = f;
//                        break;
//                    case 'g':
//                        press = g;
//                        break;
//                    case 'h':
//                        press = h;
//                        break;
//                    case 'i':
//                        press = i;
//                        break;
//                    case 'j':
//                        press = j;
//                        break;
//                    case 'k':
//                        press = k;
//                        break;
//                    case 'l':
//                        press = l;
//                        break;
//                    case 'm':
//                        press = m;
//                        break;
//                    case 'n':
//                        press = n;
//                        break;
//                    case 'o':
//                        press = o;
//                        break;
//                    case 'p':
//                        press = p;
//                        break;
//                    case 'q':
//                        press = q;
//                        break;
//                    case 'r':
//                        press = r;
//                        break;
//                    case 's':
//                        press = s;
//                        break;
//                    case 't':
//                        press = t;
//                        break;
//                    case 'u':
//                        press = u;
//                        break;
//                    case 'v':
//                        press = v;
//                        break;
//                    case 'w':
//                        press = w;
//                        break;
//                    case 'x':
//                        press = x;
//                        break;
//                    case 'y':
//                        press = y;
//                        break;
//                    case 'z':
//                        press = z;
//                        break;
//                    case '{':
//                        press = LCHEV;
//                        break;
//                    case '|':
//                        press = PIPE;
//                        break;
//                    case '}':
//                        press = RCHEV;
//                        break;
//                    case '~':
//                        press = TILDE;
//                        break;
//                    default:
//                        //DEFAULTING TO A BOGUS KEY
//                        press = BANG;
//                        break;
//                }

//                keybd_event(press, 0x9e, 0, 0); // Key pressed
//                keybd_event(press, 0x9e, KEYEVENTF_KEYUP, 0); //Key Released
//            }

//        }
//    }   
//}
