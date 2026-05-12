namespace Soenneker.Quark;

internal readonly record struct FontFamilyRule(string Value, BreakpointType? Breakpoint, string? ModifierChain = null);
