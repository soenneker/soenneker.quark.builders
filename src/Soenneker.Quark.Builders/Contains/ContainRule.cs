namespace Soenneker.Quark;

/// <summary>
/// Represents a single contain rule with optional BreakpointType.
/// </summary>
internal record ContainRule(ContainEnum Value, BreakpointType? Breakpoint = null);
