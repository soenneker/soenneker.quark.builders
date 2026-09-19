namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical positioning.
/// </summary>
[TailwindModifiers(typeof(InsetStartBuilder))]
public static partial class InsetStart
{
    /// <summary>Adds <c>inset-s-0</c>.</summary>
    public static InsetStartBuilder Is0 => new("inset-s-0");

    /// <summary>Adds <c>inset-s-0.5</c>.</summary>
    public static InsetStartBuilder Is0_5 => new("inset-s-0.5");

    /// <summary>Adds <c>inset-s-1</c>.</summary>
    public static InsetStartBuilder Is1 => new("inset-s-1");

    /// <summary>Adds <c>inset-s-1.5</c>.</summary>
    public static InsetStartBuilder Is1_5 => new("inset-s-1.5");

    /// <summary>Adds <c>inset-s-2</c>.</summary>
    public static InsetStartBuilder Is2 => new("inset-s-2");

    /// <summary>Adds <c>inset-s-2.5</c>.</summary>
    public static InsetStartBuilder Is2_5 => new("inset-s-2.5");

    /// <summary>Adds <c>inset-s-3</c>.</summary>
    public static InsetStartBuilder Is3 => new("inset-s-3");

    /// <summary>Adds <c>inset-s-3.5</c>.</summary>
    public static InsetStartBuilder Is3_5 => new("inset-s-3.5");

    /// <summary>Adds <c>inset-s-4</c>.</summary>
    public static InsetStartBuilder Is4 => new("inset-s-4");

    /// <summary>Adds <c>inset-s-5</c>.</summary>
    public static InsetStartBuilder Is5 => new("inset-s-5");

    /// <summary>Adds <c>inset-s-6</c>.</summary>
    public static InsetStartBuilder Is6 => new("inset-s-6");

    /// <summary>Adds <c>inset-s-8</c>.</summary>
    public static InsetStartBuilder Is8 => new("inset-s-8");

    /// <summary>Adds <c>inset-s-10</c>.</summary>
    public static InsetStartBuilder Is10 => new("inset-s-10");

    /// <summary>Adds <c>inset-s-12</c>.</summary>
    public static InsetStartBuilder Is12 => new("inset-s-12");

    /// <summary>Adds <c>inset-s-16</c>.</summary>
    public static InsetStartBuilder Is16 => new("inset-s-16");

    /// <summary>Adds <c>inset-s-20</c>.</summary>
    public static InsetStartBuilder Is20 => new("inset-s-20");

    /// <summary>Adds <c>inset-s-24</c>.</summary>
    public static InsetStartBuilder Is24 => new("inset-s-24");

    /// <summary>Adds <c>inset-s-32</c>.</summary>
    public static InsetStartBuilder Is32 => new("inset-s-32");

    /// <summary>Adds <c>inset-s-40</c>.</summary>
    public static InsetStartBuilder Is40 => new("inset-s-40");

    /// <summary>Adds <c>inset-s-48</c>.</summary>
    public static InsetStartBuilder Is48 => new("inset-s-48");

    /// <summary>Adds <c>inset-s-64</c>.</summary>
    public static InsetStartBuilder Is64 => new("inset-s-64");

    /// <summary>Adds <c>inset-s-96</c>.</summary>
    public static InsetStartBuilder Is96 => new("inset-s-96");

    /// <summary>Adds <c>inset-s-auto</c>.</summary>
    public static InsetStartBuilder Auto => new("inset-s-auto");

    /// <summary>Adds <c>inset-s-px</c>.</summary>
    public static InsetStartBuilder Px => new("inset-s-px");

    /// <summary>Adds <c>inset-s-1/2</c>.</summary>
    public static InsetStartBuilder Half => new("inset-s-1/2");

    /// <summary>Adds <c>inset-s-full</c>.</summary>
    public static InsetStartBuilder Full => new("inset-s-full");

    /// <summary>Adds <c>-inset-s-1/2</c>.</summary>
    public static InsetStartBuilder NegativeHalf => new("-inset-s-1/2");

    /// <summary>Adds <c>-inset-s-full</c>.</summary>
    public static InsetStartBuilder NegativeFull => new("-inset-s-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetStartBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "inset-s-"));
}
