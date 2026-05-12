namespace Soenneker.Quark;

internal readonly record struct RingOffsetRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
