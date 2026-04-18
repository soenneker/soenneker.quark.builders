
namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility. Tailwind: flex-1, flex-auto, flex-initial, flex-none.
/// </summary>
public static class Flex
{
    public sealed class LegacyChain
    {
        private readonly string _classes;

        internal LegacyChain(string classes)
        {
            _classes = classes;
        }

        private LegacyChain Append(string classes)
        {
            if (string.IsNullOrWhiteSpace(_classes))
                return new LegacyChain(classes);

            return new LegacyChain($"{_classes} {classes}");
        }

        public LegacyChain Fill => Append("flex-1");
        public LegacyChain Column => Append("flex-col");
        public LegacyChain AlignCenter => Append("items-center");
        public LegacyChain JustifyCenter => Append("justify-center");
        public LegacyChain Wrap => Append("flex-wrap");
        public LegacyChain Is1 => Append("grow");
        public LegacyChain Is0 => Append("grow-0");

        public static implicit operator CssValue<FlexBuilder>(LegacyChain chain) => chain._classes;
        public override string ToString() => _classes;
    }

    public static FlexBuilder Is1 => new(FlexEnum.Is1);
    public static FlexBuilder Auto => new(FlexEnum.Auto);
    public static FlexBuilder Initial => new(FlexEnum.Initial);
    public static FlexBuilder None => new(FlexEnum.None);
    public static FlexBuilder Token(string value) => new(value);

    // Legacy aliases still used by the suite demo.
    public static LegacyChain Display => new("flex");
    public static LegacyChain Fill => new("flex-1");
    public static LegacyChain Wrap => new("flex-wrap");
    public static LegacyChain Grow => new("");
    public static LegacyChain Column => new("flex-col");
    public static LegacyChain AlignCenter => new("items-center");
}
