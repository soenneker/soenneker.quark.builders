namespace Soenneker.Quark;

internal readonly record struct TextBreakRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);

