namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for logical maxblocksize, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("max-block-", Responsive = true)]
public sealed class MaxBlockSizeBuilder : FinalClassUtilityBuilder<MaxBlockSizeBuilder>
{
    internal MaxBlockSizeBuilder()
    {
    }

    internal MaxBlockSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>max-block-0</c>.</summary>
    public MaxBlockSizeBuilder Is0 => ChainClass("max-block-0");

    /// <summary>Adds <c>max-block-0.5</c>.</summary>
    public MaxBlockSizeBuilder Is0_5 => ChainClass("max-block-0.5");

    /// <summary>Adds <c>max-block-1</c>.</summary>
    public MaxBlockSizeBuilder Is1 => ChainClass("max-block-1");

    /// <summary>Adds <c>max-block-1.5</c>.</summary>
    public MaxBlockSizeBuilder Is1_5 => ChainClass("max-block-1.5");

    /// <summary>Adds <c>max-block-2</c>.</summary>
    public MaxBlockSizeBuilder Is2 => ChainClass("max-block-2");

    /// <summary>Adds <c>max-block-2.5</c>.</summary>
    public MaxBlockSizeBuilder Is2_5 => ChainClass("max-block-2.5");

    /// <summary>Adds <c>max-block-3</c>.</summary>
    public MaxBlockSizeBuilder Is3 => ChainClass("max-block-3");

    /// <summary>Adds <c>max-block-3.5</c>.</summary>
    public MaxBlockSizeBuilder Is3_5 => ChainClass("max-block-3.5");

    /// <summary>Adds <c>max-block-4</c>.</summary>
    public MaxBlockSizeBuilder Is4 => ChainClass("max-block-4");

    /// <summary>Adds <c>max-block-5</c>.</summary>
    public MaxBlockSizeBuilder Is5 => ChainClass("max-block-5");

    /// <summary>Adds <c>max-block-6</c>.</summary>
    public MaxBlockSizeBuilder Is6 => ChainClass("max-block-6");

    /// <summary>Adds <c>max-block-8</c>.</summary>
    public MaxBlockSizeBuilder Is8 => ChainClass("max-block-8");

    /// <summary>Adds <c>max-block-10</c>.</summary>
    public MaxBlockSizeBuilder Is10 => ChainClass("max-block-10");

    /// <summary>Adds <c>max-block-12</c>.</summary>
    public MaxBlockSizeBuilder Is12 => ChainClass("max-block-12");

    /// <summary>Adds <c>max-block-16</c>.</summary>
    public MaxBlockSizeBuilder Is16 => ChainClass("max-block-16");

    /// <summary>Adds <c>max-block-20</c>.</summary>
    public MaxBlockSizeBuilder Is20 => ChainClass("max-block-20");

    /// <summary>Adds <c>max-block-24</c>.</summary>
    public MaxBlockSizeBuilder Is24 => ChainClass("max-block-24");

    /// <summary>Adds <c>max-block-32</c>.</summary>
    public MaxBlockSizeBuilder Is32 => ChainClass("max-block-32");

    /// <summary>Adds <c>max-block-40</c>.</summary>
    public MaxBlockSizeBuilder Is40 => ChainClass("max-block-40");

    /// <summary>Adds <c>max-block-48</c>.</summary>
    public MaxBlockSizeBuilder Is48 => ChainClass("max-block-48");

    /// <summary>Adds <c>max-block-64</c>.</summary>
    public MaxBlockSizeBuilder Is64 => ChainClass("max-block-64");

    /// <summary>Adds <c>max-block-96</c>.</summary>
    public MaxBlockSizeBuilder Is96 => ChainClass("max-block-96");

    /// <summary>Adds <c>max-block-px</c>.</summary>
    public MaxBlockSizeBuilder IsPx => ChainClass("max-block-px");

    /// <summary>Adds <c>max-block-full</c>.</summary>
    public MaxBlockSizeBuilder IsFull => ChainClass("max-block-full");

    /// <summary>Adds <c>max-block-screen</c>.</summary>
    public MaxBlockSizeBuilder IsScreen => ChainClass("max-block-screen");

    /// <summary>Adds <c>max-block-min</c>.</summary>
    public MaxBlockSizeBuilder IsMin => ChainClass("max-block-min");

    /// <summary>Adds <c>max-block-max</c>.</summary>
    public MaxBlockSizeBuilder IsMax => ChainClass("max-block-max");

    /// <summary>Adds <c>max-block-fit</c>.</summary>
    public MaxBlockSizeBuilder IsFit => ChainClass("max-block-fit");

    /// <summary>Adds <c>max-block-1/2</c>.</summary>
    public MaxBlockSizeBuilder Is1of2 => ChainClass("max-block-1/2");

    /// <summary>Adds <c>max-block-1/3</c>.</summary>
    public MaxBlockSizeBuilder Is1of3 => ChainClass("max-block-1/3");

    /// <summary>Adds <c>max-block-2/3</c>.</summary>
    public MaxBlockSizeBuilder Is2of3 => ChainClass("max-block-2/3");

    /// <summary>Adds <c>max-block-1/4</c>.</summary>
    public MaxBlockSizeBuilder Is1of4 => ChainClass("max-block-1/4");

    /// <summary>Adds <c>max-block-3/4</c>.</summary>
    public MaxBlockSizeBuilder Is3of4 => ChainClass("max-block-3/4");

    /// <summary>Adds <c>max-block-dvh</c>.</summary>
    public MaxBlockSizeBuilder DynamicViewport => ChainClass("max-block-dvh");

    /// <summary>Adds <c>max-block-svh</c>.</summary>
    public MaxBlockSizeBuilder SmallViewport => ChainClass("max-block-svh");

    /// <summary>Adds <c>max-block-lvh</c>.</summary>
    public MaxBlockSizeBuilder LargeViewport => ChainClass("max-block-lvh");

    /// <summary>Adds <c>max-block-none</c>.</summary>
    public MaxBlockSizeBuilder None => ChainClass("max-block-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaxBlockSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "max-block-"));
}
