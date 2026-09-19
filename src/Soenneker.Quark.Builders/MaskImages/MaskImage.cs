namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask images and gradients.
/// </summary>
[TailwindModifiers(typeof(MaskImageBuilder))]
public static partial class MaskImage
{
    /// <summary>Adds <c>mask-none</c>.</summary>
    public static MaskImageBuilder None => new("mask-none");

    /// <summary>Adds <c>mask-linear-0</c>.</summary>
    public static MaskImageBuilder Linear0 => new("mask-linear-0");

    /// <summary>Adds <c>mask-linear-45</c>.</summary>
    public static MaskImageBuilder Linear45 => new("mask-linear-45");

    /// <summary>Adds <c>mask-linear-90</c>.</summary>
    public static MaskImageBuilder Linear90 => new("mask-linear-90");

    /// <summary>Adds <c>mask-linear-180</c>.</summary>
    public static MaskImageBuilder Linear180 => new("mask-linear-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskImageBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
    /// <summary>Adds a <c>mask-linear-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder LinearFrom(string value) => new("mask-linear-from-" + value);

    /// <summary>Adds a <c>mask-linear-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder LinearTo(string value) => new("mask-linear-to-" + value);

    /// <summary>Adds a <c>mask-t-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder TopFrom(string value) => new("mask-t-from-" + value);

    /// <summary>Adds a <c>mask-t-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder TopTo(string value) => new("mask-t-to-" + value);

    /// <summary>Adds a <c>mask-b-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder BottomFrom(string value) => new("mask-b-from-" + value);

    /// <summary>Adds a <c>mask-b-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder BottomTo(string value) => new("mask-b-to-" + value);

    /// <summary>Adds a <c>mask-radial-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder RadialFrom(string value) => new("mask-radial-from-" + value);

    /// <summary>Adds a <c>mask-radial-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder RadialTo(string value) => new("mask-radial-to-" + value);

    /// <summary>Adds a <c>mask-conic-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder ConicFrom(string value) => new("mask-conic-from-" + value);

    /// <summary>Adds a <c>mask-conic-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>A new builder.</returns>
    public static MaskImageBuilder ConicTo(string value) => new("mask-conic-to-" + value);

}
