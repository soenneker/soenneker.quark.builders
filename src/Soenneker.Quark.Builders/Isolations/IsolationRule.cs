namespace Soenneker.Quark;

/// <summary>
/// Represents a single isolation rule with optional BreakpointType.
/// </summary>
internal readonly record struct IsolationRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
