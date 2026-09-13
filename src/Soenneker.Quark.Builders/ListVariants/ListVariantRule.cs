namespace Soenneker.Quark;

/// <summary>
/// Represents a single list variant rule with optional BreakpointType.
/// </summary>
internal readonly record struct ListVariantRule(ListVariantType Type, BreakpointType? Breakpoint = null, string? ModifierChain = null);


