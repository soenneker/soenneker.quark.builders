namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-padding rule with optional BreakpointType.
/// </summary>
internal record ScrollPaddingRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null);
