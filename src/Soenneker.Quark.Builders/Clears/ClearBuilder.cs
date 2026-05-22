namespace Soenneker.Quark;

[TailwindPrefix("clear-", Responsive = true)]
public sealed class ClearBuilder : FinalClassUtilityBuilder<ClearBuilder>
{
    internal ClearBuilder() {}
    internal ClearBuilder(ClearEnum value) : base(value.Value) {}
    internal ClearBuilder(string value) : base(value) {}

    public ClearBuilder Start => ChainClass(ClearEnum.Start.Value);
    public ClearBuilder End => ChainClass(ClearEnum.End.Value);
    public ClearBuilder Left => ChainClass(ClearEnum.Left.Value);
    public ClearBuilder Right => ChainClass(ClearEnum.Right.Value);
    public ClearBuilder Both => ChainClass(ClearEnum.Both.Value);
    public ClearBuilder None => ChainClass(ClearEnum.None.Value);
    public ClearBuilder Token(string value) => ChainClass(value.StartsWith("clear-") ? value : $"clear-{value}");
}
