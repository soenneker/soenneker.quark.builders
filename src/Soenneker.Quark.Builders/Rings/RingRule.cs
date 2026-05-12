namespace Soenneker.Quark;

internal readonly record struct RingRule(string Token, BreakpointType? Breakpoint = null, string? ModifierChain = null);
