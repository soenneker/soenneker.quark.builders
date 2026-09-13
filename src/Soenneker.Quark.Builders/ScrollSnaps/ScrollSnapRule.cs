namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-snap-type rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollSnapRule(ScrollSnapEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
