namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop saturate filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-saturate-", Responsive = true)]
public sealed class BackdropSaturateBuilder : FinalClassUtilityBuilder<BackdropSaturateBuilder>
{
    internal BackdropSaturateBuilder()
    {
    }

    internal BackdropSaturateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-saturate-0</c>.</summary>
    public BackdropSaturateBuilder Is0 => ChainClass("backdrop-saturate-0");

    /// <summary>Adds <c>backdrop-saturate-50</c>.</summary>
    public BackdropSaturateBuilder Is50 => ChainClass("backdrop-saturate-50");

    /// <summary>Adds <c>backdrop-saturate-100</c>.</summary>
    public BackdropSaturateBuilder Is100 => ChainClass("backdrop-saturate-100");

    /// <summary>Adds <c>backdrop-saturate-150</c>.</summary>
    public BackdropSaturateBuilder Is150 => ChainClass("backdrop-saturate-150");

    /// <summary>Adds <c>backdrop-saturate-200</c>.</summary>
    public BackdropSaturateBuilder Is200 => ChainClass("backdrop-saturate-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropSaturateBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-saturate-"));
}
