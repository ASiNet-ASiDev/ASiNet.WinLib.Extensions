using ASiNet.WinLib.Enums;

namespace ASiNet.WinLib.Extensions;
public struct SingleVirtialKeyEvent
{
    public VirtualKeyCode VirtualKeyCode { get; set; }

    public KeyState State { get; set; }

    public static SingleVirtialKeyEvent NewKeyDown(VirtualKeyCode keyCode) =>
        new() { VirtualKeyCode = keyCode, State = KeyState.Down };

    public static SingleVirtialKeyEvent NewKeyUp(VirtualKeyCode keyCode) =>
        new() { VirtualKeyCode = keyCode, State = KeyState.Up };

    public static SingleVirtialKeyEvent NewKeyClick(VirtualKeyCode keyCode) =>
        new() { VirtualKeyCode = keyCode, State = KeyState.Click };
}
