namespace Soenneker.Quark;

/// <summary>
/// Represents a single inset rule with optional BreakpointType.
/// </summary>
internal readonly record struct InsetRule(InsetScaleEnum Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null);
