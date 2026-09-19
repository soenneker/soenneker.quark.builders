namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for outline width, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("outline-", Responsive = true)]
public sealed class OutlineWidthBuilder : FinalClassUtilityBuilder<OutlineWidthBuilder>
{
    internal OutlineWidthBuilder()
    {
    }

    internal OutlineWidthBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>outline-0</c>.</summary>
    public OutlineWidthBuilder Is0 => ChainClass("outline-0");

    /// <summary>Adds <c>outline-1</c>.</summary>
    public OutlineWidthBuilder Is1 => ChainClass("outline-1");

    /// <summary>Adds <c>outline-2</c>.</summary>
    public OutlineWidthBuilder Is2 => ChainClass("outline-2");

    /// <summary>Adds <c>outline-4</c>.</summary>
    public OutlineWidthBuilder Is4 => ChainClass("outline-4");

    /// <summary>Adds <c>outline-8</c>.</summary>
    public OutlineWidthBuilder Is8 => ChainClass("outline-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public OutlineWidthBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "outline-"));
}
