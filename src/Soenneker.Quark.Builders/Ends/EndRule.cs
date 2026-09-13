namespace Soenneker.Quark;

/// <summary>
/// Represents a single end (inset-inline-end) rule with optional BreakpointType.
/// </summary>
internal readonly record struct EndRule(EndEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
