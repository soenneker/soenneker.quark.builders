namespace Soenneker.Quark;

/// <summary>
/// Represents a single right offset rule with optional BreakpointType.
/// </summary>
internal record RightRule(string Value, BreakpointType? Breakpoint = null);
