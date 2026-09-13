namespace Soenneker.Quark;

/// <summary>
/// Represents a single height rule with optional BreakpointType.
/// </summary>
internal readonly record struct HeightRule(string Size, BreakpointType? Breakpoint = null, string? ModifierChain = null);
