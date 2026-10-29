using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Max-width builder with fluent API for chaining Tailwind max-w-* rules.
/// Modifiers apply to the next value in the chain.
/// </summary>
[TailwindPrefix("max-w-", Responsive = true)]
public sealed class MaxWidthBuilder : CssBuilderBase<MaxWidthBuilder>
{
    private RuleList<MaxWidthRule> _rules;

    internal MaxWidthBuilder()
    {
    }

    internal MaxWidthBuilder(string size)
    {
        _rules.Add(new MaxWidthRule(size));
    }

    /// <summary>
    /// Fluent step for `Is None` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsNone => ChainWithSize("max-w-none");
    /// <summary>
    /// Gets or sets is48.
    /// </summary>
    public MaxWidthBuilder Is48 => ChainWithSize("max-w-48");
    /// <summary>
    /// Fluent step for `Is Xs` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsXs => ChainWithSize("max-w-xs");
    /// <summary>
    /// Fluent step for `Is Sm` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsSm => ChainWithSize("max-w-sm");
    /// <summary>
    /// Fluent step for `Is Md` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsMd => ChainWithSize("max-w-md");
    /// <summary>
    /// Fluent step for `Is Lg` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsLg => ChainWithSize("max-w-lg");
    /// <summary>
    /// Fluent step for `Is Xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsXl => ChainWithSize("max-w-xl");
    /// <summary>
    /// Fluent step for `Is2xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is2xl => ChainWithSize("max-w-2xl");
    /// <summary>
    /// Fluent step for `Is3xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is3xl => ChainWithSize("max-w-3xl");
    /// <summary>
    /// Fluent step for `Is4xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is4xl => ChainWithSize("max-w-4xl");
    /// <summary>
    /// Fluent step for `Is5xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is5xl => ChainWithSize("max-w-5xl");
    /// <summary>
    /// Fluent step for `Is6xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is6xl => ChainWithSize("max-w-6xl");
    /// <summary>
    /// Fluent step for `Is7xl` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder Is7xl => ChainWithSize("max-w-7xl");
    /// <summary>
    /// Fluent step for `Is Full` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsFull => ChainWithSize("max-w-full");
    /// <summary>
    /// Fluent step for `Is Min` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsMin => ChainWithSize("max-w-min");
    /// <summary>
    /// Fluent step for `Is Max` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsMax => ChainWithSize("max-w-max");
    /// <summary>
    /// Fluent step for `Is Fit` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsFit => ChainWithSize("max-w-fit");
    /// <summary>
    /// Fluent step for `Is Screen` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsScreen => ChainWithSize("max-w-screen");
    /// <summary>
    /// Fluent step for `Is Prose` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MaxWidthBuilder IsProse => ChainWithSize("max-w-prose");

    /// <summary>
    /// Create from an arbitrary Tailwind max-width token (e.g. "4xl", "[56rem]", "[75ch]").
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public MaxWidthBuilder Token(string token) => ChainWithSize("max-w-" + token);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MaxWidthBuilder ChainWithSize(string size)
    {
        BreakpointType? bp = null;
        _rules.Add(new MaxWidthRule(size, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass() => _rules.CachedClass ??= BuildClass();

    private string BuildClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            MaxWidthRule rule = _rules[0];
            return ClassWriter.Render(rule.Size, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                MaxWidthRule rule = _rules[i];
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
