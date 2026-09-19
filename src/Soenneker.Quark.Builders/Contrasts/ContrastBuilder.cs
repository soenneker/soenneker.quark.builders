namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for contrast filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("contrast-", Responsive = true)]
public sealed class ContrastBuilder : FinalClassUtilityBuilder<ContrastBuilder>
{
    internal ContrastBuilder()
    {
    }

    internal ContrastBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>contrast-0</c>.</summary>
    public ContrastBuilder Is0 => ChainClass("contrast-0");

    /// <summary>Adds <c>contrast-50</c>.</summary>
    public ContrastBuilder Is50 => ChainClass("contrast-50");

    /// <summary>Adds <c>contrast-75</c>.</summary>
    public ContrastBuilder Is75 => ChainClass("contrast-75");

    /// <summary>Adds <c>contrast-100</c>.</summary>
    public ContrastBuilder Is100 => ChainClass("contrast-100");

    /// <summary>Adds <c>contrast-125</c>.</summary>
    public ContrastBuilder Is125 => ChainClass("contrast-125");

    /// <summary>Adds <c>contrast-150</c>.</summary>
    public ContrastBuilder Is150 => ChainClass("contrast-150");

    /// <summary>Adds <c>contrast-200</c>.</summary>
    public ContrastBuilder Is200 => ChainClass("contrast-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ContrastBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "contrast-"));
}
