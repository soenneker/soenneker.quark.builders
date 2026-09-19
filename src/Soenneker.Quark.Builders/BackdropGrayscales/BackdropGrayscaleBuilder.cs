namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop grayscale filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-grayscale-", Responsive = true)]
public sealed class BackdropGrayscaleBuilder : FinalClassUtilityBuilder<BackdropGrayscaleBuilder>
{
    internal BackdropGrayscaleBuilder()
    {
    }

    internal BackdropGrayscaleBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-grayscale-0</c>.</summary>
    public BackdropGrayscaleBuilder Is0 => ChainClass("backdrop-grayscale-0");

    /// <summary>Adds <c>backdrop-grayscale-25</c>.</summary>
    public BackdropGrayscaleBuilder Is25 => ChainClass("backdrop-grayscale-25");

    /// <summary>Adds <c>backdrop-grayscale-50</c>.</summary>
    public BackdropGrayscaleBuilder Is50 => ChainClass("backdrop-grayscale-50");

    /// <summary>Adds <c>backdrop-grayscale-75</c>.</summary>
    public BackdropGrayscaleBuilder Is75 => ChainClass("backdrop-grayscale-75");

    /// <summary>Adds <c>backdrop-grayscale-100</c>.</summary>
    public BackdropGrayscaleBuilder Is100 => ChainClass("backdrop-grayscale-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropGrayscaleBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-grayscale-"));
}
