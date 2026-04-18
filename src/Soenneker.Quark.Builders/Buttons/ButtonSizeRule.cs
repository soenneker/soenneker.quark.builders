namespace Soenneker.Quark;

public sealed class ButtonSizeRule
{
    public string Size { get; }
    public BreakpointType? Breakpoint { get; }

    public ButtonSizeRule(string size, BreakpointType? breakpoint = null)
    {
        Size = size;
        Breakpoint = breakpoint;
    }
}
