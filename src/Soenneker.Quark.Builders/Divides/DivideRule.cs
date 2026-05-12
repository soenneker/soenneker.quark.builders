namespace Soenneker.Quark;

internal readonly record struct DivideRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
