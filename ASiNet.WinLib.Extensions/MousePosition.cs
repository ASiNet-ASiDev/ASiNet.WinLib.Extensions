namespace ASiNet.WinLib.Extensions;

public enum MoveType : byte
{
    Relative,
    Absolute,
    AbsoluteVirtualDesktop,
}

public struct MousePosition
{
    public int X { get; set; }

    public int Y { get; set; }

    public MoveType MoveType { get; set; }

    public static MousePosition NewRelativePosition(int x, int y) =>
        new() { Y = y, X = x, MoveType = MoveType.Relative };

    public static MousePosition NewAbsolutePosition(int x, int y) =>
        new() { Y = y, X = x, MoveType = MoveType.Absolute };

    public static MousePosition NewAbsoluteVirtiadDesktopPosition(int x, int y) =>
        new() { Y = y, X = x, MoveType = MoveType.AbsoluteVirtualDesktop };
}
