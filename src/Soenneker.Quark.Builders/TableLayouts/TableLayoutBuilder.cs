namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for table layout, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("table-", Responsive = true)]
public sealed class TableLayoutBuilder : FinalClassUtilityBuilder<TableLayoutBuilder>
{
    internal TableLayoutBuilder()
    {
    }

    internal TableLayoutBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>table-auto</c>.</summary>
    public TableLayoutBuilder Auto => ChainClass("table-auto");

    /// <summary>Adds <c>table-fixed</c>.</summary>
    public TableLayoutBuilder Fixed => ChainClass("table-fixed");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TableLayoutBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "table-"));
}
