namespace Soenneker.Quark;

internal readonly record struct BorderColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
