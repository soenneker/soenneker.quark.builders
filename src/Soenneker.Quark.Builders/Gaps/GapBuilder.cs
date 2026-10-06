using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Simplified gap builder with fluent API for chaining gap rules.
/// </summary>
[TailwindPrefix("gap-", Responsive = true)]
public sealed class GapBuilder : CssBuilderBase<GapBuilder>
{
    private RuleList<UtilityRule> _rules;
    private GapAxisEnum _pendingAxis = GapAxisEnum.All;

    internal GapBuilder()
    {
    }

    internal GapBuilder(string size, BreakpointType? breakpoint = null, GapAxisEnum? axis = null)
    {
        if (size.Length != 0)
            _rules.Add(new UtilityRule(CreateAxisClass(size, axis ?? GapAxisEnum.All), breakpoint));
    }

    internal GapBuilder(List<UtilityRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is0 => ChainWithSize(GapScaleEnum.Is0Value);
    /// <summary>
    /// Gets or sets is0 25.
    /// </summary>
    public GapBuilder Is0_25 => ChainWithSize(GapScaleEnum.Is0_25Value);
    /// <summary>
    /// Gets or sets is0 5.
    /// </summary>
    public GapBuilder Is0_5 => ChainWithSize(GapScaleEnum.Is0_5Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is1 => ChainWithSize(GapScaleEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 25.
    /// </summary>
    public GapBuilder Is1_25 => ChainWithSize(GapScaleEnum.Is1_25Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public GapBuilder Is1_5 => ChainWithSize(GapScaleEnum.Is1_5Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is2 => ChainWithSize(GapScaleEnum.Is2Value);
    /// <summary>
    /// Gets or sets is2 5.
    /// </summary>
    public GapBuilder Is2_5 => ChainWithSize(GapScaleEnum.Is2_5Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is3 => ChainWithSize(GapScaleEnum.Is3Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is4 => ChainWithSize(GapScaleEnum.Is4Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is5 => ChainWithSize(GapScaleEnum.Is5Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is6 => ChainWithSize(GapScaleEnum.Is6Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is8 => ChainWithSize(GapScaleEnum.Is8Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is10 => ChainWithSize(GapScaleEnum.Is10Value);

    /// <summary>
    /// Chain with a new size for the next rule.
    /// </summary>
    public GapBuilder Is12 => ChainWithSize(GapScaleEnum.Is12Value);

    /// <summary>
    /// Chain with an arbitrary Tailwind gap token for the next rule.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public GapBuilder Token(string value) => ChainWithSize(UtilityToken.WithPrefix(value, "gap-"));

    /// <summary>
    /// Apply to column gap only.
    /// </summary>
    public GapBuilder X => ChainWithAxis(GapAxisEnum.X);

    /// <summary>
    /// Gets or sets column.
    /// </summary>
    public GapBuilder Column => X;

    /// <summary>
    /// Apply to row gap only.
    /// </summary>
    public GapBuilder Y => ChainWithAxis(GapAxisEnum.Y);

    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public GapBuilder Row => Y;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder ChainWithSize(string size)
    {
        _rules.Add(new UtilityRule(CreateAxisClass(size, _pendingAxis), null, ConsumePendingModifierChain()));
        _pendingAxis = GapAxisEnum.All;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder ChainWithAxis(GapAxisEnum axis)
    {
        _pendingAxis = axis;
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


    private static string CreateAxisClass(string value, GapAxisEnum axis) =>
        axis == GapAxisEnum.All ? value : string.Concat(axis.Value, value.AsSpan(4));
}
