namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for SVG mask types, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-type-", Responsive = true)]
public sealed class MaskTypeBuilder : FinalClassUtilityBuilder<MaskTypeBuilder>
{
    internal MaskTypeBuilder()
    {
    }

    internal MaskTypeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-type-alpha</c>.</summary>
    public MaskTypeBuilder Alpha => ChainClass("mask-type-alpha");

    /// <summary>Adds <c>mask-type-luminance</c>.</summary>
    public MaskTypeBuilder Luminance => ChainClass("mask-type-luminance");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskTypeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-type-"));
}
