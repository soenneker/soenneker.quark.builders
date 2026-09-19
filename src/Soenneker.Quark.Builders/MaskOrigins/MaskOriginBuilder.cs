namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask positioning origins, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-origin-", Responsive = true)]
public sealed class MaskOriginBuilder : FinalClassUtilityBuilder<MaskOriginBuilder>
{
    internal MaskOriginBuilder()
    {
    }

    internal MaskOriginBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-origin-border</c>.</summary>
    public MaskOriginBuilder Border => ChainClass("mask-origin-border");

    /// <summary>Adds <c>mask-origin-padding</c>.</summary>
    public MaskOriginBuilder Padding => ChainClass("mask-origin-padding");

    /// <summary>Adds <c>mask-origin-content</c>.</summary>
    public MaskOriginBuilder Content => ChainClass("mask-origin-content");

    /// <summary>Adds <c>mask-origin-fill</c>.</summary>
    public MaskOriginBuilder Fill => ChainClass("mask-origin-fill");

    /// <summary>Adds <c>mask-origin-stroke</c>.</summary>
    public MaskOriginBuilder Stroke => ChainClass("mask-origin-stroke");

    /// <summary>Adds <c>mask-origin-view</c>.</summary>
    public MaskOriginBuilder View => ChainClass("mask-origin-view");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskOriginBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-origin-"));
}
