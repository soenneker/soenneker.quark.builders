namespace Soenneker.Quark;

/// <summary>
/// Represents a single stroke line join rule with optional BreakpointType.
/// </summary>
internal readonly record struct StrokeLineJoinRule(StrokeLineJoinEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
