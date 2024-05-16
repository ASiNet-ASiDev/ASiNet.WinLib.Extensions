using ASiNet.WinLib.Enums;

namespace ASiNet.WinLib.Extensions;
public struct MultiKeyEvent
{
    public bool UseMod1 { get; set; }
    public VirtualKeyCode Mod1KeyCode { get; set; }
    public bool UseMod2 { get; set; }
    public VirtualKeyCode Mod2KeyCode { get; set; }
    public VirtualKeyCode KeyCode { get; set; }


    public MultiKeyEvent SetMod1(VirtualKeyCode code)
    {
        UseMod1 = true;
        Mod1KeyCode = code;
        return this;
    }

    public MultiKeyEvent SetMod2(VirtualKeyCode code)
    {
        UseMod2 = true;
        Mod2KeyCode = code;
        return this;
    }

    public MultiKeyEvent SetKey(VirtualKeyCode code)
    {
        KeyCode = code;
        return this;
    }

    public static MultiKeyEvent ShiftKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Shift)
        .SetKey(code);

    public static MultiKeyEvent ShiftModKey(VirtualKeyCode mod2, VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Shift)
        .SetMod2(mod2)
        .SetKey(code);

    public static MultiKeyEvent CtrlModKey(VirtualKeyCode mod2, VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Ctrl)
        .SetMod2(mod2)
        .SetKey(code);

    public static MultiKeyEvent AltModKey(VirtualKeyCode mod2, VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Alt)
        .SetMod2(mod2)
        .SetKey(code);

    public static MultiKeyEvent CtrlKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Ctrl)
        .SetKey(code);

    public static MultiKeyEvent ShiftCtrlKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Shift)
        .SetMod2(VirtualKeyCode.Ctrl)
        .SetKey(code);

    public static MultiKeyEvent CtrlShiftKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Ctrl)
        .SetMod2(VirtualKeyCode.Shift)
        .SetKey(code);

    public static MultiKeyEvent AltKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Alt)
        .SetKey(code);

    public static MultiKeyEvent AltShiftKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Alt)
        .SetMod2(VirtualKeyCode.Shift)
        .SetKey(code);

    public static MultiKeyEvent AltCtrlKey(VirtualKeyCode code) =>
        new MultiKeyEvent()
        .SetMod1(VirtualKeyCode.Alt)
        .SetMod2(VirtualKeyCode.Ctrl)
        .SetKey(code);
}
