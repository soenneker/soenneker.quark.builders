namespace Soenneker.Quark;

/// <summary>
/// Represents a single overscroll utility rule with an optional breakpoint.
/// </summary>
internal readonly record struct OverscrollRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
