namespace Soenneker.Quark;

internal readonly record struct OutlineColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
