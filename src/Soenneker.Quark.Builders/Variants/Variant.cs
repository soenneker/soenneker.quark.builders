namespace Soenneker.Quark;

/// <summary>
/// Represents the variant.
/// </summary>
public static class Variant
{
    /// <summary>
    /// Creates a builder initialized with the supplied class value.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static VariantBuilder Of(ICssBuilder builder) => new(builder);
}
