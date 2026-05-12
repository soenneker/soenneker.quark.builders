
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified opacity builder with fluent API for chaining opacity rules.
/// </summary>
[TailwindPrefix("opacity-", Responsive = true)]
public sealed class OpacityBuilder : CssBuilderBase<OpacityBuilder>
{
    private readonly List<OpacityRule> _rules = new(4);

    internal OpacityBuilder()
    {
    }

    internal OpacityBuilder(OpacityEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OpacityRule(value.Value, breakpoint));
    }

    internal OpacityBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new OpacityRule(value, breakpoint));
    }

    internal OpacityBuilder(List<OpacityRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the opacity to 0 (fully transparent).
    /// </summary>
    public OpacityBuilder Is0 => Chain(OpacityEnum.Is0);
    public OpacityBuilder Is5 => Chain(OpacityEnum.Is5);
    public OpacityBuilder Is10 => Chain(OpacityEnum.Is10);
    public OpacityBuilder Is15 => Chain(OpacityEnum.Is15);
    public OpacityBuilder Is20 => Chain(OpacityEnum.Is20);

    /// <summary>
    /// Sets the opacity to 25%.
    /// </summary>
    public OpacityBuilder Is25 => Chain(OpacityEnum.Is25);
    public OpacityBuilder Is30 => Chain(OpacityEnum.Is30);
    public OpacityBuilder Is35 => Chain(OpacityEnum.Is35);
    public OpacityBuilder Is40 => Chain(OpacityEnum.Is40);
    public OpacityBuilder Is45 => Chain(OpacityEnum.Is45);

    /// <summary>
    /// Sets the opacity to 50%.
    /// </summary>
    public OpacityBuilder Is50 => Chain(OpacityEnum.Is50);
    public OpacityBuilder Is55 => Chain(OpacityEnum.Is55);

    /// <summary>
    /// Sets the opacity to 60%.
    /// </summary>
    public OpacityBuilder Is60 => Chain(OpacityEnum.Is60);
    public OpacityBuilder Is65 => Chain(OpacityEnum.Is65);

    /// <summary>
    /// Sets the opacity to 70%.
    /// </summary>
    public OpacityBuilder Is70 => Chain(OpacityEnum.Is70);

    /// <summary>
    /// Sets the opacity to 75%.
    /// </summary>
    public OpacityBuilder Is75 => Chain(OpacityEnum.Is75);
    public OpacityBuilder Is80 => Chain(OpacityEnum.Is80);
    public OpacityBuilder Is85 => Chain(OpacityEnum.Is85);
    public OpacityBuilder Is90 => Chain(OpacityEnum.Is90);
    public OpacityBuilder Is95 => Chain(OpacityEnum.Is95);

    /// <summary>
    /// Sets the opacity to 100% (fully opaque).
    /// </summary>
    public OpacityBuilder Is100 => Chain(OpacityEnum.Is100);

    public OpacityBuilder Token(string value) => Chain(NormalizeOpacityClass(value));







    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OpacityBuilder Chain(OpacityEnum value)
    {
        return Chain(value.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private OpacityBuilder Chain(string value)
    {
        _rules.Add(new OpacityRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    /// <returns>The CSS class string.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;
        for (var i = 0; i < _rules.Count; i++)
        {
            OpacityRule rule = _rules[i];
            string cls = rule.Value;
            string? modifierChain = rule.ModifierChain ?? (i == _rules.Count - 1 ? PendingModifierChain : null);
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (modifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, modifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeOpacityClass(string value)
    {
        if (value.Length == 0)
            return string.Empty;

        return value.StartsWith("opacity-") ? value : "opacity-" + value;
    }
    
    public override string ToString() => ToClass();
}
