namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical mininlinesize.
/// </summary>
[TailwindModifiers(typeof(MinInlineSizeBuilder))]
public static partial class MinInlineSize
{
    /// <summary>Adds <c>min-inline-0</c>.</summary>
    public static MinInlineSizeBuilder Is0 => new("min-inline-0");

    /// <summary>Adds <c>min-inline-0.5</c>.</summary>
    public static MinInlineSizeBuilder Is0_5 => new("min-inline-0.5");

    /// <summary>Adds <c>min-inline-1</c>.</summary>
    public static MinInlineSizeBuilder Is1 => new("min-inline-1");

    /// <summary>Adds <c>min-inline-1.5</c>.</summary>
    public static MinInlineSizeBuilder Is1_5 => new("min-inline-1.5");

    /// <summary>Adds <c>min-inline-2</c>.</summary>
    public static MinInlineSizeBuilder Is2 => new("min-inline-2");

    /// <summary>Adds <c>min-inline-2.5</c>.</summary>
    public static MinInlineSizeBuilder Is2_5 => new("min-inline-2.5");

    /// <summary>Adds <c>min-inline-3</c>.</summary>
    public static MinInlineSizeBuilder Is3 => new("min-inline-3");

    /// <summary>Adds <c>min-inline-3.5</c>.</summary>
    public static MinInlineSizeBuilder Is3_5 => new("min-inline-3.5");

    /// <summary>Adds <c>min-inline-4</c>.</summary>
    public static MinInlineSizeBuilder Is4 => new("min-inline-4");

    /// <summary>Adds <c>min-inline-5</c>.</summary>
    public static MinInlineSizeBuilder Is5 => new("min-inline-5");

    /// <summary>Adds <c>min-inline-6</c>.</summary>
    public static MinInlineSizeBuilder Is6 => new("min-inline-6");

    /// <summary>Adds <c>min-inline-8</c>.</summary>
    public static MinInlineSizeBuilder Is8 => new("min-inline-8");

    /// <summary>Adds <c>min-inline-10</c>.</summary>
    public static MinInlineSizeBuilder Is10 => new("min-inline-10");

    /// <summary>Adds <c>min-inline-12</c>.</summary>
    public static MinInlineSizeBuilder Is12 => new("min-inline-12");

    /// <summary>Adds <c>min-inline-16</c>.</summary>
    public static MinInlineSizeBuilder Is16 => new("min-inline-16");

    /// <summary>Adds <c>min-inline-20</c>.</summary>
    public static MinInlineSizeBuilder Is20 => new("min-inline-20");

    /// <summary>Adds <c>min-inline-24</c>.</summary>
    public static MinInlineSizeBuilder Is24 => new("min-inline-24");

    /// <summary>Adds <c>min-inline-32</c>.</summary>
    public static MinInlineSizeBuilder Is32 => new("min-inline-32");

    /// <summary>Adds <c>min-inline-40</c>.</summary>
    public static MinInlineSizeBuilder Is40 => new("min-inline-40");

    /// <summary>Adds <c>min-inline-48</c>.</summary>
    public static MinInlineSizeBuilder Is48 => new("min-inline-48");

    /// <summary>Adds <c>min-inline-64</c>.</summary>
    public static MinInlineSizeBuilder Is64 => new("min-inline-64");

    /// <summary>Adds <c>min-inline-96</c>.</summary>
    public static MinInlineSizeBuilder Is96 => new("min-inline-96");

    /// <summary>Adds <c>min-inline-auto</c>.</summary>
    public static MinInlineSizeBuilder Auto => new("min-inline-auto");

    /// <summary>Adds <c>min-inline-px</c>.</summary>
    public static MinInlineSizeBuilder IsPx => new("min-inline-px");

    /// <summary>Adds <c>min-inline-full</c>.</summary>
    public static MinInlineSizeBuilder IsFull => new("min-inline-full");

    /// <summary>Adds <c>min-inline-screen</c>.</summary>
    public static MinInlineSizeBuilder IsScreen => new("min-inline-screen");

    /// <summary>Adds <c>min-inline-min</c>.</summary>
    public static MinInlineSizeBuilder IsMin => new("min-inline-min");

    /// <summary>Adds <c>min-inline-max</c>.</summary>
    public static MinInlineSizeBuilder IsMax => new("min-inline-max");

    /// <summary>Adds <c>min-inline-fit</c>.</summary>
    public static MinInlineSizeBuilder IsFit => new("min-inline-fit");

    /// <summary>Adds <c>min-inline-1/2</c>.</summary>
    public static MinInlineSizeBuilder Is1of2 => new("min-inline-1/2");

    /// <summary>Adds <c>min-inline-1/3</c>.</summary>
    public static MinInlineSizeBuilder Is1of3 => new("min-inline-1/3");

    /// <summary>Adds <c>min-inline-2/3</c>.</summary>
    public static MinInlineSizeBuilder Is2of3 => new("min-inline-2/3");

    /// <summary>Adds <c>min-inline-1/4</c>.</summary>
    public static MinInlineSizeBuilder Is1of4 => new("min-inline-1/4");

    /// <summary>Adds <c>min-inline-3/4</c>.</summary>
    public static MinInlineSizeBuilder Is3of4 => new("min-inline-3/4");

    /// <summary>Adds <c>min-inline-dvw</c>.</summary>
    public static MinInlineSizeBuilder DynamicViewport => new("min-inline-dvw");

    /// <summary>Adds <c>min-inline-svw</c>.</summary>
    public static MinInlineSizeBuilder SmallViewport => new("min-inline-svw");

    /// <summary>Adds <c>min-inline-lvw</c>.</summary>
    public static MinInlineSizeBuilder LargeViewport => new("min-inline-lvw");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MinInlineSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "min-inline-"));
}
