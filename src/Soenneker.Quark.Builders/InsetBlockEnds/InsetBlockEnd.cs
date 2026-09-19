namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical positioning.
/// </summary>
[TailwindModifiers(typeof(InsetBlockEndBuilder))]
public static partial class InsetBlockEnd
{
    /// <summary>Adds <c>inset-be-0</c>.</summary>
    public static InsetBlockEndBuilder Is0 => new("inset-be-0");

    /// <summary>Adds <c>inset-be-0.5</c>.</summary>
    public static InsetBlockEndBuilder Is0_5 => new("inset-be-0.5");

    /// <summary>Adds <c>inset-be-1</c>.</summary>
    public static InsetBlockEndBuilder Is1 => new("inset-be-1");

    /// <summary>Adds <c>inset-be-1.5</c>.</summary>
    public static InsetBlockEndBuilder Is1_5 => new("inset-be-1.5");

    /// <summary>Adds <c>inset-be-2</c>.</summary>
    public static InsetBlockEndBuilder Is2 => new("inset-be-2");

    /// <summary>Adds <c>inset-be-2.5</c>.</summary>
    public static InsetBlockEndBuilder Is2_5 => new("inset-be-2.5");

    /// <summary>Adds <c>inset-be-3</c>.</summary>
    public static InsetBlockEndBuilder Is3 => new("inset-be-3");

    /// <summary>Adds <c>inset-be-3.5</c>.</summary>
    public static InsetBlockEndBuilder Is3_5 => new("inset-be-3.5");

    /// <summary>Adds <c>inset-be-4</c>.</summary>
    public static InsetBlockEndBuilder Is4 => new("inset-be-4");

    /// <summary>Adds <c>inset-be-5</c>.</summary>
    public static InsetBlockEndBuilder Is5 => new("inset-be-5");

    /// <summary>Adds <c>inset-be-6</c>.</summary>
    public static InsetBlockEndBuilder Is6 => new("inset-be-6");

    /// <summary>Adds <c>inset-be-8</c>.</summary>
    public static InsetBlockEndBuilder Is8 => new("inset-be-8");

    /// <summary>Adds <c>inset-be-10</c>.</summary>
    public static InsetBlockEndBuilder Is10 => new("inset-be-10");

    /// <summary>Adds <c>inset-be-12</c>.</summary>
    public static InsetBlockEndBuilder Is12 => new("inset-be-12");

    /// <summary>Adds <c>inset-be-16</c>.</summary>
    public static InsetBlockEndBuilder Is16 => new("inset-be-16");

    /// <summary>Adds <c>inset-be-20</c>.</summary>
    public static InsetBlockEndBuilder Is20 => new("inset-be-20");

    /// <summary>Adds <c>inset-be-24</c>.</summary>
    public static InsetBlockEndBuilder Is24 => new("inset-be-24");

    /// <summary>Adds <c>inset-be-32</c>.</summary>
    public static InsetBlockEndBuilder Is32 => new("inset-be-32");

    /// <summary>Adds <c>inset-be-40</c>.</summary>
    public static InsetBlockEndBuilder Is40 => new("inset-be-40");

    /// <summary>Adds <c>inset-be-48</c>.</summary>
    public static InsetBlockEndBuilder Is48 => new("inset-be-48");

    /// <summary>Adds <c>inset-be-64</c>.</summary>
    public static InsetBlockEndBuilder Is64 => new("inset-be-64");

    /// <summary>Adds <c>inset-be-96</c>.</summary>
    public static InsetBlockEndBuilder Is96 => new("inset-be-96");

    /// <summary>Adds <c>inset-be-auto</c>.</summary>
    public static InsetBlockEndBuilder Auto => new("inset-be-auto");

    /// <summary>Adds <c>inset-be-px</c>.</summary>
    public static InsetBlockEndBuilder Px => new("inset-be-px");

    /// <summary>Adds <c>inset-be-1/2</c>.</summary>
    public static InsetBlockEndBuilder Half => new("inset-be-1/2");

    /// <summary>Adds <c>inset-be-full</c>.</summary>
    public static InsetBlockEndBuilder Full => new("inset-be-full");

    /// <summary>Adds <c>-inset-be-1/2</c>.</summary>
    public static InsetBlockEndBuilder NegativeHalf => new("-inset-be-1/2");

    /// <summary>Adds <c>-inset-be-full</c>.</summary>
    public static InsetBlockEndBuilder NegativeFull => new("-inset-be-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetBlockEndBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "inset-be-"));
}
