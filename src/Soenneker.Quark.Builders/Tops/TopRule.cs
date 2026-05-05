namespace Soenneker.Quark;

/// <summary>
/// Represents a single top offset rule with optional BreakpointType.
/// </summary>
internal record TopRule(string Value, BreakpointType? Breakpoint = null);
