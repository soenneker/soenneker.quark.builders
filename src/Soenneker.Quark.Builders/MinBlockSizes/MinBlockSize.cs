namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical minblocksize.
/// </summary>
[TailwindModifiers(typeof(MinBlockSizeBuilder))]
public static partial class MinBlockSize
{
    /// <summary>Adds <c>min-block-0</c>.</summary>
    public static MinBlockSizeBuilder Is0 => new("min-block-0");

    /// <summary>Adds <c>min-block-0.5</c>.</summary>
    public static MinBlockSizeBuilder Is0_5 => new("min-block-0.5");

    /// <summary>Adds <c>min-block-1</c>.</summary>
    public static MinBlockSizeBuilder Is1 => new("min-block-1");

    /// <summary>Adds <c>min-block-1.5</c>.</summary>
    public static MinBlockSizeBuilder Is1_5 => new("min-block-1.5");

    /// <summary>Adds <c>min-block-2</c>.</summary>
    public static MinBlockSizeBuilder Is2 => new("min-block-2");

    /// <summary>Adds <c>min-block-2.5</c>.</summary>
    public static MinBlockSizeBuilder Is2_5 => new("min-block-2.5");

    /// <summary>Adds <c>min-block-3</c>.</summary>
    public static MinBlockSizeBuilder Is3 => new("min-block-3");

    /// <summary>Adds <c>min-block-3.5</c>.</summary>
    public static MinBlockSizeBuilder Is3_5 => new("min-block-3.5");

    /// <summary>Adds <c>min-block-4</c>.</summary>
    public static MinBlockSizeBuilder Is4 => new("min-block-4");

    /// <summary>Adds <c>min-block-5</c>.</summary>
    public static MinBlockSizeBuilder Is5 => new("min-block-5");

    /// <summary>Adds <c>min-block-6</c>.</summary>
    public static MinBlockSizeBuilder Is6 => new("min-block-6");

    /// <summary>Adds <c>min-block-8</c>.</summary>
    public static MinBlockSizeBuilder Is8 => new("min-block-8");

    /// <summary>Adds <c>min-block-10</c>.</summary>
    public static MinBlockSizeBuilder Is10 => new("min-block-10");

    /// <summary>Adds <c>min-block-12</c>.</summary>
    public static MinBlockSizeBuilder Is12 => new("min-block-12");

    /// <summary>Adds <c>min-block-16</c>.</summary>
    public static MinBlockSizeBuilder Is16 => new("min-block-16");

    /// <summary>Adds <c>min-block-20</c>.</summary>
    public static MinBlockSizeBuilder Is20 => new("min-block-20");

    /// <summary>Adds <c>min-block-24</c>.</summary>
    public static MinBlockSizeBuilder Is24 => new("min-block-24");

    /// <summary>Adds <c>min-block-32</c>.</summary>
    public static MinBlockSizeBuilder Is32 => new("min-block-32");

    /// <summary>Adds <c>min-block-40</c>.</summary>
    public static MinBlockSizeBuilder Is40 => new("min-block-40");

    /// <summary>Adds <c>min-block-48</c>.</summary>
    public static MinBlockSizeBuilder Is48 => new("min-block-48");

    /// <summary>Adds <c>min-block-64</c>.</summary>
    public static MinBlockSizeBuilder Is64 => new("min-block-64");

    /// <summary>Adds <c>min-block-96</c>.</summary>
    public static MinBlockSizeBuilder Is96 => new("min-block-96");

    /// <summary>Adds <c>min-block-auto</c>.</summary>
    public static MinBlockSizeBuilder Auto => new("min-block-auto");

    /// <summary>Adds <c>min-block-px</c>.</summary>
    public static MinBlockSizeBuilder IsPx => new("min-block-px");

    /// <summary>Adds <c>min-block-full</c>.</summary>
    public static MinBlockSizeBuilder IsFull => new("min-block-full");

    /// <summary>Adds <c>min-block-screen</c>.</summary>
    public static MinBlockSizeBuilder IsScreen => new("min-block-screen");

    /// <summary>Adds <c>min-block-min</c>.</summary>
    public static MinBlockSizeBuilder IsMin => new("min-block-min");

    /// <summary>Adds <c>min-block-max</c>.</summary>
    public static MinBlockSizeBuilder IsMax => new("min-block-max");

    /// <summary>Adds <c>min-block-fit</c>.</summary>
    public static MinBlockSizeBuilder IsFit => new("min-block-fit");

    /// <summary>Adds <c>min-block-1/2</c>.</summary>
    public static MinBlockSizeBuilder Is1of2 => new("min-block-1/2");

    /// <summary>Adds <c>min-block-1/3</c>.</summary>
    public static MinBlockSizeBuilder Is1of3 => new("min-block-1/3");

    /// <summary>Adds <c>min-block-2/3</c>.</summary>
    public static MinBlockSizeBuilder Is2of3 => new("min-block-2/3");

    /// <summary>Adds <c>min-block-1/4</c>.</summary>
    public static MinBlockSizeBuilder Is1of4 => new("min-block-1/4");

    /// <summary>Adds <c>min-block-3/4</c>.</summary>
    public static MinBlockSizeBuilder Is3of4 => new("min-block-3/4");

    /// <summary>Adds <c>min-block-dvh</c>.</summary>
    public static MinBlockSizeBuilder DynamicViewport => new("min-block-dvh");

    /// <summary>Adds <c>min-block-svh</c>.</summary>
    public static MinBlockSizeBuilder SmallViewport => new("min-block-svh");

    /// <summary>Adds <c>min-block-lvh</c>.</summary>
    public static MinBlockSizeBuilder LargeViewport => new("min-block-lvh");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MinBlockSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "min-block-"));
}
