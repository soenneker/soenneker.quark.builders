namespace Soenneker.Quark;

/// <summary>
/// Represents a single contain rule with optional BreakpointType.
/// </summary>
internal readonly record struct ContainRule(ContainEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
