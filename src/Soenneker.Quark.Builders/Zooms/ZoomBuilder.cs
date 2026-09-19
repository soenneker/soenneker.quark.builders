namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for CSS zoom, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("zoom-", Responsive = true)]
public sealed class ZoomBuilder : FinalClassUtilityBuilder<ZoomBuilder>
{
    internal ZoomBuilder()
    {
    }

    internal ZoomBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>zoom-50</c>.</summary>
    public ZoomBuilder Is50 => ChainClass("zoom-50");

    /// <summary>Adds <c>zoom-75</c>.</summary>
    public ZoomBuilder Is75 => ChainClass("zoom-75");

    /// <summary>Adds <c>zoom-90</c>.</summary>
    public ZoomBuilder Is90 => ChainClass("zoom-90");

    /// <summary>Adds <c>zoom-100</c>.</summary>
    public ZoomBuilder Is100 => ChainClass("zoom-100");

    /// <summary>Adds <c>zoom-110</c>.</summary>
    public ZoomBuilder Is110 => ChainClass("zoom-110");

    /// <summary>Adds <c>zoom-125</c>.</summary>
    public ZoomBuilder Is125 => ChainClass("zoom-125");

    /// <summary>Adds <c>zoom-150</c>.</summary>
    public ZoomBuilder Is150 => ChainClass("zoom-150");

    /// <summary>Adds <c>zoom-200</c>.</summary>
    public ZoomBuilder Is200 => ChainClass("zoom-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ZoomBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "zoom-"));
}
