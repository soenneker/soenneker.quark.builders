namespace Soenneker.Quark;

/// <summary>
/// Represents a single width rule with optional BreakpointType.
/// </summary>
internal readonly record struct WidthRule(string Size, BreakpointType? Breakpoint = null, string? ModifierChain = null);

