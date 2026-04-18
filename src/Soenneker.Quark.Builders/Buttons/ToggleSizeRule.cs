namespace Soenneker.Quark;

public sealed class ToggleSizeRule
{
    public string Size { get; }
    public BreakpointType? Breakpoint { get; }

    public ToggleSizeRule(string size, BreakpointType? breakpoint = null)
    {
        Size = size;
        Breakpoint = breakpoint;
    }
}
