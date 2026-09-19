namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for inset box shadows, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("inset-shadow-", Responsive = true)]
public sealed class InsetShadowBuilder : FinalClassUtilityBuilder<InsetShadowBuilder>
{
    internal InsetShadowBuilder()
    {
    }

    internal InsetShadowBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>inset-shadow-none</c>.</summary>
    public InsetShadowBuilder None => ChainClass("inset-shadow-none");

    /// <summary>Adds <c>inset-shadow-2xs</c>.</summary>
    public InsetShadowBuilder TwoXs => ChainClass("inset-shadow-2xs");

    /// <summary>Adds <c>inset-shadow-xs</c>.</summary>
    public InsetShadowBuilder Xs => ChainClass("inset-shadow-xs");

    /// <summary>Adds <c>inset-shadow-sm</c>.</summary>
    public InsetShadowBuilder Sm => ChainClass("inset-shadow-sm");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InsetShadowBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "inset-shadow-"));
}
