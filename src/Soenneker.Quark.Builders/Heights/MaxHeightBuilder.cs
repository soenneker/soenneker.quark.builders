using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Max-height builder with fluent API. Tailwind-first (max-h-*).
/// </summary>
[TailwindPrefix("max-h-", Responsive = true)]
public sealed class MaxHeightBuilder : CssBuilderBase<MaxHeightBuilder>
{
    private readonly List<UtilityRule> _rules = new(4);

    internal MaxHeightBuilder()
    {
    }

    internal MaxHeightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new UtilityRule(value, breakpoint));
    }

    /// <summary>
    /// Gets or sets is none.
    /// </summary>
    public MaxHeightBuilder IsNone => Chain("max-h-none");
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public MaxHeightBuilder Is0 => Chain("max-h-0");
    /// <summary>
    /// Gets or sets is px.
    /// </summary>
    public MaxHeightBuilder IsPx => Chain("max-h-px");
    /// <summary>
    /// Gets or sets is full.
    /// </summary>
    public MaxHeightBuilder IsFull => Chain("max-h-full");
    /// <summary>
    /// Gets or sets is screen.
    /// </summary>
    public MaxHeightBuilder IsScreen => Chain("max-h-screen");
    /// <summary>
    /// Gets or sets is svh.
    /// </summary>
    public MaxHeightBuilder IsSvh => Chain("max-h-svh");
    /// <summary>
    /// Gets or sets is lvh.
    /// </summary>
    public MaxHeightBuilder IsLvh => Chain("max-h-lvh");
    /// <summary>
    /// Gets or sets is dvh.
    /// </summary>
    public MaxHeightBuilder IsDvh => Chain("max-h-dvh");
    /// <summary>
    /// Gets or sets is min.
    /// </summary>
    public MaxHeightBuilder IsMin => Chain("max-h-min");
    /// <summary>
    /// Gets or sets is max.
    /// </summary>
    public MaxHeightBuilder IsMax => Chain("max-h-max");
    /// <summary>
    /// Gets or sets is fit.
    /// </summary>
    public MaxHeightBuilder IsFit => Chain("max-h-fit");
    /// <summary>
    /// Adds an arbitrary max height utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public MaxHeightBuilder Token(string value) => Chain(Normalize(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MaxHeightBuilder Chain(string value)
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
    private static string Normalize(string value) => value.StartsWith("max-h-") ? value : "max-h-" + value;
}
