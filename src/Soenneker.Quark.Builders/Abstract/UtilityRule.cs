namespace Soenneker.Quark;

/// <summary>
/// Represents the utility rule record structure.
/// </summary>
/// <param name="Value">The value.</param>
/// <param name="Breakpoint">The breakpoint.</param>
/// <param name="ModifierChain">The modifier chain.</param>
public readonly record struct UtilityRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
