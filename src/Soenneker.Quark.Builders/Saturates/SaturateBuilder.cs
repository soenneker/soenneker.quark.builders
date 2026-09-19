namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for saturate filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("saturate-", Responsive = true)]
public sealed class SaturateBuilder : FinalClassUtilityBuilder<SaturateBuilder>
{
    internal SaturateBuilder()
    {
    }

    internal SaturateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>saturate-0</c>.</summary>
    public SaturateBuilder Is0 => ChainClass("saturate-0");

    /// <summary>Adds <c>saturate-50</c>.</summary>
    public SaturateBuilder Is50 => ChainClass("saturate-50");

    /// <summary>Adds <c>saturate-100</c>.</summary>
    public SaturateBuilder Is100 => ChainClass("saturate-100");

    /// <summary>Adds <c>saturate-150</c>.</summary>
    public SaturateBuilder Is150 => ChainClass("saturate-150");

    /// <summary>Adds <c>saturate-200</c>.</summary>
    public SaturateBuilder Is200 => ChainClass("saturate-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public SaturateBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "saturate-"));
}
