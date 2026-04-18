namespace Soenneker.Quark;

public static class Variant
{
    public static VariantBuilder Of(ICssBuilder builder) => new(builder);
}
