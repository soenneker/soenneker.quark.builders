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
    private RuleList<UtilityRule> _rules;

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
    /// Adds an arbitrary min height utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public MinHeightBuilder Token(string value) => Chain(Normalize(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MinHeightBuilder Chain(string value)
    {
        _rules.Add(new UtilityRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            UtilityRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                UtilityRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string Normalize(string value) => value.StartsWith("min-h-") ? value : "min-h-" + value;
}
