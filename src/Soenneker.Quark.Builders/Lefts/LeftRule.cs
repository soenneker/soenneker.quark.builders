namespace Soenneker.Quark;

/// <summary>
/// Represents a single left offset rule with optional BreakpointType.
/// </summary>
internal readonly record struct LeftRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
