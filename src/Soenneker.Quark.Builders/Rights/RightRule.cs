namespace Soenneker.Quark;

/// <summary>
/// Represents a single right offset rule with optional BreakpointType.
/// </summary>
internal readonly record struct RightRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
