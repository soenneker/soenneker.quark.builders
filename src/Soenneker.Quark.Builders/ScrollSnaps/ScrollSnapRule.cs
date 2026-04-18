namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-snap-type rule with optional BreakpointType.
/// </summary>
internal record ScrollSnapRule(ScrollSnapEnum Value, BreakpointType? Breakpoint = null);
