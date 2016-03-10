using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BDO_Fishing_Companion
{
    class Mouse
    {

        private static Random rnd1 = new Random();

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
            IntPtr dwExtraInfo);

        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        private const UInt32 MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const UInt32 MOUSEEVENTF_RIGHTUP = 0x0010;

        // public static void SendClick(Point location)
        public static void SendLeftClick()
        {
            // Cursor.Position = location;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new IntPtr());
        }

        public static void SendLeftClick(int posX, int posY)
        {
            uint x = Convert.ToUInt32(posX);
            uint y = Convert.ToUInt32(posY);
            // Cursor.Position = location;
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, new IntPtr());
        }

        public static void SendRightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, new IntPtr());
        }

        public static void SendRightClick(int posX, int posY)
        {
            uint x = Convert.ToUInt32(posX);
            uint y = Convert.ToUInt32(posY);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, new IntPtr());
        }
    }
}
