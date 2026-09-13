namespace Soenneker.Quark;

/// <summary>
/// Represents a single scroll behavior rule with optional BreakpointType.
/// </summary>
internal readonly record struct ScrollBehaviorRule(string Behavior, BreakpointType? Breakpoint = null, string? ModifierChain = null);

