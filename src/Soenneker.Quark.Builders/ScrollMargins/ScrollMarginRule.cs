namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-margin rule with optional BreakpointType.
/// </summary>
internal record ScrollMarginRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null);
