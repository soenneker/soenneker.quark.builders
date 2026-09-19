namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical maxinlinesize.
/// </summary>
[TailwindModifiers(typeof(MaxInlineSizeBuilder))]
public static partial class MaxInlineSize
{
    /// <summary>Adds <c>max-inline-0</c>.</summary>
    public static MaxInlineSizeBuilder Is0 => new("max-inline-0");

    /// <summary>Adds <c>max-inline-0.5</c>.</summary>
    public static MaxInlineSizeBuilder Is0_5 => new("max-inline-0.5");

    /// <summary>Adds <c>max-inline-1</c>.</summary>
    public static MaxInlineSizeBuilder Is1 => new("max-inline-1");

    /// <summary>Adds <c>max-inline-1.5</c>.</summary>
    public static MaxInlineSizeBuilder Is1_5 => new("max-inline-1.5");

    /// <summary>Adds <c>max-inline-2</c>.</summary>
    public static MaxInlineSizeBuilder Is2 => new("max-inline-2");

    /// <summary>Adds <c>max-inline-2.5</c>.</summary>
    public static MaxInlineSizeBuilder Is2_5 => new("max-inline-2.5");

    /// <summary>Adds <c>max-inline-3</c>.</summary>
    public static MaxInlineSizeBuilder Is3 => new("max-inline-3");

    /// <summary>Adds <c>max-inline-3.5</c>.</summary>
    public static MaxInlineSizeBuilder Is3_5 => new("max-inline-3.5");

    /// <summary>Adds <c>max-inline-4</c>.</summary>
    public static MaxInlineSizeBuilder Is4 => new("max-inline-4");

    /// <summary>Adds <c>max-inline-5</c>.</summary>
    public static MaxInlineSizeBuilder Is5 => new("max-inline-5");

    /// <summary>Adds <c>max-inline-6</c>.</summary>
    public static MaxInlineSizeBuilder Is6 => new("max-inline-6");

    /// <summary>Adds <c>max-inline-8</c>.</summary>
    public static MaxInlineSizeBuilder Is8 => new("max-inline-8");

    /// <summary>Adds <c>max-inline-10</c>.</summary>
    public static MaxInlineSizeBuilder Is10 => new("max-inline-10");

    /// <summary>Adds <c>max-inline-12</c>.</summary>
    public static MaxInlineSizeBuilder Is12 => new("max-inline-12");

    /// <summary>Adds <c>max-inline-16</c>.</summary>
    public static MaxInlineSizeBuilder Is16 => new("max-inline-16");

    /// <summary>Adds <c>max-inline-20</c>.</summary>
    public static MaxInlineSizeBuilder Is20 => new("max-inline-20");

    /// <summary>Adds <c>max-inline-24</c>.</summary>
    public static MaxInlineSizeBuilder Is24 => new("max-inline-24");

    /// <summary>Adds <c>max-inline-32</c>.</summary>
    public static MaxInlineSizeBuilder Is32 => new("max-inline-32");

    /// <summary>Adds <c>max-inline-40</c>.</summary>
    public static MaxInlineSizeBuilder Is40 => new("max-inline-40");

    /// <summary>Adds <c>max-inline-48</c>.</summary>
    public static MaxInlineSizeBuilder Is48 => new("max-inline-48");

    /// <summary>Adds <c>max-inline-64</c>.</summary>
    public static MaxInlineSizeBuilder Is64 => new("max-inline-64");

    /// <summary>Adds <c>max-inline-96</c>.</summary>
    public static MaxInlineSizeBuilder Is96 => new("max-inline-96");

    /// <summary>Adds <c>max-inline-px</c>.</summary>
    public static MaxInlineSizeBuilder IsPx => new("max-inline-px");

    /// <summary>Adds <c>max-inline-full</c>.</summary>
    public static MaxInlineSizeBuilder IsFull => new("max-inline-full");

    /// <summary>Adds <c>max-inline-screen</c>.</summary>
    public static MaxInlineSizeBuilder IsScreen => new("max-inline-screen");

    /// <summary>Adds <c>max-inline-min</c>.</summary>
    public static MaxInlineSizeBuilder IsMin => new("max-inline-min");

    /// <summary>Adds <c>max-inline-max</c>.</summary>
    public static MaxInlineSizeBuilder IsMax => new("max-inline-max");

    /// <summary>Adds <c>max-inline-fit</c>.</summary>
    public static MaxInlineSizeBuilder IsFit => new("max-inline-fit");

    /// <summary>Adds <c>max-inline-1/2</c>.</summary>
    public static MaxInlineSizeBuilder Is1of2 => new("max-inline-1/2");

    /// <summary>Adds <c>max-inline-1/3</c>.</summary>
    public static MaxInlineSizeBuilder Is1of3 => new("max-inline-1/3");

    /// <summary>Adds <c>max-inline-2/3</c>.</summary>
    public static MaxInlineSizeBuilder Is2of3 => new("max-inline-2/3");

    /// <summary>Adds <c>max-inline-1/4</c>.</summary>
    public static MaxInlineSizeBuilder Is1of4 => new("max-inline-1/4");

    /// <summary>Adds <c>max-inline-3/4</c>.</summary>
    public static MaxInlineSizeBuilder Is3of4 => new("max-inline-3/4");

    /// <summary>Adds <c>max-inline-dvw</c>.</summary>
    public static MaxInlineSizeBuilder DynamicViewport => new("max-inline-dvw");

    /// <summary>Adds <c>max-inline-svw</c>.</summary>
    public static MaxInlineSizeBuilder SmallViewport => new("max-inline-svw");

    /// <summary>Adds <c>max-inline-lvw</c>.</summary>
    public static MaxInlineSizeBuilder LargeViewport => new("max-inline-lvw");

    /// <summary>Adds <c>max-inline-none</c>.</summary>
    public static MaxInlineSizeBuilder None => new("max-inline-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaxInlineSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "max-inline-"));
}
