namespace Soenneker.Quark;

/// <summary>
/// Represents a single text overflow rule with optional BreakpointType.
/// </summary>
internal readonly record struct TextOverflowRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);

