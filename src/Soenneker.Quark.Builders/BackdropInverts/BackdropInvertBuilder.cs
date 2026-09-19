namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop invert filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-invert-", Responsive = true)]
public sealed class BackdropInvertBuilder : FinalClassUtilityBuilder<BackdropInvertBuilder>
{
    internal BackdropInvertBuilder()
    {
    }

    internal BackdropInvertBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-invert-0</c>.</summary>
    public BackdropInvertBuilder Is0 => ChainClass("backdrop-invert-0");

    /// <summary>Adds <c>backdrop-invert-25</c>.</summary>
    public BackdropInvertBuilder Is25 => ChainClass("backdrop-invert-25");

    /// <summary>Adds <c>backdrop-invert-50</c>.</summary>
    public BackdropInvertBuilder Is50 => ChainClass("backdrop-invert-50");

    /// <summary>Adds <c>backdrop-invert-75</c>.</summary>
    public BackdropInvertBuilder Is75 => ChainClass("backdrop-invert-75");

    /// <summary>Adds <c>backdrop-invert-100</c>.</summary>
    public BackdropInvertBuilder Is100 => ChainClass("backdrop-invert-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropInvertBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-invert-"));
}
