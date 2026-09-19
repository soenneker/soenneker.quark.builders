namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical minblocksize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("min-block-", Responsive = true)]
public sealed class MinBlockSizeBuilder : FinalClassUtilityBuilder<MinBlockSizeBuilder>
{
    internal MinBlockSizeBuilder()
    {
    }

    internal MinBlockSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>min-block-0</c>.</summary>
    public MinBlockSizeBuilder Is0 => ChainClass("min-block-0");

    /// <summary>Adds <c>min-block-0.5</c>.</summary>
    public MinBlockSizeBuilder Is0_5 => ChainClass("min-block-0.5");

    /// <summary>Adds <c>min-block-1</c>.</summary>
    public MinBlockSizeBuilder Is1 => ChainClass("min-block-1");

    /// <summary>Adds <c>min-block-1.5</c>.</summary>
    public MinBlockSizeBuilder Is1_5 => ChainClass("min-block-1.5");

    /// <summary>Adds <c>min-block-2</c>.</summary>
    public MinBlockSizeBuilder Is2 => ChainClass("min-block-2");

    /// <summary>Adds <c>min-block-2.5</c>.</summary>
    public MinBlockSizeBuilder Is2_5 => ChainClass("min-block-2.5");

    /// <summary>Adds <c>min-block-3</c>.</summary>
    public MinBlockSizeBuilder Is3 => ChainClass("min-block-3");

    /// <summary>Adds <c>min-block-3.5</c>.</summary>
    public MinBlockSizeBuilder Is3_5 => ChainClass("min-block-3.5");

    /// <summary>Adds <c>min-block-4</c>.</summary>
    public MinBlockSizeBuilder Is4 => ChainClass("min-block-4");

    /// <summary>Adds <c>min-block-5</c>.</summary>
    public MinBlockSizeBuilder Is5 => ChainClass("min-block-5");

    /// <summary>Adds <c>min-block-6</c>.</summary>
    public MinBlockSizeBuilder Is6 => ChainClass("min-block-6");

    /// <summary>Adds <c>min-block-8</c>.</summary>
    public MinBlockSizeBuilder Is8 => ChainClass("min-block-8");

    /// <summary>Adds <c>min-block-10</c>.</summary>
    public MinBlockSizeBuilder Is10 => ChainClass("min-block-10");

    /// <summary>Adds <c>min-block-12</c>.</summary>
    public MinBlockSizeBuilder Is12 => ChainClass("min-block-12");

    /// <summary>Adds <c>min-block-16</c>.</summary>
    public MinBlockSizeBuilder Is16 => ChainClass("min-block-16");

    /// <summary>Adds <c>min-block-20</c>.</summary>
    public MinBlockSizeBuilder Is20 => ChainClass("min-block-20");

    /// <summary>Adds <c>min-block-24</c>.</summary>
    public MinBlockSizeBuilder Is24 => ChainClass("min-block-24");

    /// <summary>Adds <c>min-block-32</c>.</summary>
    public MinBlockSizeBuilder Is32 => ChainClass("min-block-32");

    /// <summary>Adds <c>min-block-40</c>.</summary>
    public MinBlockSizeBuilder Is40 => ChainClass("min-block-40");

    /// <summary>Adds <c>min-block-48</c>.</summary>
    public MinBlockSizeBuilder Is48 => ChainClass("min-block-48");

    /// <summary>Adds <c>min-block-64</c>.</summary>
    public MinBlockSizeBuilder Is64 => ChainClass("min-block-64");

    /// <summary>Adds <c>min-block-96</c>.</summary>
    public MinBlockSizeBuilder Is96 => ChainClass("min-block-96");

    /// <summary>Adds <c>min-block-auto</c>.</summary>
    public MinBlockSizeBuilder Auto => ChainClass("min-block-auto");

    /// <summary>Adds <c>min-block-px</c>.</summary>
    public MinBlockSizeBuilder IsPx => ChainClass("min-block-px");

    /// <summary>Adds <c>min-block-full</c>.</summary>
    public MinBlockSizeBuilder IsFull => ChainClass("min-block-full");

    /// <summary>Adds <c>min-block-screen</c>.</summary>
    public MinBlockSizeBuilder IsScreen => ChainClass("min-block-screen");

    /// <summary>Adds <c>min-block-min</c>.</summary>
    public MinBlockSizeBuilder IsMin => ChainClass("min-block-min");

    /// <summary>Adds <c>min-block-max</c>.</summary>
    public MinBlockSizeBuilder IsMax => ChainClass("min-block-max");

    /// <summary>Adds <c>min-block-fit</c>.</summary>
    public MinBlockSizeBuilder IsFit => ChainClass("min-block-fit");

    /// <summary>Adds <c>min-block-1/2</c>.</summary>
    public MinBlockSizeBuilder Is1of2 => ChainClass("min-block-1/2");

    /// <summary>Adds <c>min-block-1/3</c>.</summary>
    public MinBlockSizeBuilder Is1of3 => ChainClass("min-block-1/3");

    /// <summary>Adds <c>min-block-2/3</c>.</summary>
    public MinBlockSizeBuilder Is2of3 => ChainClass("min-block-2/3");

    /// <summary>Adds <c>min-block-1/4</c>.</summary>
    public MinBlockSizeBuilder Is1of4 => ChainClass("min-block-1/4");

    /// <summary>Adds <c>min-block-3/4</c>.</summary>
    public MinBlockSizeBuilder Is3of4 => ChainClass("min-block-3/4");

    /// <summary>Adds <c>min-block-dvh</c>.</summary>
    public MinBlockSizeBuilder DynamicViewport => ChainClass("min-block-dvh");

    /// <summary>Adds <c>min-block-svh</c>.</summary>
    public MinBlockSizeBuilder SmallViewport => ChainClass("min-block-svh");

    /// <summary>Adds <c>min-block-lvh</c>.</summary>
    public MinBlockSizeBuilder LargeViewport => ChainClass("min-block-lvh");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MinBlockSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "min-block-"));
}
