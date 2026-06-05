
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
    private readonly List<GapRule> _rules = new(4);

    internal GapBuilder()
    {
    }

    internal GapBuilder(string size, BreakpointType? breakpoint = null, GapAxisEnum? axis = null)
    {
        if (size.Length != 0)
            _rules.Add(new GapRule(size, axis ?? GapAxisEnum.All, breakpoint));
    }

    internal GapBuilder(List<GapRule> rules)
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
    public GapBuilder Token(string value) => ChainWithSize($"gap-{value}");

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
        _rules.Add(new GapRule(size, GapAxisEnum.All, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GapBuilder ChainWithAxis(GapAxisEnum axis)
    {
        if (_rules.Count == 0)
        {
            _rules.Add(new GapRule(GapScaleEnum.Is0Value, axis, null, ConsumePendingModifierChain()));
            return this;
        }

        int lastIdx = _rules.Count - 1;
        GapRule last = _rules[lastIdx];
        string? modifierChain = ConsumePendingModifierChain();
        if (modifierChain is not { Length: > 0 })
            modifierChain = last.ModifierChain;
        _rules[lastIdx] = new GapRule(last.Size, axis, last.Breakpoint, modifierChain);
        return this;
    }

    /// <summary>
    /// Gets the CSS class string for the current configuration.
    /// </summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            GapRule rule = _rules[i];
            string cls = BuildClass(rule);
            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first) 
                sb.Append(' ');
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string BuildClass(GapRule rule)
    {
        if (rule.Size.Length == 0)
            return string.Empty;

        if (rule.Axis == GapAxisEnum.All)
            return rule.Size;

        const string defaultPrefix = "gap-";

        if (rule.Size.StartsWith(defaultPrefix, System.StringComparison.Ordinal))
            return rule.Axis.Value + rule.Size[defaultPrefix.Length..];

        return rule.Axis.Value + rule.Size;
    }

}
