namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for grayscale filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("grayscale-", Responsive = true)]
public sealed class GrayscaleBuilder : FinalClassUtilityBuilder<GrayscaleBuilder>
{
    internal GrayscaleBuilder()
    {
    }

    internal GrayscaleBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>grayscale-0</c>.</summary>
    public GrayscaleBuilder Is0 => ChainClass("grayscale-0");

    /// <summary>Adds <c>grayscale-25</c>.</summary>
    public GrayscaleBuilder Is25 => ChainClass("grayscale-25");

    /// <summary>Adds <c>grayscale-50</c>.</summary>
    public GrayscaleBuilder Is50 => ChainClass("grayscale-50");

    /// <summary>Adds <c>grayscale-75</c>.</summary>
    public GrayscaleBuilder Is75 => ChainClass("grayscale-75");

    /// <summary>Adds <c>grayscale-100</c>.</summary>
    public GrayscaleBuilder Is100 => ChainClass("grayscale-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public GrayscaleBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "grayscale-"));
}
