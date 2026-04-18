namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-snap-align rule with optional BreakpointType.
/// </summary>
internal record ScrollSnapAlignRule(ScrollSnapAlignEnum Value, BreakpointType? Breakpoint = null);
