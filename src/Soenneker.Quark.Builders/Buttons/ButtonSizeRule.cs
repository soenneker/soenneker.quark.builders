namespace Soenneker.Quark;

/// <summary>
/// Represents the button size rule.
/// </summary>
public sealed class ButtonSizeRule
{
    /// <summary>
    /// Gets size.
    /// </summary>
    public string Size { get; }
    /// <summary>
    /// Gets breakpoint.
    /// </summary>
    public BreakpointType? Breakpoint { get; }
    /// <summary>
    /// Gets modifier chain.
    /// </summary>
    public string? ModifierChain { get; }

    public ButtonSizeRule(string size, BreakpointType? breakpoint = null, string? modifierChain = null)
    {
        Size = size;
        Breakpoint = breakpoint;
        ModifierChain = modifierChain;
    }
}
