namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop filter opacity, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-opacity-", Responsive = true)]
public sealed class BackdropOpacityBuilder : FinalClassUtilityBuilder<BackdropOpacityBuilder>
{
    internal BackdropOpacityBuilder()
    {
    }

    internal BackdropOpacityBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-opacity-0</c>.</summary>
    public BackdropOpacityBuilder Is0 => ChainClass("backdrop-opacity-0");

    /// <summary>Adds <c>backdrop-opacity-5</c>.</summary>
    public BackdropOpacityBuilder Is5 => ChainClass("backdrop-opacity-5");

    /// <summary>Adds <c>backdrop-opacity-10</c>.</summary>
    public BackdropOpacityBuilder Is10 => ChainClass("backdrop-opacity-10");

    /// <summary>Adds <c>backdrop-opacity-20</c>.</summary>
    public BackdropOpacityBuilder Is20 => ChainClass("backdrop-opacity-20");

    /// <summary>Adds <c>backdrop-opacity-25</c>.</summary>
    public BackdropOpacityBuilder Is25 => ChainClass("backdrop-opacity-25");

    /// <summary>Adds <c>backdrop-opacity-30</c>.</summary>
    public BackdropOpacityBuilder Is30 => ChainClass("backdrop-opacity-30");

    /// <summary>Adds <c>backdrop-opacity-40</c>.</summary>
    public BackdropOpacityBuilder Is40 => ChainClass("backdrop-opacity-40");

    /// <summary>Adds <c>backdrop-opacity-50</c>.</summary>
    public BackdropOpacityBuilder Is50 => ChainClass("backdrop-opacity-50");

    /// <summary>Adds <c>backdrop-opacity-60</c>.</summary>
    public BackdropOpacityBuilder Is60 => ChainClass("backdrop-opacity-60");

    /// <summary>Adds <c>backdrop-opacity-70</c>.</summary>
    public BackdropOpacityBuilder Is70 => ChainClass("backdrop-opacity-70");

    /// <summary>Adds <c>backdrop-opacity-75</c>.</summary>
    public BackdropOpacityBuilder Is75 => ChainClass("backdrop-opacity-75");

    /// <summary>Adds <c>backdrop-opacity-80</c>.</summary>
    public BackdropOpacityBuilder Is80 => ChainClass("backdrop-opacity-80");

    /// <summary>Adds <c>backdrop-opacity-90</c>.</summary>
    public BackdropOpacityBuilder Is90 => ChainClass("backdrop-opacity-90");

    /// <summary>Adds <c>backdrop-opacity-95</c>.</summary>
    public BackdropOpacityBuilder Is95 => ChainClass("backdrop-opacity-95");

    /// <summary>Adds <c>backdrop-opacity-100</c>.</summary>
    public BackdropOpacityBuilder Is100 => ChainClass("backdrop-opacity-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropOpacityBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-opacity-"));
}
