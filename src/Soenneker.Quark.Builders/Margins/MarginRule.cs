namespace Soenneker.Quark;

/// <summary>
/// Represents a single margin rule with optional BreakpointType.
/// </summary>
internal record MarginRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null, bool CanRetargetSide = false);
