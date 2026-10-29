namespace Soenneker.Quark;

/// <summary>
/// Represents a single min-width rule with optional BreakpointType.
/// </summary>
internal readonly record struct MinWidthRule(string Size, BreakpointType? Breakpoint = null, string? ModifierChain = null);

