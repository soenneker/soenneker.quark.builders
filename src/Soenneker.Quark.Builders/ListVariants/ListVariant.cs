namespace Soenneker.Quark;

/// <summary>
/// Tailwind-aligned list layout variants.
/// </summary>
[TailwindModifiers(typeof(ListVariantBuilder))]
public static partial class ListVariant
{
    /// <summary>
    /// Removes list markers and resets padding (list-none p-0).
    /// </summary>
    public static ListVariantBuilder None => new(ListVariantType.None);

    /// <summary>
    /// Applies a wrapping flex row, centered items, gap-2, no list markers, and zero padding.
    /// </summary>
    public static ListVariantBuilder Inline => new(ListVariantType.Inline);

    /// <summary>
    /// Sets the list item display to inline-block.
    /// </summary>
    public static ListVariantBuilder InlineItem => new(ListVariantType.InlineItem);
}

