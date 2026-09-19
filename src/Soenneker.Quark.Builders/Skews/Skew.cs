namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for skew angles on both axes or a selected axis.
/// </summary>
[TailwindModifiers(typeof(SkewBuilder))]
public static partial class Skew
{
    /// <summary>Selects the x axis for the next utility only.</summary>
    public static SkewBuilder OnX => new SkewBuilder().OnX;

    /// <summary>Selects the y axis for the next utility only.</summary>
    public static SkewBuilder OnY => new SkewBuilder().OnY;

    /// <summary>Adds <c>skew-0</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is0 => new("skew-0");

    /// <summary>Adds <c>skew-1</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is1 => new("skew-1");

    /// <summary>Adds <c>skew-2</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is2 => new("skew-2");

    /// <summary>Adds <c>skew-3</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is3 => new("skew-3");

    /// <summary>Adds <c>skew-6</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is6 => new("skew-6");

    /// <summary>Adds <c>skew-12</c> (or its selected axis variant).</summary>
    public static SkewBuilder Is12 => new("skew-12");

    /// <summary>Adds <c>-skew-1</c> (or its selected axis variant).</summary>
    public static SkewBuilder Negative1 => new("-skew-1");

    /// <summary>Adds <c>-skew-2</c> (or its selected axis variant).</summary>
    public static SkewBuilder Negative2 => new("-skew-2");

    /// <summary>Adds <c>-skew-3</c> (or its selected axis variant).</summary>
    public static SkewBuilder Negative3 => new("-skew-3");

    /// <summary>Adds <c>-skew-6</c> (or its selected axis variant).</summary>
    public static SkewBuilder Negative6 => new("-skew-6");

    /// <summary>Adds <c>-skew-12</c> (or its selected axis variant).</summary>
    public static SkewBuilder Negative12 => new("-skew-12");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static SkewBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "skew-"));
}
