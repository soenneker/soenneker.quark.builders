namespace Soenneker.Quark;

/// <summary>
/// Represents a single background-blend-mode rule with optional BreakpointType.
/// </summary>
internal readonly record struct BackgroundBlendModeRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
