namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask images and gradients, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskImageBuilder : FinalClassUtilityBuilder<MaskImageBuilder>
{
    internal MaskImageBuilder()
    {
    }

    internal MaskImageBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-none</c>.</summary>
    public MaskImageBuilder None => ChainClass("mask-none");

    /// <summary>Adds <c>mask-linear-0</c>.</summary>
    public MaskImageBuilder Linear0 => ChainClass("mask-linear-0");

    /// <summary>Adds <c>mask-linear-45</c>.</summary>
    public MaskImageBuilder Linear45 => ChainClass("mask-linear-45");

    /// <summary>Adds <c>mask-linear-90</c>.</summary>
    public MaskImageBuilder Linear90 => ChainClass("mask-linear-90");

    /// <summary>Adds <c>mask-linear-180</c>.</summary>
    public MaskImageBuilder Linear180 => ChainClass("mask-linear-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
    /// <summary>Adds a <c>mask-linear-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder LinearFrom(string value) => ChainClass("mask-linear-from-" + value);

    /// <summary>Adds a <c>mask-linear-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder LinearTo(string value) => ChainClass("mask-linear-to-" + value);

    /// <summary>Adds a <c>mask-t-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder TopFrom(string value) => ChainClass("mask-t-from-" + value);

    /// <summary>Adds a <c>mask-t-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder TopTo(string value) => ChainClass("mask-t-to-" + value);

    /// <summary>Adds a <c>mask-b-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder BottomFrom(string value) => ChainClass("mask-b-from-" + value);

    /// <summary>Adds a <c>mask-b-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder BottomTo(string value) => ChainClass("mask-b-to-" + value);

    /// <summary>Adds a <c>mask-radial-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder RadialFrom(string value) => ChainClass("mask-radial-from-" + value);

    /// <summary>Adds a <c>mask-radial-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder RadialTo(string value) => ChainClass("mask-radial-to-" + value);

    /// <summary>Adds a <c>mask-conic-from-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder ConicFrom(string value) => ChainClass("mask-conic-from-" + value);

    /// <summary>Adds a <c>mask-conic-to-*</c> mask stop.</summary>
    /// <param name="value">A percentage, color, or arbitrary Tailwind stop value.</param>
    /// <returns>The current builder.</returns>
    public MaskImageBuilder ConicTo(string value) => ChainClass("mask-conic-to-" + value);

}
