namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical mininlinesize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("min-inline-", Responsive = true)]
public sealed class MinInlineSizeBuilder : FinalClassUtilityBuilder<MinInlineSizeBuilder>
{
    internal MinInlineSizeBuilder()
    {
    }

    internal MinInlineSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>min-inline-0</c>.</summary>
    public MinInlineSizeBuilder Is0 => ChainClass("min-inline-0");

    /// <summary>Adds <c>min-inline-0.5</c>.</summary>
    public MinInlineSizeBuilder Is0_5 => ChainClass("min-inline-0.5");

    /// <summary>Adds <c>min-inline-1</c>.</summary>
    public MinInlineSizeBuilder Is1 => ChainClass("min-inline-1");

    /// <summary>Adds <c>min-inline-1.5</c>.</summary>
    public MinInlineSizeBuilder Is1_5 => ChainClass("min-inline-1.5");

    /// <summary>Adds <c>min-inline-2</c>.</summary>
    public MinInlineSizeBuilder Is2 => ChainClass("min-inline-2");

    /// <summary>Adds <c>min-inline-2.5</c>.</summary>
    public MinInlineSizeBuilder Is2_5 => ChainClass("min-inline-2.5");

    /// <summary>Adds <c>min-inline-3</c>.</summary>
    public MinInlineSizeBuilder Is3 => ChainClass("min-inline-3");

    /// <summary>Adds <c>min-inline-3.5</c>.</summary>
    public MinInlineSizeBuilder Is3_5 => ChainClass("min-inline-3.5");

    /// <summary>Adds <c>min-inline-4</c>.</summary>
    public MinInlineSizeBuilder Is4 => ChainClass("min-inline-4");

    /// <summary>Adds <c>min-inline-5</c>.</summary>
    public MinInlineSizeBuilder Is5 => ChainClass("min-inline-5");

    /// <summary>Adds <c>min-inline-6</c>.</summary>
    public MinInlineSizeBuilder Is6 => ChainClass("min-inline-6");

    /// <summary>Adds <c>min-inline-8</c>.</summary>
    public MinInlineSizeBuilder Is8 => ChainClass("min-inline-8");

    /// <summary>Adds <c>min-inline-10</c>.</summary>
    public MinInlineSizeBuilder Is10 => ChainClass("min-inline-10");

    /// <summary>Adds <c>min-inline-12</c>.</summary>
    public MinInlineSizeBuilder Is12 => ChainClass("min-inline-12");

    /// <summary>Adds <c>min-inline-16</c>.</summary>
    public MinInlineSizeBuilder Is16 => ChainClass("min-inline-16");

    /// <summary>Adds <c>min-inline-20</c>.</summary>
    public MinInlineSizeBuilder Is20 => ChainClass("min-inline-20");

    /// <summary>Adds <c>min-inline-24</c>.</summary>
    public MinInlineSizeBuilder Is24 => ChainClass("min-inline-24");

    /// <summary>Adds <c>min-inline-32</c>.</summary>
    public MinInlineSizeBuilder Is32 => ChainClass("min-inline-32");

    /// <summary>Adds <c>min-inline-40</c>.</summary>
    public MinInlineSizeBuilder Is40 => ChainClass("min-inline-40");

    /// <summary>Adds <c>min-inline-48</c>.</summary>
    public MinInlineSizeBuilder Is48 => ChainClass("min-inline-48");

    /// <summary>Adds <c>min-inline-64</c>.</summary>
    public MinInlineSizeBuilder Is64 => ChainClass("min-inline-64");

    /// <summary>Adds <c>min-inline-96</c>.</summary>
    public MinInlineSizeBuilder Is96 => ChainClass("min-inline-96");

    /// <summary>Adds <c>min-inline-auto</c>.</summary>
    public MinInlineSizeBuilder Auto => ChainClass("min-inline-auto");

    /// <summary>Adds <c>min-inline-px</c>.</summary>
    public MinInlineSizeBuilder IsPx => ChainClass("min-inline-px");

    /// <summary>Adds <c>min-inline-full</c>.</summary>
    public MinInlineSizeBuilder IsFull => ChainClass("min-inline-full");

    /// <summary>Adds <c>min-inline-screen</c>.</summary>
    public MinInlineSizeBuilder IsScreen => ChainClass("min-inline-screen");

    /// <summary>Adds <c>min-inline-min</c>.</summary>
    public MinInlineSizeBuilder IsMin => ChainClass("min-inline-min");

    /// <summary>Adds <c>min-inline-max</c>.</summary>
    public MinInlineSizeBuilder IsMax => ChainClass("min-inline-max");

    /// <summary>Adds <c>min-inline-fit</c>.</summary>
    public MinInlineSizeBuilder IsFit => ChainClass("min-inline-fit");

    /// <summary>Adds <c>min-inline-1/2</c>.</summary>
    public MinInlineSizeBuilder Is1of2 => ChainClass("min-inline-1/2");

    /// <summary>Adds <c>min-inline-1/3</c>.</summary>
    public MinInlineSizeBuilder Is1of3 => ChainClass("min-inline-1/3");

    /// <summary>Adds <c>min-inline-2/3</c>.</summary>
    public MinInlineSizeBuilder Is2of3 => ChainClass("min-inline-2/3");

    /// <summary>Adds <c>min-inline-1/4</c>.</summary>
    public MinInlineSizeBuilder Is1of4 => ChainClass("min-inline-1/4");

    /// <summary>Adds <c>min-inline-3/4</c>.</summary>
    public MinInlineSizeBuilder Is3of4 => ChainClass("min-inline-3/4");

    /// <summary>Adds <c>min-inline-dvw</c>.</summary>
    public MinInlineSizeBuilder DynamicViewport => ChainClass("min-inline-dvw");

    /// <summary>Adds <c>min-inline-svw</c>.</summary>
    public MinInlineSizeBuilder SmallViewport => ChainClass("min-inline-svw");

    /// <summary>Adds <c>min-inline-lvw</c>.</summary>
    public MinInlineSizeBuilder LargeViewport => ChainClass("min-inline-lvw");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MinInlineSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "min-inline-"));
}
