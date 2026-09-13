using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Bottom offset builder. Tailwind: bottom-*.
/// </summary>
[TailwindPrefix("bottom-", Responsive = true)]
public sealed class BottomBuilder : CssBuilderBase<BottomBuilder>
{
    private RuleList<BottomRule> _rules;

    internal BottomBuilder()
    {
    }

    internal BottomBuilder(BottomEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BottomRule(value.Value, breakpoint));
    }

    internal BottomBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BottomRule(value, breakpoint));
    }

    internal BottomBuilder(List<BottomRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public BottomBuilder Is0 => Chain(BottomEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public BottomBuilder Is1 => Chain(BottomEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public BottomBuilder Is1_5 => Chain(BottomEnum.Is1_5Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public BottomBuilder Is2 => Chain(BottomEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public BottomBuilder Is3 => Chain(BottomEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public BottomBuilder Is4 => Chain(BottomEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public BottomBuilder Is5 => Chain(BottomEnum.Is5Value);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public BottomBuilder Is6 => Chain(BottomEnum.Is6Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public BottomBuilder Is8 => Chain(BottomEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public BottomBuilder Is12 => Chain(BottomEnum.Is12Value);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public BottomBuilder Is16 => Chain(BottomEnum.Is16Value);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public BottomBuilder Is24 => Chain(BottomEnum.Is24Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public BottomBuilder Auto => Chain(BottomEnum.AutoValue);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public BottomBuilder Px => Chain(BottomEnum.PxValue);
    /// <summary>
    /// Gets or sets negative1.
    /// </summary>
    public BottomBuilder Negative1 => Chain(BottomEnum.Negative1Value);
    /// <summary>
    /// Adds an arbitrary bottom utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BottomBuilder Token(string value) => Chain(value.StartsWith("bottom-") ? value : "bottom-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BottomBuilder Chain(BottomEnum value)
    {
        _rules.Add(new BottomRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BottomBuilder Chain(string value)
    {
        _rules.Add(new BottomRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            BottomRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                BottomRule rule = _rules[i];
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
