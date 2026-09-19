namespace Soenneker.Quark;

internal readonly record struct DecorationColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
