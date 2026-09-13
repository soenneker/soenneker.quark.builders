namespace Soenneker.Quark;

/// <summary>
/// Represents a single object position rule with optional BreakpointType.
/// </summary>
internal readonly record struct ObjectPositionRule(string Position, BreakpointType? Breakpoint = null, string? ModifierChain = null);
