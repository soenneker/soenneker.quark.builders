namespace Soenneker.Quark;

/// <summary>
/// Represents a single text size rule with optional BreakpointType.
/// </summary>
internal readonly record struct TextSizeRule(string Size, BreakpointType? Breakpoint = null, string? ModifierChain = null);

