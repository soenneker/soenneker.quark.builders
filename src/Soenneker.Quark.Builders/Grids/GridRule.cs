namespace Soenneker.Quark;

internal readonly record struct GridRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
