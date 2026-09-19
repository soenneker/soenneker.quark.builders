namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for logical positioning.
/// </summary>
[TailwindModifiers(typeof(InsetBlockStartBuilder))]
public static partial class InsetBlockStart
{
    /// <summary>Adds <c>inset-bs-0</c>.</summary>
    public static InsetBlockStartBuilder Is0 => new("inset-bs-0");

    /// <summary>Adds <c>inset-bs-0.5</c>.</summary>
    public static InsetBlockStartBuilder Is0_5 => new("inset-bs-0.5");

    /// <summary>Adds <c>inset-bs-1</c>.</summary>
    public static InsetBlockStartBuilder Is1 => new("inset-bs-1");

    /// <summary>Adds <c>inset-bs-1.5</c>.</summary>
    public static InsetBlockStartBuilder Is1_5 => new("inset-bs-1.5");

    /// <summary>Adds <c>inset-bs-2</c>.</summary>
    public static InsetBlockStartBuilder Is2 => new("inset-bs-2");

    /// <summary>Adds <c>inset-bs-2.5</c>.</summary>
    public static InsetBlockStartBuilder Is2_5 => new("inset-bs-2.5");

    /// <summary>Adds <c>inset-bs-3</c>.</summary>
    public static InsetBlockStartBuilder Is3 => new("inset-bs-3");

    /// <summary>Adds <c>inset-bs-3.5</c>.</summary>
    public static InsetBlockStartBuilder Is3_5 => new("inset-bs-3.5");

    /// <summary>Adds <c>inset-bs-4</c>.</summary>
    public static InsetBlockStartBuilder Is4 => new("inset-bs-4");

    /// <summary>Adds <c>inset-bs-5</c>.</summary>
    public static InsetBlockStartBuilder Is5 => new("inset-bs-5");

    /// <summary>Adds <c>inset-bs-6</c>.</summary>
    public static InsetBlockStartBuilder Is6 => new("inset-bs-6");

    /// <summary>Adds <c>inset-bs-8</c>.</summary>
    public static InsetBlockStartBuilder Is8 => new("inset-bs-8");

    /// <summary>Adds <c>inset-bs-10</c>.</summary>
    public static InsetBlockStartBuilder Is10 => new("inset-bs-10");

    /// <summary>Adds <c>inset-bs-12</c>.</summary>
    public static InsetBlockStartBuilder Is12 => new("inset-bs-12");

    /// <summary>Adds <c>inset-bs-16</c>.</summary>
    public static InsetBlockStartBuilder Is16 => new("inset-bs-16");

    /// <summary>Adds <c>inset-bs-20</c>.</summary>
    public static InsetBlockStartBuilder Is20 => new("inset-bs-20");

    /// <summary>Adds <c>inset-bs-24</c>.</summary>
    public static InsetBlockStartBuilder Is24 => new("inset-bs-24");

    /// <summary>Adds <c>inset-bs-32</c>.</summary>
    public static InsetBlockStartBuilder Is32 => new("inset-bs-32");

    /// <summary>Adds <c>inset-bs-40</c>.</summary>
    public static InsetBlockStartBuilder Is40 => new("inset-bs-40");

    /// <summary>Adds <c>inset-bs-48</c>.</summary>
    public static InsetBlockStartBuilder Is48 => new("inset-bs-48");

    /// <summary>Adds <c>inset-bs-64</c>.</summary>
    public static InsetBlockStartBuilder Is64 => new("inset-bs-64");

    /// <summary>Adds <c>inset-bs-96</c>.</summary>
    public static InsetBlockStartBuilder Is96 => new("inset-bs-96");

    /// <summary>Adds <c>inset-bs-auto</c>.</summary>
    public static InsetBlockStartBuilder Auto => new("inset-bs-auto");

    /// <summary>Adds <c>inset-bs-px</c>.</summary>
    public static InsetBlockStartBuilder Px => new("inset-bs-px");

    /// <summary>Adds <c>inset-bs-1/2</c>.</summary>
    public static InsetBlockStartBuilder Half => new("inset-bs-1/2");

    /// <summary>Adds <c>inset-bs-full</c>.</summary>
    public static InsetBlockStartBuilder Full => new("inset-bs-full");

    /// <summary>Adds <c>-inset-bs-1/2</c>.</summary>
    public static InsetBlockStartBuilder NegativeHalf => new("-inset-bs-1/2");

    /// <summary>Adds <c>-inset-bs-full</c>.</summary>
    public static InsetBlockStartBuilder NegativeFull => new("-inset-bs-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetBlockStartBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "inset-bs-"));
}
