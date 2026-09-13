namespace Soenneker.Quark;

/// <summary>
/// Represents a single resize rule with optional BreakpointType.
/// </summary>
internal readonly record struct ResizeRule(string Resize, BreakpointType? Breakpoint = null, string? ModifierChain = null);

