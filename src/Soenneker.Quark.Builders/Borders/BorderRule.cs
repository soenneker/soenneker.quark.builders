namespace Soenneker.Quark;

/// <summary>
/// Represents a single border rule with optional BreakpointType.
/// </summary>
internal record BorderRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null);
