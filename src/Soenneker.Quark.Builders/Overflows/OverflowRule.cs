namespace Soenneker.Quark;

/// <summary>
/// Represents a single overflow rule with optional BreakpointType.
/// </summary>
internal readonly record struct OverflowRule(string Overflow, BreakpointType? Breakpoint = null);
