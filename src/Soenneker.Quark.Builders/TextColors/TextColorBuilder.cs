using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text color builder.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextColorBuilder : ColorBuilderBase<TextColorBuilder>
{
    private const string Prefix = "text-";

    private readonly List<TextColorRule> _rules = new(4);

    internal TextColorBuilder()
    {
    }

    internal TextColorBuilder(TextColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextColorRule(value.Value, breakpoint));
    }

    internal TextColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new TextColorRule(value, breakpoint));
    }

    internal TextColorBuilder(List<TextColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public TextColorBuilder Primary => ChainValue(TextColorEnum.Primary);
    /// <summary>
    /// Gets or sets primary foreground.
    /// </summary>
    public TextColorBuilder PrimaryForeground => ChainValue(TextColorEnum.PrimaryForeground);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public TextColorBuilder Secondary => ChainValue(TextColorEnum.Secondary);
    /// <summary>
    /// Gets or sets secondary foreground.
    /// </summary>
    public TextColorBuilder SecondaryForeground => ChainValue(TextColorEnum.SecondaryForeground);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public TextColorBuilder Destructive => ChainValue(TextColorEnum.Destructive);
    /// <summary>
    /// Gets or sets destructive foreground.
    /// </summary>
    public TextColorBuilder DestructiveForeground => ChainValue(TextColorEnum.DestructiveForeground);
    /// <summary>
    /// Gets or sets muted foreground.
    /// </summary>
    public TextColorBuilder MutedForeground => ChainValue(TextColorEnum.MutedForeground);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public TextColorBuilder Accent => ChainValue(TextColorEnum.Accent);
    /// <summary>
    /// Gets or sets accent foreground.
    /// </summary>
    public TextColorBuilder AccentForeground => ChainValue(TextColorEnum.AccentForeground);
    /// <summary>
    /// Gets or sets popover foreground.
    /// </summary>
    public TextColorBuilder PopoverForeground => ChainValue(TextColorEnum.PopoverForeground);
    /// <summary>
    /// Gets or sets card foreground.
    /// </summary>
    public TextColorBuilder CardForeground => ChainValue(TextColorEnum.CardForeground);
    /// <summary>
    /// Gets or sets foreground.
    /// </summary>
    public TextColorBuilder Foreground => ChainValue(TextColorEnum.Foreground);
    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public TextColorBuilder White => ChainValue(TextColorEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public TextColorBuilder Black => ChainValue(TextColorEnum.Black);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override TextColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Executes the utility operation.
    /// </summary>
    /// <param name="utility">The utility.</param>
    /// <returns>The result of the operation.</returns>
    public TextColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextColorBuilder ChainValue(TextColorEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new TextColorRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = null;
        if (value.Length != 0)
            _rules.Add(new TextColorRule(value, bp, ConsumePendingModifierChain()));
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
            TextColorRule rule = _rules[i];
            string cls = rule.Value;
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) sb.Append(' ');
            else first = false;

            sb.Append(cls);
        }

        return sb.ToString();
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
