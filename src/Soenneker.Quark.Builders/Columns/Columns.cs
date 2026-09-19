namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for multi-column layouts.
/// </summary>
[TailwindModifiers(typeof(ColumnsBuilder))]
public static partial class Columns
{
    /// <summary>Adds <c>columns-1</c>.</summary>
    public static ColumnsBuilder Is1 => new("columns-1");

    /// <summary>Adds <c>columns-2</c>.</summary>
    public static ColumnsBuilder Is2 => new("columns-2");

    /// <summary>Adds <c>columns-3</c>.</summary>
    public static ColumnsBuilder Is3 => new("columns-3");

    /// <summary>Adds <c>columns-4</c>.</summary>
    public static ColumnsBuilder Is4 => new("columns-4");

    /// <summary>Adds <c>columns-5</c>.</summary>
    public static ColumnsBuilder Is5 => new("columns-5");

    /// <summary>Adds <c>columns-6</c>.</summary>
    public static ColumnsBuilder Is6 => new("columns-6");

    /// <summary>Adds <c>columns-7</c>.</summary>
    public static ColumnsBuilder Is7 => new("columns-7");

    /// <summary>Adds <c>columns-8</c>.</summary>
    public static ColumnsBuilder Is8 => new("columns-8");

    /// <summary>Adds <c>columns-9</c>.</summary>
    public static ColumnsBuilder Is9 => new("columns-9");

    /// <summary>Adds <c>columns-10</c>.</summary>
    public static ColumnsBuilder Is10 => new("columns-10");

    /// <summary>Adds <c>columns-11</c>.</summary>
    public static ColumnsBuilder Is11 => new("columns-11");

    /// <summary>Adds <c>columns-12</c>.</summary>
    public static ColumnsBuilder Is12 => new("columns-12");

    /// <summary>Adds <c>columns-auto</c>.</summary>
    public static ColumnsBuilder Auto => new("columns-auto");

    /// <summary>Adds <c>columns-3xs</c>.</summary>
    public static ColumnsBuilder ThreeXs => new("columns-3xs");

    /// <summary>Adds <c>columns-2xs</c>.</summary>
    public static ColumnsBuilder TwoXs => new("columns-2xs");

    /// <summary>Adds <c>columns-xs</c>.</summary>
    public static ColumnsBuilder Xs => new("columns-xs");

    /// <summary>Adds <c>columns-sm</c>.</summary>
    public static ColumnsBuilder Sm => new("columns-sm");

    /// <summary>Adds <c>columns-md</c>.</summary>
    public static ColumnsBuilder Md => new("columns-md");

    /// <summary>Adds <c>columns-lg</c>.</summary>
    public static ColumnsBuilder Lg => new("columns-lg");

    /// <summary>Adds <c>columns-xl</c>.</summary>
    public static ColumnsBuilder Xl => new("columns-xl");

    /// <summary>Adds <c>columns-2xl</c>.</summary>
    public static ColumnsBuilder TwoXl => new("columns-2xl");

    /// <summary>Adds <c>columns-3xl</c>.</summary>
    public static ColumnsBuilder ThreeXl => new("columns-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ColumnsBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "columns-"));
}
