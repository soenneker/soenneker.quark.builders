namespace Soenneker.Quark;

/// <summary>
/// Represents a single bottom offset rule with optional BreakpointType.
/// </summary>
internal readonly record struct BottomRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
