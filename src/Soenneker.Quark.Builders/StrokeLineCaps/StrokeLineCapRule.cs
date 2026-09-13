namespace Soenneker.Quark;

/// <summary>
/// Represents a single stroke line cap rule with optional BreakpointType.
/// </summary>
internal readonly record struct StrokeLineCapRule(StrokeLineCapEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
