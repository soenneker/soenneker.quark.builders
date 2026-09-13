namespace Soenneker.Quark;

/// <summary>
/// Represents a single caret-color rule with optional BreakpointType.
/// </summary>
internal readonly record struct CaretColorRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
