namespace Soenneker.Quark;

/// <summary>
/// Represents a single animation rule with optional BreakpointType.
/// </summary>
internal readonly record struct AnimationRule(string Animation, BreakpointType? Breakpoint = null, string? ModifierChain = null);
