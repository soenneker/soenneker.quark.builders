using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Min-width builder with fluent API for chaining Tailwind min-w-* rules.
/// Modifiers apply to the next value in the chain.
/// </summary>
[TailwindPrefix("min-w-", Responsive = true)]
public sealed class MinWidthBuilder : CssBuilderBase<MinWidthBuilder>
{
    private RuleList<MinWidthRule> _rules;

    internal MinWidthBuilder()
    {
    }

    internal MinWidthBuilder(string size)
    {
        _rules.Add(new MinWidthRule(size));
    }

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public MinWidthBuilder Is0 => ChainWithSize("min-w-0");
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public MinWidthBuilder Is5 => ChainWithSize("min-w-5");
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public MinWidthBuilder Is16 => ChainWithSize("min-w-16");
    /// <summary>
    /// Spacing/sizing scale step `24`.
    /// </summary>
    public MinWidthBuilder Is24 => ChainWithSize("min-w-24");
    /// <summary>
    /// Spacing/sizing scale step `32`.
    /// </summary>
    public MinWidthBuilder Is32 => ChainWithSize("min-w-32");
    /// <summary>
    /// Gets or sets is36.
    /// </summary>
    public MinWidthBuilder Is36 => ChainWithSize("min-w-36");
    /// <summary>
    /// Spacing/sizing scale step `56`.
    /// </summary>
    public MinWidthBuilder Is56 => ChainWithSize("min-w-56");
    /// <summary>
    /// Fluent step for `Is Px` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MinWidthBuilder IsPx => ChainWithSize("min-w-px");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MinWidthBuilder IsFull => ChainWithSize("min-w-full");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MinWidthBuilder IsMin => ChainWithSize("min-w-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MinWidthBuilder IsMax => ChainWithSize("min-w-max");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MinWidthBuilder IsFit => ChainWithSize("min-w-fit");

    /// <summary>
    /// Create from an arbitrary Tailwind min-width token (e.g. "24", "[8rem]", "[12rem]").
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public MinWidthBuilder Token(string token) => ChainWithSize("min-w-" + token);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MinWidthBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = null;
        _rules.Add(new MinWidthRule(size, bp, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass() => _rules.CachedClass ??= BuildClass();

    private string BuildClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            MinWidthRule rule = _rules[0];
            return ClassWriter.Render(rule.Size, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                MinWidthRule rule = _rules[i];
                writer.Add(rule.Size, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }
}
