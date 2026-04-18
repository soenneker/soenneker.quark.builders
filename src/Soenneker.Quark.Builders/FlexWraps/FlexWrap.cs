namespace Soenneker.Quark;

public static class FlexWrap
{
    public static FlexWrapBuilder Wrap => new(FlexWrapEnum.Wrap);
    public static FlexWrapBuilder WrapReverse => new(FlexWrapEnum.WrapReverse);
    public static FlexWrapBuilder NoWrap => new(FlexWrapEnum.NoWrap);
    public static FlexWrapBuilder Token(string value) => new(value);
}
