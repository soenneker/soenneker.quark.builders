namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for table layout.
/// </summary>
[TailwindModifiers(typeof(TableLayoutBuilder))]
public static partial class TableLayout
{
    /// <summary>Adds <c>table-auto</c>.</summary>
    public static TableLayoutBuilder Auto => new("table-auto");

    /// <summary>Adds <c>table-fixed</c>.</summary>
    public static TableLayoutBuilder Fixed => new("table-fixed");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TableLayoutBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "table-"));
}
