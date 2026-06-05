namespace Soenneker.Quark;

/// <summary>
/// Represents the variant.
/// </summary>
public static class Variant
{
    /// <summary>
    /// Executes the of operation.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <returns>The result of the operation.</returns>
    public static VariantBuilder Of(ICssBuilder builder) => new(builder);
}
