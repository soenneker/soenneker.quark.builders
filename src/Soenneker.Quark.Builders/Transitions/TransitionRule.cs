namespace Soenneker.Quark;

/// <summary>
/// Represents a single transition rule with optional BreakpointType.
/// </summary>
internal readonly record struct TransitionRule(string Transition, BreakpointType? Breakpoint = null, string? ModifierChain = null);

