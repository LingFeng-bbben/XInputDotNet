using System;
using System.Threading;
using XInputDotNetPure;
using static XInputDotNetPure.GamePadState.RawState;

namespace XInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GamePadState.RawState state;
                Imports.XInputGamePadGetState(0, out state);
                var raw = state.Gamepad.wButtons;
                var bin = Convert.ToString(raw,2).PadLeft(16,'0');
                Console.WriteLine(bin + String.Format(" 0x{0:X4}",raw));
                Thread.Sleep(16);
            }
        }
    }
}
