namespace Soenneker.Quark;

internal readonly record struct VisibilityRule(VisibilityEnum Value, BreakpointType? Breakpoint, string? ModifierChain = null);

