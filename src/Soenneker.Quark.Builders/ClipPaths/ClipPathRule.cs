namespace Soenneker.Quark;

/// <summary>
/// Represents a single clip path rule with optional BreakpointType.
/// </summary>
internal readonly record struct ClipPathRule(string Path, BreakpointType? Breakpoint = null, string? ModifierChain = null);
