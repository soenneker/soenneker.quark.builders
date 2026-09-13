namespace Soenneker.Quark;

/// <summary>
/// Represents a single aspect ratio rule with optional BreakpointType.
/// </summary>
internal readonly record struct AspectRatioRule(string Ratio, BreakpointType? Breakpoint = null, string? ModifierChain = null);
