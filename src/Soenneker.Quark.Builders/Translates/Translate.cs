namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for translation on both axes or a selected axis.
/// </summary>
[TailwindModifiers(typeof(TranslateBuilder))]
public static partial class Translate
{
    /// <summary>Selects the x axis for the next utility only.</summary>
    public static TranslateBuilder OnX => new TranslateBuilder().OnX;

    /// <summary>Selects the y axis for the next utility only.</summary>
    public static TranslateBuilder OnY => new TranslateBuilder().OnY;

    /// <summary>Adds <c>translate-0</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is0 => new("translate-0");

    /// <summary>Adds <c>translate-0.5</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is0_5 => new("translate-0.5");

    /// <summary>Adds <c>translate-1</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is1 => new("translate-1");

    /// <summary>Adds <c>translate-1.5</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is1_5 => new("translate-1.5");

    /// <summary>Adds <c>translate-2</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is2 => new("translate-2");

    /// <summary>Adds <c>translate-2.5</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is2_5 => new("translate-2.5");

    /// <summary>Adds <c>translate-3</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is3 => new("translate-3");

    /// <summary>Adds <c>translate-3.5</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is3_5 => new("translate-3.5");

    /// <summary>Adds <c>translate-4</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is4 => new("translate-4");

    /// <summary>Adds <c>translate-5</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is5 => new("translate-5");

    /// <summary>Adds <c>translate-6</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is6 => new("translate-6");

    /// <summary>Adds <c>translate-8</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is8 => new("translate-8");

    /// <summary>Adds <c>translate-10</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is10 => new("translate-10");

    /// <summary>Adds <c>translate-12</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is12 => new("translate-12");

    /// <summary>Adds <c>translate-16</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is16 => new("translate-16");

    /// <summary>Adds <c>translate-20</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is20 => new("translate-20");

    /// <summary>Adds <c>translate-24</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is24 => new("translate-24");

    /// <summary>Adds <c>translate-32</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is32 => new("translate-32");

    /// <summary>Adds <c>translate-40</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is40 => new("translate-40");

    /// <summary>Adds <c>translate-48</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is48 => new("translate-48");

    /// <summary>Adds <c>translate-64</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is64 => new("translate-64");

    /// <summary>Adds <c>translate-96</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Is96 => new("translate-96");

    /// <summary>Adds <c>translate-px</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Px => new("translate-px");

    /// <summary>Adds <c>translate-1/2</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Half => new("translate-1/2");

    /// <summary>Adds <c>translate-full</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Full => new("translate-full");

    /// <summary>Adds <c>translate-none</c>, clearing translation on every axis.</summary>
    public static TranslateBuilder None => new("translate-none");

    /// <summary>Adds <c>-translate-1</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Negative1 => new("-translate-1");

    /// <summary>Adds <c>-translate-2</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Negative2 => new("-translate-2");

    /// <summary>Adds <c>-translate-4</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Negative4 => new("-translate-4");

    /// <summary>Adds <c>-translate-8</c> (or its selected axis variant).</summary>
    public static TranslateBuilder Negative8 => new("-translate-8");

    /// <summary>Adds <c>-translate-1/2</c> (or its selected axis variant).</summary>
    public static TranslateBuilder NegativeHalf => new("-translate-1/2");

    /// <summary>Adds <c>-translate-full</c> (or its selected axis variant).</summary>
    public static TranslateBuilder NegativeFull => new("-translate-full");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TranslateBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "translate-"));
}
