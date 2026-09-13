namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-snap-stop rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollSnapStopRule(ScrollSnapStopEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
