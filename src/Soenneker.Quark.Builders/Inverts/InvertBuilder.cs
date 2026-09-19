namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for invert filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("invert-", Responsive = true)]
public sealed class InvertBuilder : FinalClassUtilityBuilder<InvertBuilder>
{
    internal InvertBuilder()
    {
    }

    internal InvertBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>invert-0</c>.</summary>
    public InvertBuilder Is0 => ChainClass("invert-0");

    /// <summary>Adds <c>invert-25</c>.</summary>
    public InvertBuilder Is25 => ChainClass("invert-25");

    /// <summary>Adds <c>invert-50</c>.</summary>
    public InvertBuilder Is50 => ChainClass("invert-50");

    /// <summary>Adds <c>invert-75</c>.</summary>
    public InvertBuilder Is75 => ChainClass("invert-75");

    /// <summary>Adds <c>invert-100</c>.</summary>
    public InvertBuilder Is100 => ChainClass("invert-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public InvertBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "invert-"));
}
