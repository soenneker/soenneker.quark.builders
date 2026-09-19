namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical blocksize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("block-", Responsive = true)]
public sealed class BlockSizeBuilder : FinalClassUtilityBuilder<BlockSizeBuilder>
{
    internal BlockSizeBuilder()
    {
    }

    internal BlockSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>block-0</c>.</summary>
    public BlockSizeBuilder Is0 => ChainClass("block-0");

    /// <summary>Adds <c>block-0.5</c>.</summary>
    public BlockSizeBuilder Is0_5 => ChainClass("block-0.5");

    /// <summary>Adds <c>block-1</c>.</summary>
    public BlockSizeBuilder Is1 => ChainClass("block-1");

    /// <summary>Adds <c>block-1.5</c>.</summary>
    public BlockSizeBuilder Is1_5 => ChainClass("block-1.5");

    /// <summary>Adds <c>block-2</c>.</summary>
    public BlockSizeBuilder Is2 => ChainClass("block-2");

    /// <summary>Adds <c>block-2.5</c>.</summary>
    public BlockSizeBuilder Is2_5 => ChainClass("block-2.5");

    /// <summary>Adds <c>block-3</c>.</summary>
    public BlockSizeBuilder Is3 => ChainClass("block-3");

    /// <summary>Adds <c>block-3.5</c>.</summary>
    public BlockSizeBuilder Is3_5 => ChainClass("block-3.5");

    /// <summary>Adds <c>block-4</c>.</summary>
    public BlockSizeBuilder Is4 => ChainClass("block-4");

    /// <summary>Adds <c>block-5</c>.</summary>
    public BlockSizeBuilder Is5 => ChainClass("block-5");

    /// <summary>Adds <c>block-6</c>.</summary>
    public BlockSizeBuilder Is6 => ChainClass("block-6");

    /// <summary>Adds <c>block-8</c>.</summary>
    public BlockSizeBuilder Is8 => ChainClass("block-8");

    /// <summary>Adds <c>block-10</c>.</summary>
    public BlockSizeBuilder Is10 => ChainClass("block-10");

    /// <summary>Adds <c>block-12</c>.</summary>
    public BlockSizeBuilder Is12 => ChainClass("block-12");

    /// <summary>Adds <c>block-16</c>.</summary>
    public BlockSizeBuilder Is16 => ChainClass("block-16");

    /// <summary>Adds <c>block-20</c>.</summary>
    public BlockSizeBuilder Is20 => ChainClass("block-20");

    /// <summary>Adds <c>block-24</c>.</summary>
    public BlockSizeBuilder Is24 => ChainClass("block-24");

    /// <summary>Adds <c>block-32</c>.</summary>
    public BlockSizeBuilder Is32 => ChainClass("block-32");

    /// <summary>Adds <c>block-40</c>.</summary>
    public BlockSizeBuilder Is40 => ChainClass("block-40");

    /// <summary>Adds <c>block-48</c>.</summary>
    public BlockSizeBuilder Is48 => ChainClass("block-48");

    /// <summary>Adds <c>block-64</c>.</summary>
    public BlockSizeBuilder Is64 => ChainClass("block-64");

    /// <summary>Adds <c>block-96</c>.</summary>
    public BlockSizeBuilder Is96 => ChainClass("block-96");

    /// <summary>Adds <c>block-auto</c>.</summary>
    public BlockSizeBuilder Auto => ChainClass("block-auto");

    /// <summary>Adds <c>block-px</c>.</summary>
    public BlockSizeBuilder IsPx => ChainClass("block-px");

    /// <summary>Adds <c>block-full</c>.</summary>
    public BlockSizeBuilder IsFull => ChainClass("block-full");

    /// <summary>Adds <c>block-screen</c>.</summary>
    public BlockSizeBuilder IsScreen => ChainClass("block-screen");

    /// <summary>Adds <c>block-min</c>.</summary>
    public BlockSizeBuilder IsMin => ChainClass("block-min");

    /// <summary>Adds <c>block-max</c>.</summary>
    public BlockSizeBuilder IsMax => ChainClass("block-max");

    /// <summary>Adds <c>block-fit</c>.</summary>
    public BlockSizeBuilder IsFit => ChainClass("block-fit");

    /// <summary>Adds <c>block-1/2</c>.</summary>
    public BlockSizeBuilder Is1of2 => ChainClass("block-1/2");

    /// <summary>Adds <c>block-1/3</c>.</summary>
    public BlockSizeBuilder Is1of3 => ChainClass("block-1/3");

    /// <summary>Adds <c>block-2/3</c>.</summary>
    public BlockSizeBuilder Is2of3 => ChainClass("block-2/3");

    /// <summary>Adds <c>block-1/4</c>.</summary>
    public BlockSizeBuilder Is1of4 => ChainClass("block-1/4");

    /// <summary>Adds <c>block-3/4</c>.</summary>
    public BlockSizeBuilder Is3of4 => ChainClass("block-3/4");

    /// <summary>Adds <c>block-dvh</c>.</summary>
    public BlockSizeBuilder DynamicViewport => ChainClass("block-dvh");

    /// <summary>Adds <c>block-svh</c>.</summary>
    public BlockSizeBuilder SmallViewport => ChainClass("block-svh");

    /// <summary>Adds <c>block-lvh</c>.</summary>
    public BlockSizeBuilder LargeViewport => ChainClass("block-lvh");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BlockSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "block-"));
}
