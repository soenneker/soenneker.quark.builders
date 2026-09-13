using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Right offset builder. Tailwind: right-*.
/// </summary>
[TailwindPrefix("right-", Responsive = true)]
public sealed class RightBuilder : CssBuilderBase<RightBuilder>
{
    private RuleList<RightRule> _rules;

    internal RightBuilder()
    {
    }

    internal RightBuilder(RightEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value.Value, breakpoint));
    }

    internal RightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value, breakpoint));
    }

    internal RightBuilder(List<RightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public RightBuilder Is0 => Chain(RightEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public RightBuilder Is1 => Chain(RightEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public RightBuilder Is1_5 => Chain(RightEnum.Is1_5Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public RightBuilder Is2 => Chain(RightEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public RightBuilder Is3 => Chain(RightEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public RightBuilder Is4 => Chain(RightEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public RightBuilder Is5 => Chain(RightEnum.Is5Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public RightBuilder Is8 => Chain(RightEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public RightBuilder Is12 => Chain(RightEnum.Is12Value);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public RightBuilder Is16 => Chain(RightEnum.Is16Value);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public RightBuilder Is24 => Chain(RightEnum.Is24Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public RightBuilder Auto => Chain(RightEnum.AutoValue);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public RightBuilder Px => Chain(RightEnum.PxValue);
    /// <summary>
    /// Adds an arbitrary right utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public RightBuilder Token(string value) => Chain(value.StartsWith("right-") ? value : "right-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(RightEnum value)
    {
        _rules.Add(new RightRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(string value)
    {
        _rules.Add(new RightRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            RightRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                RightRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
