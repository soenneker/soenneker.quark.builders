namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for tab character width, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("tab-", Responsive = true)]
public sealed class TabSizeBuilder : FinalClassUtilityBuilder<TabSizeBuilder>
{
    internal TabSizeBuilder()
    {
    }

    internal TabSizeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>tab-0</c>.</summary>
    public TabSizeBuilder Is0 => ChainClass("tab-0");

    /// <summary>Adds <c>tab-2</c>.</summary>
    public TabSizeBuilder Is2 => ChainClass("tab-2");

    /// <summary>Adds <c>tab-4</c>.</summary>
    public TabSizeBuilder Is4 => ChainClass("tab-4");

    /// <summary>Adds <c>tab-8</c>.</summary>
    public TabSizeBuilder Is8 => ChainClass("tab-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TabSizeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "tab-"));
}
