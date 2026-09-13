namespace Soenneker.Quark;

/// <summary>
/// Represents a single screen reader rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScreenReaderRule(string Type, BreakpointType? Breakpoint = null, string? ModifierChain = null);

