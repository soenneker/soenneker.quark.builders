namespace Soenneker.Quark;

/// <summary>
/// Represents a single border rule with optional BreakpointType.
/// </summary>
internal readonly record struct BorderRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null, bool CanRetargetSide = false);
