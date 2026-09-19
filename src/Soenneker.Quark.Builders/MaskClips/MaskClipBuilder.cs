namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask clipping, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskClipBuilder : FinalClassUtilityBuilder<MaskClipBuilder>
{
    internal MaskClipBuilder()
    {
    }

    internal MaskClipBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-clip-border</c>.</summary>
    public MaskClipBuilder Border => ChainClass("mask-clip-border");

    /// <summary>Adds <c>mask-clip-padding</c>.</summary>
    public MaskClipBuilder Padding => ChainClass("mask-clip-padding");

    /// <summary>Adds <c>mask-clip-content</c>.</summary>
    public MaskClipBuilder Content => ChainClass("mask-clip-content");

    /// <summary>Adds <c>mask-clip-fill</c>.</summary>
    public MaskClipBuilder Fill => ChainClass("mask-clip-fill");

    /// <summary>Adds <c>mask-clip-stroke</c>.</summary>
    public MaskClipBuilder Stroke => ChainClass("mask-clip-stroke");

    /// <summary>Adds <c>mask-clip-view</c>.</summary>
    public MaskClipBuilder View => ChainClass("mask-clip-view");

    /// <summary>Adds <c>mask-no-clip</c>.</summary>
    public MaskClipBuilder None => ChainClass("mask-no-clip");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskClipBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
