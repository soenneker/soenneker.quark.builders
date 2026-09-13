namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-margin rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollMarginRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null);
