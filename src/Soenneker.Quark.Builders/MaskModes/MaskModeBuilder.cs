namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for mask source interpretation, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("mask-", Responsive = true)]
public sealed class MaskModeBuilder : FinalClassUtilityBuilder<MaskModeBuilder>
{
    internal MaskModeBuilder()
    {
    }

    internal MaskModeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>mask-alpha</c>.</summary>
    public MaskModeBuilder Alpha => ChainClass("mask-alpha");

    /// <summary>Adds <c>mask-luminance</c>.</summary>
    public MaskModeBuilder Luminance => ChainClass("mask-luminance");

    /// <summary>Adds <c>mask-match</c>.</summary>
    public MaskModeBuilder Match => ChainClass("mask-match");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>The current builder.</returns>
    public MaskModeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "mask-"));
}
