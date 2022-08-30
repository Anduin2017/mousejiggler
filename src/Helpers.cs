using System.Diagnostics;
using System.Runtime.InteropServices;
using PInvoke;

namespace Anduin.MouseJiggler;

internal static class Helpers
{
    /// <summary>
    ///     Jiggle the mouse; i.e., fake a mouse movement event.
    /// </summary>
    /// <param name="delta">The mouse will be moved by delta pixels along both X and Y.</param>
    internal static void Jiggle(int delta)
    {
        var inp = new User32.INPUT
        {
            type = User32.InputType.INPUT_MOUSE,
            Inputs = new User32.INPUT.InputUnion
            {
                mi = new User32.MOUSEINPUT
                {
                    dx = delta,
                    dy = delta,
                    mouseData = 0,
                    dwFlags = User32.MOUSEEVENTF.MOUSEEVENTF_MOVE,
                    time = 0,
                    dwExtraInfo_IntPtr = IntPtr.Zero,
                },
            },
        };

        _ = User32.SendInput(nInputs: 1, pInputs: new[] { inp, }, cbSize: Marshal.SizeOf<User32.INPUT>());
    }
}
