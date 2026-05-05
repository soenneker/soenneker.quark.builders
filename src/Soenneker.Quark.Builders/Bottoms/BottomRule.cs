namespace Soenneker.Quark;

/// <summary>
/// Represents a single bottom offset rule with optional BreakpointType.
/// </summary>
internal record BottomRule(string Value, BreakpointType? Breakpoint = null);
