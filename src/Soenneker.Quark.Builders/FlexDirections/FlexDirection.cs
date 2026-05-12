namespace Soenneker.Quark;

[TailwindModifiers(typeof(FlexDirectionBuilder))]
public static partial class FlexDirection
{
    public static FlexDirectionBuilder Row => new(FlexDirectionEnum.Row);
    public static FlexDirectionBuilder RowReverse => new(FlexDirectionEnum.RowReverse);
    public static FlexDirectionBuilder Col => new(FlexDirectionEnum.Col);
    public static FlexDirectionBuilder ColReverse => new(FlexDirectionEnum.ColReverse);
    public static FlexDirectionBuilder Token(string value) => new("flex-" + value);
}
