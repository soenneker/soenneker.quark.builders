namespace Soenneker.Quark;

/// <summary>
/// Represents a single scale rule.
/// </summary>
internal readonly record struct ScaleRule(ScaleEnum Scale, string? ModifierChain = null);
