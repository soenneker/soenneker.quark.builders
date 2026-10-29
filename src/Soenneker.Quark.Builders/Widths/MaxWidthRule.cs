namespace Soenneker.Quark;

/// <summary>
/// Represents a single max-width rule with optional BreakpointType.
/// </summary>
internal readonly record struct MaxWidthRule(string Size, BreakpointType? Breakpoint = null, string? ModifierChain = null);

