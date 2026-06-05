using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Min-height builder with fluent API. Tailwind-first (min-h-*).
/// </summary>
[TailwindPrefix("min-h-", Responsive = true)]
public sealed class MinHeightBuilder : CssBuilderBase<MinHeightBuilder>
{
    private readonly List<UtilityRule> _rules = new(4);

    internal MinHeightBuilder()
    {
    }

    internal MinHeightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UtilityRule(value, breakpoint));
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public MinHeightBuilder Is0 => Chain("min-h-0");
    /// <summary>
    /// Gets or sets is px.
    /// </summary>
    public MinHeightBuilder IsPx => Chain("min-h-px");
    /// <summary>
    /// Gets or sets is full.
    /// </summary>
    public MinHeightBuilder IsFull => Chain("min-h-full");
    /// <summary>
    /// Gets or sets is screen.
    /// </summary>
    public MinHeightBuilder IsScreen => Chain("min-h-screen");
    /// <summary>
    /// Gets or sets is svh.
    /// </summary>
    public MinHeightBuilder IsSvh => Chain("min-h-svh");
    /// <summary>
    /// Gets or sets is lvh.
    /// </summary>
    public MinHeightBuilder IsLvh => Chain("min-h-lvh");
    /// <summary>
    /// Gets or sets is dvh.
    /// </summary>
    public MinHeightBuilder IsDvh => Chain("min-h-dvh");
    /// <summary>
    /// Gets or sets is min.
    /// </summary>
    public MinHeightBuilder IsMin => Chain("min-h-min");
    /// <summary>
    /// Gets or sets is max.
    /// </summary>
    public MinHeightBuilder IsMax => Chain("min-h-max");
    /// <summary>
    /// Gets or sets is fit.
    /// </summary>
    public MinHeightBuilder IsFit => Chain("min-h-fit");
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public MinHeightBuilder Token(string value) => Chain(Normalize(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MinHeightBuilder Chain(string value)
    {
        _rules.Add(new UtilityRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            UtilityRule rule = _rules[i];
            string cls = rule.Value;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string Normalize(string value) => value.StartsWith("min-h-") ? value : "min-h-" + value;
}
