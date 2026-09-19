namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for sepia filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("sepia-", Responsive = true)]
public sealed class SepiaBuilder : FinalClassUtilityBuilder<SepiaBuilder>
{
    internal SepiaBuilder()
    {
    }

    internal SepiaBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>sepia-0</c>.</summary>
    public SepiaBuilder Is0 => ChainClass("sepia-0");

    /// <summary>Adds <c>sepia-25</c>.</summary>
    public SepiaBuilder Is25 => ChainClass("sepia-25");

    /// <summary>Adds <c>sepia-50</c>.</summary>
    public SepiaBuilder Is50 => ChainClass("sepia-50");

    /// <summary>Adds <c>sepia-75</c>.</summary>
    public SepiaBuilder Is75 => ChainClass("sepia-75");

    /// <summary>Adds <c>sepia-100</c>.</summary>
    public SepiaBuilder Is100 => ChainClass("sepia-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public SepiaBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "sepia-"));
}
