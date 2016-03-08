using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BDO_Fishing_Companion
{
    class Mouse
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
            UIntPtr dwExtraInfo);

        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;       

        // public static void SendClick(Point location)
        public static void SendClick()
        {
            // Cursor.Position = location;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new UIntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new UIntPtr());
        }
    }
}
