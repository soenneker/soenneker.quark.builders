namespace Soenneker.Quark;

/// <summary>
/// Represents a single truncate rule with optional BreakpointType.
/// </summary>
internal readonly record struct TruncateRule(BreakpointType? Breakpoint = null, string? ModifierChain = null);

