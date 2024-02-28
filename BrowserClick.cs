using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BingRewards
{
    public static class BrowserClick
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void SimulateMouseClick()
        {
            const int MOUSEEVENTF_LEFTDOWN = 0x02;
            const int MOUSEEVENTF_LEFTUP = 0x04;

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }       
    }
}
