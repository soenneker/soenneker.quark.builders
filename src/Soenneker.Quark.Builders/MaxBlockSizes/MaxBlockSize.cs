namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical maxblocksize.
/// </summary>
[TailwindModifiers(typeof(MaxBlockSizeBuilder))]
public static partial class MaxBlockSize
{
    /// <summary>Adds <c>max-block-0</c>.</summary>
    public static MaxBlockSizeBuilder Is0 => new("max-block-0");

    /// <summary>Adds <c>max-block-0.5</c>.</summary>
    public static MaxBlockSizeBuilder Is0_5 => new("max-block-0.5");

    /// <summary>Adds <c>max-block-1</c>.</summary>
    public static MaxBlockSizeBuilder Is1 => new("max-block-1");

    /// <summary>Adds <c>max-block-1.5</c>.</summary>
    public static MaxBlockSizeBuilder Is1_5 => new("max-block-1.5");

    /// <summary>Adds <c>max-block-2</c>.</summary>
    public static MaxBlockSizeBuilder Is2 => new("max-block-2");

    /// <summary>Adds <c>max-block-2.5</c>.</summary>
    public static MaxBlockSizeBuilder Is2_5 => new("max-block-2.5");

    /// <summary>Adds <c>max-block-3</c>.</summary>
    public static MaxBlockSizeBuilder Is3 => new("max-block-3");

    /// <summary>Adds <c>max-block-3.5</c>.</summary>
    public static MaxBlockSizeBuilder Is3_5 => new("max-block-3.5");

    /// <summary>Adds <c>max-block-4</c>.</summary>
    public static MaxBlockSizeBuilder Is4 => new("max-block-4");

    /// <summary>Adds <c>max-block-5</c>.</summary>
    public static MaxBlockSizeBuilder Is5 => new("max-block-5");

    /// <summary>Adds <c>max-block-6</c>.</summary>
    public static MaxBlockSizeBuilder Is6 => new("max-block-6");

    /// <summary>Adds <c>max-block-8</c>.</summary>
    public static MaxBlockSizeBuilder Is8 => new("max-block-8");

    /// <summary>Adds <c>max-block-10</c>.</summary>
    public static MaxBlockSizeBuilder Is10 => new("max-block-10");

    /// <summary>Adds <c>max-block-12</c>.</summary>
    public static MaxBlockSizeBuilder Is12 => new("max-block-12");

    /// <summary>Adds <c>max-block-16</c>.</summary>
    public static MaxBlockSizeBuilder Is16 => new("max-block-16");

    /// <summary>Adds <c>max-block-20</c>.</summary>
    public static MaxBlockSizeBuilder Is20 => new("max-block-20");

    /// <summary>Adds <c>max-block-24</c>.</summary>
    public static MaxBlockSizeBuilder Is24 => new("max-block-24");

    /// <summary>Adds <c>max-block-32</c>.</summary>
    public static MaxBlockSizeBuilder Is32 => new("max-block-32");

    /// <summary>Adds <c>max-block-40</c>.</summary>
    public static MaxBlockSizeBuilder Is40 => new("max-block-40");

    /// <summary>Adds <c>max-block-48</c>.</summary>
    public static MaxBlockSizeBuilder Is48 => new("max-block-48");

    /// <summary>Adds <c>max-block-64</c>.</summary>
    public static MaxBlockSizeBuilder Is64 => new("max-block-64");

    /// <summary>Adds <c>max-block-96</c>.</summary>
    public static MaxBlockSizeBuilder Is96 => new("max-block-96");

    /// <summary>Adds <c>max-block-px</c>.</summary>
    public static MaxBlockSizeBuilder IsPx => new("max-block-px");

    /// <summary>Adds <c>max-block-full</c>.</summary>
    public static MaxBlockSizeBuilder IsFull => new("max-block-full");

    /// <summary>Adds <c>max-block-screen</c>.</summary>
    public static MaxBlockSizeBuilder IsScreen => new("max-block-screen");

    /// <summary>Adds <c>max-block-min</c>.</summary>
    public static MaxBlockSizeBuilder IsMin => new("max-block-min");

    /// <summary>Adds <c>max-block-max</c>.</summary>
    public static MaxBlockSizeBuilder IsMax => new("max-block-max");

    /// <summary>Adds <c>max-block-fit</c>.</summary>
    public static MaxBlockSizeBuilder IsFit => new("max-block-fit");

    /// <summary>Adds <c>max-block-1/2</c>.</summary>
    public static MaxBlockSizeBuilder Is1of2 => new("max-block-1/2");

    /// <summary>Adds <c>max-block-1/3</c>.</summary>
    public static MaxBlockSizeBuilder Is1of3 => new("max-block-1/3");

    /// <summary>Adds <c>max-block-2/3</c>.</summary>
    public static MaxBlockSizeBuilder Is2of3 => new("max-block-2/3");

    /// <summary>Adds <c>max-block-1/4</c>.</summary>
    public static MaxBlockSizeBuilder Is1of4 => new("max-block-1/4");

    /// <summary>Adds <c>max-block-3/4</c>.</summary>
    public static MaxBlockSizeBuilder Is3of4 => new("max-block-3/4");

    /// <summary>Adds <c>max-block-dvh</c>.</summary>
    public static MaxBlockSizeBuilder DynamicViewport => new("max-block-dvh");

    /// <summary>Adds <c>max-block-svh</c>.</summary>
    public static MaxBlockSizeBuilder SmallViewport => new("max-block-svh");

    /// <summary>Adds <c>max-block-lvh</c>.</summary>
    public static MaxBlockSizeBuilder LargeViewport => new("max-block-lvh");

    /// <summary>Adds <c>max-block-none</c>.</summary>
    public static MaxBlockSizeBuilder None => new("max-block-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaxBlockSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "max-block-"));
}
