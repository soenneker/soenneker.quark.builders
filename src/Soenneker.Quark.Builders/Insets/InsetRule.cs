namespace Soenneker.Quark;

/// <summary>
/// Represents a single inset rule with optional BreakpointType.
/// </summary>
internal record InsetRule(InsetScaleEnum Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null);
