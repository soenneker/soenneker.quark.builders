namespace Soenneker.Quark;

/// <summary>
/// Represents a single top offset rule with optional BreakpointType.
/// </summary>
internal readonly record struct TopRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
