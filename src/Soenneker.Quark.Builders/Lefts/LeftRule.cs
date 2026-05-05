namespace Soenneker.Quark;

/// <summary>
/// Represents a single left offset rule with optional BreakpointType.
/// </summary>
internal record LeftRule(string Value, BreakpointType? Breakpoint = null);
