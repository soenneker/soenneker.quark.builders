namespace Soenneker.Quark;

/// <summary>
/// Represents a single stroke width rule with optional BreakpointType.
/// </summary>
internal readonly record struct StrokeWidthRule(StrokeWidthEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
