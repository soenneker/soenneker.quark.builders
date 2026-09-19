namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for query container declarations.
/// </summary>
[TailwindModifiers(typeof(ContainerTypeBuilder))]
public static partial class ContainerType
{
    /// <summary>Adds <c>@container</c>.</summary>
    public static ContainerTypeBuilder InlineSize => new("@container");

    /// <summary>Adds <c>@container-size</c>.</summary>
    public static ContainerTypeBuilder Size => new("@container-size");

    /// <summary>Adds <c>@container-normal</c>.</summary>
    public static ContainerTypeBuilder Normal => new("@container-normal");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ContainerTypeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, ""));
    /// <summary>Declares a named query container.</summary>
    /// <param name="name">The Tailwind container name.</param>
    /// <returns>A new builder.</returns>
    public static ContainerTypeBuilder InlineSizeNamed(string name) => new("@container/" + name);

    /// <summary>Declares a named query container.</summary>
    /// <param name="name">The Tailwind container name.</param>
    /// <returns>A new builder.</returns>
    public static ContainerTypeBuilder SizeNamed(string name) => new("@container-size/" + name);

}
