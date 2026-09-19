namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for tab character width.
/// </summary>
[TailwindModifiers(typeof(TabSizeBuilder))]
public static partial class TabSize
{
    /// <summary>Adds <c>tab-0</c>.</summary>
    public static TabSizeBuilder Is0 => new("tab-0");

    /// <summary>Adds <c>tab-2</c>.</summary>
    public static TabSizeBuilder Is2 => new("tab-2");

    /// <summary>Adds <c>tab-4</c>.</summary>
    public static TabSizeBuilder Is4 => new("tab-4");

    /// <summary>Adds <c>tab-8</c>.</summary>
    public static TabSizeBuilder Is8 => new("tab-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TabSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "tab-"));
}
