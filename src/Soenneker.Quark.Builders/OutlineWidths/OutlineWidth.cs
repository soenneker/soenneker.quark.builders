namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for outline width.
/// </summary>
[TailwindModifiers(typeof(OutlineWidthBuilder))]
public static partial class OutlineWidth
{
    /// <summary>Adds <c>outline-0</c>.</summary>
    public static OutlineWidthBuilder Is0 => new("outline-0");

    /// <summary>Adds <c>outline-1</c>.</summary>
    public static OutlineWidthBuilder Is1 => new("outline-1");

    /// <summary>Adds <c>outline-2</c>.</summary>
    public static OutlineWidthBuilder Is2 => new("outline-2");

    /// <summary>Adds <c>outline-4</c>.</summary>
    public static OutlineWidthBuilder Is4 => new("outline-4");

    /// <summary>Adds <c>outline-8</c>.</summary>
    public static OutlineWidthBuilder Is8 => new("outline-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static OutlineWidthBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "outline-"));
}
