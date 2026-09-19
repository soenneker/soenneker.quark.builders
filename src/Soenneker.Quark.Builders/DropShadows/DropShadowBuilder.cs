namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for drop shadow filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("drop-shadow-", Responsive = true)]
public sealed class DropShadowBuilder : FinalClassUtilityBuilder<DropShadowBuilder>
{
    internal DropShadowBuilder()
    {
    }

    internal DropShadowBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>drop-shadow-none</c>.</summary>
    public DropShadowBuilder None => ChainClass("drop-shadow-none");

    /// <summary>Adds <c>drop-shadow-xs</c>.</summary>
    public DropShadowBuilder Xs => ChainClass("drop-shadow-xs");

    /// <summary>Adds <c>drop-shadow-sm</c>.</summary>
    public DropShadowBuilder Sm => ChainClass("drop-shadow-sm");

    /// <summary>Adds <c>drop-shadow-md</c>.</summary>
    public DropShadowBuilder Md => ChainClass("drop-shadow-md");

    /// <summary>Adds <c>drop-shadow-lg</c>.</summary>
    public DropShadowBuilder Lg => ChainClass("drop-shadow-lg");

    /// <summary>Adds <c>drop-shadow-xl</c>.</summary>
    public DropShadowBuilder Xl => ChainClass("drop-shadow-xl");

    /// <summary>Adds <c>drop-shadow-2xl</c>.</summary>
    public DropShadowBuilder TwoXl => ChainClass("drop-shadow-2xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public DropShadowBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "drop-shadow-"));
}
