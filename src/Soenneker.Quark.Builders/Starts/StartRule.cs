namespace Soenneker.Quark;

/// <summary>
/// Represents a single start (inset-inline-start) rule with optional BreakpointType.
/// </summary>
internal readonly record struct StartRule(StartEnum Value, BreakpointType? Breakpoint = null, string? ModifierChain = null);
