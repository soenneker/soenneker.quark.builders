namespace Soenneker.Quark;

/// <summary>
/// Represents a single end (inset-inline-end) rule with optional BreakpointType.
/// </summary>
internal record EndRule(EndEnum Value, BreakpointType? Breakpoint = null);
