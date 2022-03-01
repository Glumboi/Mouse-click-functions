public class Clicks
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    //Mouse actions
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;

    private const int MOUSEEVENTF_LEFTUP = 0x04;

    private const int MOUSEEVENTF_RIGHTUP = 0x012;

    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;

    //Left click function
    public void DoMouseClick()
    {
        uint X = (uint)Cursor.Position.X;
        uint Y = (uint)Cursor.Position.Y;
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
    }

    //Right click function
    public void DoMouseRightClick()
    {
        uint X = (uint)Cursor.Position.X;
        uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
    }
}