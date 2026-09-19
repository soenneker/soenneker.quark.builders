namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical positioning.
/// </summary>
[TailwindModifiers(typeof(InsetEndBuilder))]
public static partial class InsetEnd
{
    /// <summary>Adds <c>inset-e-0</c>.</summary>
    public static InsetEndBuilder Is0 => new("inset-e-0");

    /// <summary>Adds <c>inset-e-0.5</c>.</summary>
    public static InsetEndBuilder Is0_5 => new("inset-e-0.5");

    /// <summary>Adds <c>inset-e-1</c>.</summary>
    public static InsetEndBuilder Is1 => new("inset-e-1");

    /// <summary>Adds <c>inset-e-1.5</c>.</summary>
    public static InsetEndBuilder Is1_5 => new("inset-e-1.5");

    /// <summary>Adds <c>inset-e-2</c>.</summary>
    public static InsetEndBuilder Is2 => new("inset-e-2");

    /// <summary>Adds <c>inset-e-2.5</c>.</summary>
    public static InsetEndBuilder Is2_5 => new("inset-e-2.5");

    /// <summary>Adds <c>inset-e-3</c>.</summary>
    public static InsetEndBuilder Is3 => new("inset-e-3");

    /// <summary>Adds <c>inset-e-3.5</c>.</summary>
    public static InsetEndBuilder Is3_5 => new("inset-e-3.5");

    /// <summary>Adds <c>inset-e-4</c>.</summary>
    public static InsetEndBuilder Is4 => new("inset-e-4");

    /// <summary>Adds <c>inset-e-5</c>.</summary>
    public static InsetEndBuilder Is5 => new("inset-e-5");

    /// <summary>Adds <c>inset-e-6</c>.</summary>
    public static InsetEndBuilder Is6 => new("inset-e-6");

    /// <summary>Adds <c>inset-e-8</c>.</summary>
    public static InsetEndBuilder Is8 => new("inset-e-8");

    /// <summary>Adds <c>inset-e-10</c>.</summary>
    public static InsetEndBuilder Is10 => new("inset-e-10");

    /// <summary>Adds <c>inset-e-12</c>.</summary>
    public static InsetEndBuilder Is12 => new("inset-e-12");

    /// <summary>Adds <c>inset-e-16</c>.</summary>
    public static InsetEndBuilder Is16 => new("inset-e-16");

    /// <summary>Adds <c>inset-e-20</c>.</summary>
    public static InsetEndBuilder Is20 => new("inset-e-20");

    /// <summary>Adds <c>inset-e-24</c>.</summary>
    public static InsetEndBuilder Is24 => new("inset-e-24");

    /// <summary>Adds <c>inset-e-32</c>.</summary>
    public static InsetEndBuilder Is32 => new("inset-e-32");

    /// <summary>Adds <c>inset-e-40</c>.</summary>
    public static InsetEndBuilder Is40 => new("inset-e-40");

    /// <summary>Adds <c>inset-e-48</c>.</summary>
    public static InsetEndBuilder Is48 => new("inset-e-48");

    /// <summary>Adds <c>inset-e-64</c>.</summary>
    public static InsetEndBuilder Is64 => new("inset-e-64");

    /// <summary>Adds <c>inset-e-96</c>.</summary>
    public static InsetEndBuilder Is96 => new("inset-e-96");

    /// <summary>Adds <c>inset-e-auto</c>.</summary>
    public static InsetEndBuilder Auto => new("inset-e-auto");

    /// <summary>Adds <c>inset-e-px</c>.</summary>
    public static InsetEndBuilder Px => new("inset-e-px");

    /// <summary>Adds <c>inset-e-1/2</c>.</summary>
    public static InsetEndBuilder Half => new("inset-e-1/2");

    /// <summary>Adds <c>inset-e-full</c>.</summary>
    public static InsetEndBuilder Full => new("inset-e-full");

    /// <summary>Adds <c>-inset-e-1/2</c>.</summary>
    public static InsetEndBuilder NegativeHalf => new("-inset-e-1/2");

    /// <summary>Adds <c>-inset-e-full</c>.</summary>
    public static InsetEndBuilder NegativeFull => new("-inset-e-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetEndBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "inset-e-"));
}
