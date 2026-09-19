namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask composition, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskCompositeBuilder : FinalClassUtilityBuilder<MaskCompositeBuilder>
{
    internal MaskCompositeBuilder()
    {
    }

    internal MaskCompositeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-add</c>.</summary>
    public MaskCompositeBuilder Add => ChainClass("mask-add");

    /// <summary>Adds <c>mask-subtract</c>.</summary>
    public MaskCompositeBuilder Subtract => ChainClass("mask-subtract");

    /// <summary>Adds <c>mask-intersect</c>.</summary>
    public MaskCompositeBuilder Intersect => ChainClass("mask-intersect");

    /// <summary>Adds <c>mask-exclude</c>.</summary>
    public MaskCompositeBuilder Exclude => ChainClass("mask-exclude");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskCompositeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
