namespace Soenneker.Quark;

internal readonly record struct WordBreakRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);

