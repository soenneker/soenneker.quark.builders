namespace Soenneker.Quark;

internal readonly record struct ShadowColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
