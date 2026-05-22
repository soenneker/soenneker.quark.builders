namespace Soenneker.Quark;

[TailwindModifiers(typeof(BoxSizingBuilder))]
public static partial class BoxSizing
{
    public static BoxSizingBuilder Border => new(BoxSizingEnum.Border);
    public static BoxSizingBuilder Content => new(BoxSizingEnum.Content);
    public static BoxSizingBuilder Token(string value) => new(value.StartsWith("box-") ? value : $"box-{value}");
}
