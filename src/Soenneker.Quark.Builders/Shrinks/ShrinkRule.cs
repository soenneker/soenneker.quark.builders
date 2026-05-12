namespace Soenneker.Quark;

internal readonly record struct ShrinkRule(ShrinkEnum Value, BreakpointType? Breakpoint, string? ModifierChain = null);
