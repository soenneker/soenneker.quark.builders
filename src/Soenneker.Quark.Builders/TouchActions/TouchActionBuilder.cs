namespace Soenneker.Quark;

[TailwindPrefix("touch-", Responsive = true)]
public sealed class TouchActionBuilder : FinalClassUtilityBuilder<TouchActionBuilder>
{
    internal TouchActionBuilder() {}
    internal TouchActionBuilder(TouchActionEnum value) : base(value.Value) {}
    internal TouchActionBuilder(string value) : base(value) {}

    public TouchActionBuilder Auto => ChainClass(TouchActionEnum.Auto.Value);
    public TouchActionBuilder None => ChainClass(TouchActionEnum.None.Value);
    public TouchActionBuilder PanX => ChainClass(TouchActionEnum.PanX.Value);
    public TouchActionBuilder PanY => ChainClass(TouchActionEnum.PanY.Value);
    public TouchActionBuilder Manipulation => ChainClass(TouchActionEnum.Manipulation.Value);
    public TouchActionBuilder Token(string value) => ChainClass(value.StartsWith("touch-") ? value : $"touch-{value}");
}
