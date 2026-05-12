namespace Soenneker.Quark;

internal readonly record struct AccentColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
