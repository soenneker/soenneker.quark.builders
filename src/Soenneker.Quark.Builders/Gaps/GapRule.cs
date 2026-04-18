namespace Soenneker.Quark;

/// <summary>
/// Represents a single gap rule with optional BreakpointType and direction.
/// </summary>
internal readonly record struct GapRule(string Size, GapAxisEnum Axis, BreakpointType? Breakpoint = null);
