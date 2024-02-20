using System.Runtime.InteropServices;
using Windows.Win32.UI.Input.KeyboardAndMouse;
using Windows.Win32;

namespace Anduin.MouseJiggler;

internal static class Helpers
{
    /// <summary>
    ///     Jiggle the mouse; i.e., fake a mouse movement event.
    /// </summary>
    /// <param name="delta">The mouse will be moved by delta pixels along both X and Y.</param>
    internal static void Jiggle(int delta)
    {
        var inp = new INPUT
        {
            type = INPUT_TYPE.INPUT_MOUSE,
            Anonymous = new INPUT._Anonymous_e__Union
            {
                mi = new MOUSEINPUT
                {
                    dx = delta,
                    dy = delta,
                    mouseData = 0,
                    dwFlags = MOUSE_EVENT_FLAGS.MOUSEEVENTF_MOVE,
                    time = 0,
                    dwExtraInfo = 0,
                },
            },
        };

        _ = PInvoke.SendInput(pInputs: new[] { inp, }, cbSize: Marshal.SizeOf<INPUT>());
    }
}

