using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents the border color builder.
/// </summary>
[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderColorBuilder : ColorBuilderBase<BorderColorBuilder>
{
    private const string Prefix = "border-";

    private readonly List<BorderColorRule> _rules = new(4);

    internal BorderColorBuilder()
    {
    }

    internal BorderColorBuilder(BorderColorEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BorderColorRule(value.Value, breakpoint));
    }

    internal BorderColorBuilder(string value, BreakpointType? breakpoint = null)
    {
        if (value.Length != 0)
            _rules.Add(new BorderColorRule(value, breakpoint));
    }

    internal BorderColorBuilder(List<BorderColorRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets primary.
    /// </summary>
    public BorderColorBuilder Primary => ChainValue(BorderColorEnum.Primary);
    /// <summary>
    /// Gets or sets secondary.
    /// </summary>
    public BorderColorBuilder Secondary => ChainValue(BorderColorEnum.Secondary);
    /// <summary>
    /// Gets or sets destructive.
    /// </summary>
    public BorderColorBuilder Destructive => ChainValue(BorderColorEnum.Destructive);
    /// <summary>
    /// Gets or sets muted.
    /// </summary>
    public BorderColorBuilder Muted => ChainValue(BorderColorEnum.Muted);
    /// <summary>
    /// Gets or sets accent.
    /// </summary>
    public BorderColorBuilder Accent => ChainValue(BorderColorEnum.Accent);
    /// <summary>
    /// Gets or sets popover.
    /// </summary>
    public BorderColorBuilder Popover => ChainValue(BorderColorEnum.Popover);
    /// <summary>
    /// Gets or sets card.
    /// </summary>
    public BorderColorBuilder Card => ChainValue(BorderColorEnum.Card);
    /// <summary>
    /// Gets or sets background.
    /// </summary>
    public BorderColorBuilder Background => ChainValue(BorderColorEnum.Background);
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public BorderColorBuilder Border => ChainValue(BorderColorEnum.Border);
    /// <summary>
    /// Gets or sets input.
    /// </summary>
    public BorderColorBuilder Input => ChainValue(BorderColorEnum.Input);
    /// <summary>
    /// Gets or sets ring.
    /// </summary>
    public BorderColorBuilder Ring => ChainValue(BorderColorEnum.Ring);
    /// <summary>
    /// Gets or sets current.
    /// </summary>
    public BorderColorBuilder Current => ChainValue(BorderColorEnum.Current);

    /// <summary>
    /// Gets or sets white.
    /// </summary>
    public BorderColorBuilder White => ChainValue(BorderColorEnum.White);
    /// <summary>
    /// Gets or sets black.
    /// </summary>
    public BorderColorBuilder Black => ChainValue(BorderColorEnum.Black);
    /// <summary>
    /// Gets or sets transparent.
    /// </summary>
    public BorderColorBuilder Transparent => ChainValue(BorderColorEnum.Transparent);


    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The result of the operation.</returns>
    public override BorderColorBuilder Token(string token) => ChainClass(ColorUtility.CreateClass(Prefix, token));

    /// <summary>
    /// Adds the utility Border Color utility to the class list.
    /// </summary>
    /// <param name="utility">Utility name to append to the generated class list.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BorderColorBuilder Utility(string utility) => ChainClass(ColorUtility.CreateUtilityClass(Prefix, utility));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderColorBuilder ChainValue(BorderColorEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new BorderColorRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BorderColorBuilder ChainClass(string value)
    {
        BreakpointType? bp = null;
        if (value.Length != 0)
            _rules.Add(new BorderColorRule(value, bp, ConsumePendingModifierChain()));
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
            BorderColorRule rule = _rules[i];
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
