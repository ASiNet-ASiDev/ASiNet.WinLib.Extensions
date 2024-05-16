using ASiNet.WinLib.Enums;

namespace ASiNet.WinLib.Extensions;
public struct SingleUnicodeKeyEvent
{

    public char UnicodeChar { get; set; }

    public KeyState State { get; set; }

    public static SingleUnicodeKeyEvent NewKeyDown(char unicode) =>
        new() { UnicodeChar = unicode, State = KeyState.Down };

    public static SingleUnicodeKeyEvent NewKeyUp(char unicode) =>
        new() { UnicodeChar = unicode, State = KeyState.Up };

    public static SingleUnicodeKeyEvent NewKeyClick(char unicode) =>
        new() { UnicodeChar = unicode, State = KeyState.Click };

}
