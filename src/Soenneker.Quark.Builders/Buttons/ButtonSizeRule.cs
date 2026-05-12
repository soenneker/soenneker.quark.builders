namespace Soenneker.Quark;

public sealed class ButtonSizeRule
{
    public string Size { get; }
    public BreakpointType? Breakpoint { get; }
    public string? ModifierChain { get; }

    public ButtonSizeRule(string size, BreakpointType? breakpoint = null, string? modifierChain = null)
    {
        Size = size;
        Breakpoint = breakpoint;
        ModifierChain = modifierChain;
    }
}
