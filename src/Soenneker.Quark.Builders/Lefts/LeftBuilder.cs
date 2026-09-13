using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Left offset builder. Tailwind: left-*.
/// </summary>
[TailwindPrefix("left-", Responsive = true)]
public sealed class LeftBuilder : CssBuilderBase<LeftBuilder>
{
    private RuleList<LeftRule> _rules;

    internal LeftBuilder()
    {
    }

    internal LeftBuilder(LeftEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value.Value, breakpoint));
    }

    internal LeftBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value, breakpoint));
    }

    internal LeftBuilder(List<LeftRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public LeftBuilder Is0 => Chain(LeftEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public LeftBuilder Is1 => Chain(LeftEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public LeftBuilder Is1_5 => Chain(LeftEnum.Is1_5Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public LeftBuilder Is2 => Chain(LeftEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public LeftBuilder Is3 => Chain(LeftEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public LeftBuilder Is4 => Chain(LeftEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public LeftBuilder Is5 => Chain(LeftEnum.Is5Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public LeftBuilder Is8 => Chain(LeftEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public LeftBuilder Is12 => Chain(LeftEnum.Is12Value);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public LeftBuilder Is16 => Chain(LeftEnum.Is16Value);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public LeftBuilder Is24 => Chain(LeftEnum.Is24Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public LeftBuilder Auto => Chain(LeftEnum.AutoValue);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public LeftBuilder Px => Chain(LeftEnum.PxValue);
    /// <summary>
    /// Adds an arbitrary left utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public LeftBuilder Token(string value) => Chain(value.StartsWith("left-") ? value : "left-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(LeftEnum value)
    {
        _rules.Add(new LeftRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(string value)
    {
        _rules.Add(new LeftRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            LeftRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                LeftRule rule = _rules[i];
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
