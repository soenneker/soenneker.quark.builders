namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for inset ring width.
/// </summary>
[TailwindModifiers(typeof(InsetRingBuilder))]
public static partial class InsetRing
{
    /// <summary>Adds <c>inset-ring-0</c>.</summary>
    public static InsetRingBuilder Is0 => new("inset-ring-0");

    /// <summary>Adds <c>inset-ring-1</c>.</summary>
    public static InsetRingBuilder Is1 => new("inset-ring-1");

    /// <summary>Adds <c>inset-ring-2</c>.</summary>
    public static InsetRingBuilder Is2 => new("inset-ring-2");

    /// <summary>Adds <c>inset-ring-4</c>.</summary>
    public static InsetRingBuilder Is4 => new("inset-ring-4");

    /// <summary>Adds <c>inset-ring-8</c>.</summary>
    public static InsetRingBuilder Is8 => new("inset-ring-8");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetRingBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "inset-ring-"));
}
