namespace Soenneker.Quark;

/// <summary>
/// Represents a single scale rule.
/// </summary>
internal record ScaleRule(ScaleEnum Scale, string? ModifierChain = null);
