namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for table border spacing.
/// </summary>
[TailwindModifiers(typeof(BorderSpacingBuilder))]
public static partial class BorderSpacing
{
    /// <summary>Selects the x axis for the next utility only.</summary>
    public static BorderSpacingBuilder OnX => new BorderSpacingBuilder().OnX;

    /// <summary>Selects the y axis for the next utility only.</summary>
    public static BorderSpacingBuilder OnY => new BorderSpacingBuilder().OnY;

    /// <summary>Adds <c>border-spacing-0</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is0 => new("border-spacing-0");

    /// <summary>Adds <c>border-spacing-0.5</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is0_5 => new("border-spacing-0.5");

    /// <summary>Adds <c>border-spacing-1</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is1 => new("border-spacing-1");

    /// <summary>Adds <c>border-spacing-1.5</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is1_5 => new("border-spacing-1.5");

    /// <summary>Adds <c>border-spacing-2</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is2 => new("border-spacing-2");

    /// <summary>Adds <c>border-spacing-2.5</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is2_5 => new("border-spacing-2.5");

    /// <summary>Adds <c>border-spacing-3</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is3 => new("border-spacing-3");

    /// <summary>Adds <c>border-spacing-3.5</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is3_5 => new("border-spacing-3.5");

    /// <summary>Adds <c>border-spacing-4</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is4 => new("border-spacing-4");

    /// <summary>Adds <c>border-spacing-5</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is5 => new("border-spacing-5");

    /// <summary>Adds <c>border-spacing-6</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is6 => new("border-spacing-6");

    /// <summary>Adds <c>border-spacing-8</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is8 => new("border-spacing-8");

    /// <summary>Adds <c>border-spacing-10</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is10 => new("border-spacing-10");

    /// <summary>Adds <c>border-spacing-12</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is12 => new("border-spacing-12");

    /// <summary>Adds <c>border-spacing-16</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is16 => new("border-spacing-16");

    /// <summary>Adds <c>border-spacing-20</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is20 => new("border-spacing-20");

    /// <summary>Adds <c>border-spacing-24</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is24 => new("border-spacing-24");

    /// <summary>Adds <c>border-spacing-32</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is32 => new("border-spacing-32");

    /// <summary>Adds <c>border-spacing-40</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is40 => new("border-spacing-40");

    /// <summary>Adds <c>border-spacing-48</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is48 => new("border-spacing-48");

    /// <summary>Adds <c>border-spacing-64</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is64 => new("border-spacing-64");

    /// <summary>Adds <c>border-spacing-96</c> (or its selected axis variant).</summary>
    public static BorderSpacingBuilder Is96 => new("border-spacing-96");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BorderSpacingBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "border-spacing-"));
}
