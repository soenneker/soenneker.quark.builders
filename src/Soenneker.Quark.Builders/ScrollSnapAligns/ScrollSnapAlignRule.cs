namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-snap-align rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollSnapAlignRule(ScrollSnapAlignEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
