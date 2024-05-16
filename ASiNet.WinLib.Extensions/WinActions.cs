namespace ASiNet.WinLib.Extensions;

public static class WinActionsExtensions
{
    public static uint MousePosition(in MousePosition position)
    {
        switch (position.MoveType)
        {
            case MoveType.Relative:
                return WinActions.SendMouseEvent(position.X, position.Y, false, false);
            case MoveType.Absolute:
                return WinActions.SendMouseEvent(position.X, position.Y, true, false);
            case MoveType.AbsoluteVirtualDesktop:
                return WinActions.SendMouseEvent(position.X, position.Y, true, true);
        }
        return 0;
    }

    public static uint MouseAction(in MouseAction action) =>
        WinActions.SendMouseEvent(0, 0, action.Wheel, action.MouseButtonEvent);

    public static uint KeyboardAction(in SingleVirtialKeyEvent action) =>
        WinActions.SendKeyboardEvent(action.VirtualKeyCode, action.State);
    
    public static uint KeyboardAction(in SingleUnicodeKeyEvent action) =>
        WinActions.SendKeyboardEvent(action.UnicodeChar, action.State);

    public static uint KeyboardAction(in MultiKeyEvent action)
    {
        var result = 0U;

        if(action.UseMod1)
            result += WinActions.SendKeyboardEvent(action.Mod1KeyCode, Enums.KeyState.Down);
        if (action.UseMod2)
            result += WinActions.SendKeyboardEvent(action.Mod2KeyCode, Enums.KeyState.Down);

        result += WinActions.SendKeyboardEvent(action.KeyCode, Enums.KeyState.Click);

        if (action.UseMod1)
            result += WinActions.SendKeyboardEvent(action.Mod1KeyCode, Enums.KeyState.Up);
        if (action.UseMod2)
            result += WinActions.SendKeyboardEvent(action.Mod2KeyCode, Enums.KeyState.Up);

        return result;
    }


}
