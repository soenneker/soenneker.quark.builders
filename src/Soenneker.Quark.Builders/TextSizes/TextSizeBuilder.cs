
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;


namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned text size builder.
/// </summary>
[TailwindPrefix("text-", Responsive = true)]
public sealed class TextSizeBuilder : CssBuilderBase<TextSizeBuilder>
{
    private readonly List<TextSizeRule> _rules = new(4);

    internal TextSizeBuilder()
    {
    }

    internal TextSizeBuilder(string size, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TextSizeRule(size, breakpoint));
    }

    internal TextSizeBuilder(List<TextSizeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Xs` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public TextSizeBuilder Xs => ChainSize("text-xs");
    /// <summary>
    /// `rounded-sm` — small radius (default theme `0.125rem`).
    /// </summary>
    public TextSizeBuilder Sm => ChainSize("text-sm");
    /// <summary>
    /// Fluent step for `Base` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public TextSizeBuilder Base => ChainSize("text-base");
    /// <summary>
    /// `rounded-lg` — large radius (default theme `0.5rem`).
    /// </summary>
    public TextSizeBuilder Lg => ChainSize("text-lg");
    /// <summary>
    /// `rounded-xl` — extra-large radius (default theme `0.75rem`).
    /// </summary>
    public TextSizeBuilder Xl => ChainSize("text-xl");
    /// <summary>
    /// `rounded-2xl` — 2× XL radius (default theme `1rem`).
    /// </summary>
    public TextSizeBuilder TwoXl => ChainSize("text-2xl");
    /// <summary>
    /// `rounded-3xl` — very large radius (default theme `1.5rem`).
    /// </summary>
    public TextSizeBuilder ThreeXl => ChainSize("text-3xl");
    /// <summary>
    /// Fluent step for `Four Xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public TextSizeBuilder FourXl => ChainSize("text-4xl");
    /// <summary>
    /// Gets or sets five xl.
    /// </summary>
    public TextSizeBuilder FiveXl => ChainSize("text-5xl");
    /// <summary>
    /// Gets or sets six xl.
    /// </summary>
    public TextSizeBuilder SixXl => ChainSize("text-6xl");
    /// <summary>
    /// Gets or sets seven xl.
    /// </summary>
    public TextSizeBuilder SevenXl => ChainSize("text-7xl");
    /// <summary>
    /// Gets or sets eight xl.
    /// </summary>
    public TextSizeBuilder EightXl => ChainSize("text-8xl");
    /// <summary>
    /// Gets or sets nine xl.
    /// </summary>
    public TextSizeBuilder NineXl => ChainSize("text-9xl");

    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TextSizeBuilder Token(string value) => ChainSize(NormalizeTextSizeClass(value));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TextSizeBuilder ChainSize(string size)
    {
        _rules.Add(new TextSizeRule(size, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>Gets the CSS class string for the current configuration.</summary>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            TextSizeRule rule = _rules[i];

            string sizeClass = rule.Size;
            if (sizeClass.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                sizeClass = BreakpointUtil.ApplyTailwindBreakpoint(sizeClass, bp);

            if (rule.ModifierChain is { Length: > 0 })
                sizeClass = BreakpointUtil.ApplyTailwindModifiers(sizeClass, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(sizeClass);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string NormalizeTextSizeClass(string size)
    {
        if (size.Length == 0)
            return string.Empty;

        return size.StartsWith("text-") ? size : "text-" + size;
    }
}
