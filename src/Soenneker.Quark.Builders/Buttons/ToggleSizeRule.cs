namespace Soenneker.Quark;

public sealed class ToggleSizeRule
{
    public string Size { get; }
    public BreakpointType? Breakpoint { get; }
    public string? ModifierChain { get; }

    public ToggleSizeRule(string size, BreakpointType? breakpoint = null, string? modifierChain = null)
    {
        Size = size;
        Breakpoint = breakpoint;
        ModifierChain = modifierChain;
    }
}
