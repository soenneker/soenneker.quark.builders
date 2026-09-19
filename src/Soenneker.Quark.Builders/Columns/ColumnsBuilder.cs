namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for multi-column layouts, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("columns-", Responsive = true)]
public sealed class ColumnsBuilder : FinalClassUtilityBuilder<ColumnsBuilder>
{
    internal ColumnsBuilder()
    {
    }

    internal ColumnsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>columns-1</c>.</summary>
    public ColumnsBuilder Is1 => ChainClass("columns-1");

    /// <summary>Adds <c>columns-2</c>.</summary>
    public ColumnsBuilder Is2 => ChainClass("columns-2");

    /// <summary>Adds <c>columns-3</c>.</summary>
    public ColumnsBuilder Is3 => ChainClass("columns-3");

    /// <summary>Adds <c>columns-4</c>.</summary>
    public ColumnsBuilder Is4 => ChainClass("columns-4");

    /// <summary>Adds <c>columns-5</c>.</summary>
    public ColumnsBuilder Is5 => ChainClass("columns-5");

    /// <summary>Adds <c>columns-6</c>.</summary>
    public ColumnsBuilder Is6 => ChainClass("columns-6");

    /// <summary>Adds <c>columns-7</c>.</summary>
    public ColumnsBuilder Is7 => ChainClass("columns-7");

    /// <summary>Adds <c>columns-8</c>.</summary>
    public ColumnsBuilder Is8 => ChainClass("columns-8");

    /// <summary>Adds <c>columns-9</c>.</summary>
    public ColumnsBuilder Is9 => ChainClass("columns-9");

    /// <summary>Adds <c>columns-10</c>.</summary>
    public ColumnsBuilder Is10 => ChainClass("columns-10");

    /// <summary>Adds <c>columns-11</c>.</summary>
    public ColumnsBuilder Is11 => ChainClass("columns-11");

    /// <summary>Adds <c>columns-12</c>.</summary>
    public ColumnsBuilder Is12 => ChainClass("columns-12");

    /// <summary>Adds <c>columns-auto</c>.</summary>
    public ColumnsBuilder Auto => ChainClass("columns-auto");

    /// <summary>Adds <c>columns-3xs</c>.</summary>
    public ColumnsBuilder ThreeXs => ChainClass("columns-3xs");

    /// <summary>Adds <c>columns-2xs</c>.</summary>
    public ColumnsBuilder TwoXs => ChainClass("columns-2xs");

    /// <summary>Adds <c>columns-xs</c>.</summary>
    public ColumnsBuilder Xs => ChainClass("columns-xs");

    /// <summary>Adds <c>columns-sm</c>.</summary>
    public ColumnsBuilder Sm => ChainClass("columns-sm");

    /// <summary>Adds <c>columns-md</c>.</summary>
    public ColumnsBuilder Md => ChainClass("columns-md");

    /// <summary>Adds <c>columns-lg</c>.</summary>
    public ColumnsBuilder Lg => ChainClass("columns-lg");

    /// <summary>Adds <c>columns-xl</c>.</summary>
    public ColumnsBuilder Xl => ChainClass("columns-xl");

    /// <summary>Adds <c>columns-2xl</c>.</summary>
    public ColumnsBuilder TwoXl => ChainClass("columns-2xl");

    /// <summary>Adds <c>columns-3xl</c>.</summary>
    public ColumnsBuilder ThreeXl => ChainClass("columns-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ColumnsBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "columns-"));
}
