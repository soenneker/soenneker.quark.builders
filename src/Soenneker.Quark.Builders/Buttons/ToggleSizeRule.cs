namespace Soenneker.Quark;

/// <summary>
/// Represents the toggle size rule.
/// </summary>
public sealed class ToggleSizeRule
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

    public ToggleSizeRule(string size, BreakpointType? breakpoint = null, string? modifierChain = null)
    {
        Size = size;
        Breakpoint = breakpoint;
        ModifierChain = modifierChain;
    }
}
