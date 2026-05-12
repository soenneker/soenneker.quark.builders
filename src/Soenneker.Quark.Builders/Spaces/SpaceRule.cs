namespace Soenneker.Quark;

internal readonly record struct SpaceRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
