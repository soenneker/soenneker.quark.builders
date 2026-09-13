namespace Soenneker.Quark;

/// <summary>
/// Represents a single object-fit rule with optional BreakpointType.
/// </summary>
internal readonly record struct ObjectFitRule(string Fit, BreakpointType? Breakpoint = null, string? ModifierChain = null);
