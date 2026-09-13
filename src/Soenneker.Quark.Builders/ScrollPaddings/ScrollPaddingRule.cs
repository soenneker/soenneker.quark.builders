namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll-padding rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollPaddingRule(string Size, ElementSideEnum Side, BreakpointType? Breakpoint = null, string? ModifierChain = null);
