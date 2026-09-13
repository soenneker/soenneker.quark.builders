namespace Soenneker.Quark;

/// <summary>
/// Represents a single backdrop filter rule with optional BreakpointType.
/// </summary>
internal readonly record struct BackdropFilterRule(string Filter, BreakpointType? Breakpoint = null, string? ModifierChain = null);

