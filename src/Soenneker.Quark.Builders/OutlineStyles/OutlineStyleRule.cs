namespace Soenneker.Quark;

/// <summary>
/// Represents a single outline-style rule with optional BreakpointType.
/// </summary>
internal readonly record struct OutlineStyleRule(OutlineStyleEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
