namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop sepia filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-sepia-", Responsive = true)]
public sealed class BackdropSepiaBuilder : FinalClassUtilityBuilder<BackdropSepiaBuilder>
{
    internal BackdropSepiaBuilder()
    {
    }

    internal BackdropSepiaBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-sepia-0</c>.</summary>
    public BackdropSepiaBuilder Is0 => ChainClass("backdrop-sepia-0");

    /// <summary>Adds <c>backdrop-sepia-25</c>.</summary>
    public BackdropSepiaBuilder Is25 => ChainClass("backdrop-sepia-25");

    /// <summary>Adds <c>backdrop-sepia-50</c>.</summary>
    public BackdropSepiaBuilder Is50 => ChainClass("backdrop-sepia-50");

    /// <summary>Adds <c>backdrop-sepia-75</c>.</summary>
    public BackdropSepiaBuilder Is75 => ChainClass("backdrop-sepia-75");

    /// <summary>Adds <c>backdrop-sepia-100</c>.</summary>
    public BackdropSepiaBuilder Is100 => ChainClass("backdrop-sepia-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropSepiaBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-sepia-"));
}
