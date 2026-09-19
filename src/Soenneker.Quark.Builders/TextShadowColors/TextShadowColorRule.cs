namespace Soenneker.Quark;

internal readonly record struct TextShadowColorRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
