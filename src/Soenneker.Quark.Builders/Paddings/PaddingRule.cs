namespace Soenneker.Quark;

/// <summary>
/// Represents a single padding rule with optional BreakpointType.
/// </summary>
internal record PaddingRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null);

