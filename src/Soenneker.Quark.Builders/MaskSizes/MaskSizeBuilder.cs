namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask sizing, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskSizeBuilder : FinalClassUtilityBuilder<MaskSizeBuilder>
{
    internal MaskSizeBuilder()
    {
    }

    internal MaskSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-auto</c>.</summary>
    public MaskSizeBuilder Auto => ChainClass("mask-auto");

    /// <summary>Adds <c>mask-cover</c>.</summary>
    public MaskSizeBuilder Cover => ChainClass("mask-cover");

    /// <summary>Adds <c>mask-contain</c>.</summary>
    public MaskSizeBuilder Contain => ChainClass("mask-contain");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
