namespace Soenneker.Quark;

/// <summary>
/// Represents a single position rule with optional BreakpointType.
/// </summary>
internal readonly record struct PositionRule(string Position, BreakpointType? Breakpoint = null, string? ModifierChain = null);

