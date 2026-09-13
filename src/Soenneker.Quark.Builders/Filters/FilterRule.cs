namespace Soenneker.Quark;

/// <summary>
/// Represents a single filter rule with optional BreakpointType.
/// </summary>
internal readonly record struct FilterRule(string Filter, BreakpointType? Breakpoint = null, string? ModifierChain = null);

