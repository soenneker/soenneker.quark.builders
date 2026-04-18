namespace Soenneker.Quark;

/// <summary>
/// Represents a single outline-style rule with optional BreakpointType.
/// </summary>
internal record OutlineStyleRule(OutlineStyleEnum Value, BreakpointType? Breakpoint = null);
