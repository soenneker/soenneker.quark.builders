namespace Soenneker.Quark;

/// <summary>
/// Represents a single display rule with optional BreakpointType and Tailwind modifiers.
/// </summary>
internal record DisplayRule(string Display, BreakpointType? Breakpoint = null, string? ModifierChain = null);

