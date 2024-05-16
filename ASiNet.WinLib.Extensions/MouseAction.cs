using ASiNet.WinLib.Enums;

namespace ASiNet.WinLib.Extensions;

public struct MouseAction
{
    public short Wheel { get; set; }

    public MouseButtonEvent MouseButtonEvent { get; set; }

    public static MouseAction NewWheelUp(short speed = 1) =>
        new() { Wheel = speed, MouseButtonEvent = MouseButtonEvent.None };

    public static MouseAction NewWheelDownUp(short speed = 1) =>
        new() { Wheel = (short)-speed, MouseButtonEvent = MouseButtonEvent.None };

    public static MouseAction NewButtonEvent(MouseButtonEvent @event) =>
        new() { Wheel = 0, MouseButtonEvent = @event };

}
