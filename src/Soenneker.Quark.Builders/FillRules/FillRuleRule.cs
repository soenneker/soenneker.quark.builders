namespace Soenneker.Quark;

/// <summary>
/// Represents a single fill-rule (SVG) rule with optional BreakpointType.
/// </summary>
internal readonly record struct FillRuleRule(string Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
