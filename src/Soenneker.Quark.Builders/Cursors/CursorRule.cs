namespace Soenneker.Quark;

/// <summary>
/// Represents a single cursor rule with optional BreakpointType.
/// </summary>
internal readonly record struct CursorRule(string Cursor, BreakpointType? Breakpoint = null, string? ModifierChain = null);
