namespace Soenneker.Quark;

internal readonly record struct GrowRule(GrowEnum Value, BreakpointType? Breakpoint, string? ModifierChain = null);
