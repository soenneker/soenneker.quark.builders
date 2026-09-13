namespace Soenneker.Quark;

/// <summary>
/// Represents a single mix-blend-mode rule with optional BreakpointType.
/// </summary>
internal readonly record struct MixBlendModeRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
