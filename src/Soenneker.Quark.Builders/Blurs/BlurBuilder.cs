namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for blur filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("blur-", Responsive = true)]
public sealed class BlurBuilder : FinalClassUtilityBuilder<BlurBuilder>
{
    internal BlurBuilder()
    {
    }

    internal BlurBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>blur-none</c>.</summary>
    public BlurBuilder None => ChainClass("blur-none");

    /// <summary>Adds <c>blur-xs</c>.</summary>
    public BlurBuilder Xs => ChainClass("blur-xs");

    /// <summary>Adds <c>blur-sm</c>.</summary>
    public BlurBuilder Sm => ChainClass("blur-sm");

    /// <summary>Adds <c>blur-md</c>.</summary>
    public BlurBuilder Md => ChainClass("blur-md");

    /// <summary>Adds <c>blur-lg</c>.</summary>
    public BlurBuilder Lg => ChainClass("blur-lg");

    /// <summary>Adds <c>blur-xl</c>.</summary>
    public BlurBuilder Xl => ChainClass("blur-xl");

    /// <summary>Adds <c>blur-2xl</c>.</summary>
    public BlurBuilder TwoXl => ChainClass("blur-2xl");

    /// <summary>Adds <c>blur-3xl</c>.</summary>
    public BlurBuilder ThreeXl => ChainClass("blur-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BlurBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "blur-"));
}
