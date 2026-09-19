namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical inlinesize.
/// </summary>
[TailwindModifiers(typeof(InlineSizeBuilder))]
public static partial class InlineSize
{
    /// <summary>Adds <c>inline-0</c>.</summary>
    public static InlineSizeBuilder Is0 => new("inline-0");

    /// <summary>Adds <c>inline-0.5</c>.</summary>
    public static InlineSizeBuilder Is0_5 => new("inline-0.5");

    /// <summary>Adds <c>inline-1</c>.</summary>
    public static InlineSizeBuilder Is1 => new("inline-1");

    /// <summary>Adds <c>inline-1.5</c>.</summary>
    public static InlineSizeBuilder Is1_5 => new("inline-1.5");

    /// <summary>Adds <c>inline-2</c>.</summary>
    public static InlineSizeBuilder Is2 => new("inline-2");

    /// <summary>Adds <c>inline-2.5</c>.</summary>
    public static InlineSizeBuilder Is2_5 => new("inline-2.5");

    /// <summary>Adds <c>inline-3</c>.</summary>
    public static InlineSizeBuilder Is3 => new("inline-3");

    /// <summary>Adds <c>inline-3.5</c>.</summary>
    public static InlineSizeBuilder Is3_5 => new("inline-3.5");

    /// <summary>Adds <c>inline-4</c>.</summary>
    public static InlineSizeBuilder Is4 => new("inline-4");

    /// <summary>Adds <c>inline-5</c>.</summary>
    public static InlineSizeBuilder Is5 => new("inline-5");

    /// <summary>Adds <c>inline-6</c>.</summary>
    public static InlineSizeBuilder Is6 => new("inline-6");

    /// <summary>Adds <c>inline-8</c>.</summary>
    public static InlineSizeBuilder Is8 => new("inline-8");

    /// <summary>Adds <c>inline-10</c>.</summary>
    public static InlineSizeBuilder Is10 => new("inline-10");

    /// <summary>Adds <c>inline-12</c>.</summary>
    public static InlineSizeBuilder Is12 => new("inline-12");

    /// <summary>Adds <c>inline-16</c>.</summary>
    public static InlineSizeBuilder Is16 => new("inline-16");

    /// <summary>Adds <c>inline-20</c>.</summary>
    public static InlineSizeBuilder Is20 => new("inline-20");

    /// <summary>Adds <c>inline-24</c>.</summary>
    public static InlineSizeBuilder Is24 => new("inline-24");

    /// <summary>Adds <c>inline-32</c>.</summary>
    public static InlineSizeBuilder Is32 => new("inline-32");

    /// <summary>Adds <c>inline-40</c>.</summary>
    public static InlineSizeBuilder Is40 => new("inline-40");

    /// <summary>Adds <c>inline-48</c>.</summary>
    public static InlineSizeBuilder Is48 => new("inline-48");

    /// <summary>Adds <c>inline-64</c>.</summary>
    public static InlineSizeBuilder Is64 => new("inline-64");

    /// <summary>Adds <c>inline-96</c>.</summary>
    public static InlineSizeBuilder Is96 => new("inline-96");

    /// <summary>Adds <c>inline-auto</c>.</summary>
    public static InlineSizeBuilder Auto => new("inline-auto");

    /// <summary>Adds <c>inline-px</c>.</summary>
    public static InlineSizeBuilder IsPx => new("inline-px");

    /// <summary>Adds <c>inline-full</c>.</summary>
    public static InlineSizeBuilder IsFull => new("inline-full");

    /// <summary>Adds <c>inline-screen</c>.</summary>
    public static InlineSizeBuilder IsScreen => new("inline-screen");

    /// <summary>Adds <c>inline-min</c>.</summary>
    public static InlineSizeBuilder IsMin => new("inline-min");

    /// <summary>Adds <c>inline-max</c>.</summary>
    public static InlineSizeBuilder IsMax => new("inline-max");

    /// <summary>Adds <c>inline-fit</c>.</summary>
    public static InlineSizeBuilder IsFit => new("inline-fit");

    /// <summary>Adds <c>inline-1/2</c>.</summary>
    public static InlineSizeBuilder Is1of2 => new("inline-1/2");

    /// <summary>Adds <c>inline-1/3</c>.</summary>
    public static InlineSizeBuilder Is1of3 => new("inline-1/3");

    /// <summary>Adds <c>inline-2/3</c>.</summary>
    public static InlineSizeBuilder Is2of3 => new("inline-2/3");

    /// <summary>Adds <c>inline-1/4</c>.</summary>
    public static InlineSizeBuilder Is1of4 => new("inline-1/4");

    /// <summary>Adds <c>inline-3/4</c>.</summary>
    public static InlineSizeBuilder Is3of4 => new("inline-3/4");

    /// <summary>Adds <c>inline-dvw</c>.</summary>
    public static InlineSizeBuilder DynamicViewport => new("inline-dvw");

    /// <summary>Adds <c>inline-svw</c>.</summary>
    public static InlineSizeBuilder SmallViewport => new("inline-svw");

    /// <summary>Adds <c>inline-lvw</c>.</summary>
    public static InlineSizeBuilder LargeViewport => new("inline-lvw");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InlineSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "inline-"));
}
