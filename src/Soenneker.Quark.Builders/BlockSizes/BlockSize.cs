namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical blocksize.
/// </summary>
[TailwindModifiers(typeof(BlockSizeBuilder))]
public static partial class BlockSize
{
    /// <summary>Adds <c>block-0</c>.</summary>
    public static BlockSizeBuilder Is0 => new("block-0");

    /// <summary>Adds <c>block-0.5</c>.</summary>
    public static BlockSizeBuilder Is0_5 => new("block-0.5");

    /// <summary>Adds <c>block-1</c>.</summary>
    public static BlockSizeBuilder Is1 => new("block-1");

    /// <summary>Adds <c>block-1.5</c>.</summary>
    public static BlockSizeBuilder Is1_5 => new("block-1.5");

    /// <summary>Adds <c>block-2</c>.</summary>
    public static BlockSizeBuilder Is2 => new("block-2");

    /// <summary>Adds <c>block-2.5</c>.</summary>
    public static BlockSizeBuilder Is2_5 => new("block-2.5");

    /// <summary>Adds <c>block-3</c>.</summary>
    public static BlockSizeBuilder Is3 => new("block-3");

    /// <summary>Adds <c>block-3.5</c>.</summary>
    public static BlockSizeBuilder Is3_5 => new("block-3.5");

    /// <summary>Adds <c>block-4</c>.</summary>
    public static BlockSizeBuilder Is4 => new("block-4");

    /// <summary>Adds <c>block-5</c>.</summary>
    public static BlockSizeBuilder Is5 => new("block-5");

    /// <summary>Adds <c>block-6</c>.</summary>
    public static BlockSizeBuilder Is6 => new("block-6");

    /// <summary>Adds <c>block-8</c>.</summary>
    public static BlockSizeBuilder Is8 => new("block-8");

    /// <summary>Adds <c>block-10</c>.</summary>
    public static BlockSizeBuilder Is10 => new("block-10");

    /// <summary>Adds <c>block-12</c>.</summary>
    public static BlockSizeBuilder Is12 => new("block-12");

    /// <summary>Adds <c>block-16</c>.</summary>
    public static BlockSizeBuilder Is16 => new("block-16");

    /// <summary>Adds <c>block-20</c>.</summary>
    public static BlockSizeBuilder Is20 => new("block-20");

    /// <summary>Adds <c>block-24</c>.</summary>
    public static BlockSizeBuilder Is24 => new("block-24");

    /// <summary>Adds <c>block-32</c>.</summary>
    public static BlockSizeBuilder Is32 => new("block-32");

    /// <summary>Adds <c>block-40</c>.</summary>
    public static BlockSizeBuilder Is40 => new("block-40");

    /// <summary>Adds <c>block-48</c>.</summary>
    public static BlockSizeBuilder Is48 => new("block-48");

    /// <summary>Adds <c>block-64</c>.</summary>
    public static BlockSizeBuilder Is64 => new("block-64");

    /// <summary>Adds <c>block-96</c>.</summary>
    public static BlockSizeBuilder Is96 => new("block-96");

    /// <summary>Adds <c>block-auto</c>.</summary>
    public static BlockSizeBuilder Auto => new("block-auto");

    /// <summary>Adds <c>block-px</c>.</summary>
    public static BlockSizeBuilder IsPx => new("block-px");

    /// <summary>Adds <c>block-full</c>.</summary>
    public static BlockSizeBuilder IsFull => new("block-full");

    /// <summary>Adds <c>block-screen</c>.</summary>
    public static BlockSizeBuilder IsScreen => new("block-screen");

    /// <summary>Adds <c>block-min</c>.</summary>
    public static BlockSizeBuilder IsMin => new("block-min");

    /// <summary>Adds <c>block-max</c>.</summary>
    public static BlockSizeBuilder IsMax => new("block-max");

    /// <summary>Adds <c>block-fit</c>.</summary>
    public static BlockSizeBuilder IsFit => new("block-fit");

    /// <summary>Adds <c>block-1/2</c>.</summary>
    public static BlockSizeBuilder Is1of2 => new("block-1/2");

    /// <summary>Adds <c>block-1/3</c>.</summary>
    public static BlockSizeBuilder Is1of3 => new("block-1/3");

    /// <summary>Adds <c>block-2/3</c>.</summary>
    public static BlockSizeBuilder Is2of3 => new("block-2/3");

    /// <summary>Adds <c>block-1/4</c>.</summary>
    public static BlockSizeBuilder Is1of4 => new("block-1/4");

    /// <summary>Adds <c>block-3/4</c>.</summary>
    public static BlockSizeBuilder Is3of4 => new("block-3/4");

    /// <summary>Adds <c>block-dvh</c>.</summary>
    public static BlockSizeBuilder DynamicViewport => new("block-dvh");

    /// <summary>Adds <c>block-svh</c>.</summary>
    public static BlockSizeBuilder SmallViewport => new("block-svh");

    /// <summary>Adds <c>block-lvh</c>.</summary>
    public static BlockSizeBuilder LargeViewport => new("block-lvh");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BlockSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "block-"));
}
