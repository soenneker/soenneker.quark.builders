namespace Soenneker.Quark;

/// <summary>
/// Represents a single padding rule with optional BreakpointType.
/// </summary>
internal readonly record struct PaddingRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null, bool CanRetargetSide = false);

