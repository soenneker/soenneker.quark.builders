namespace Soenneker.Quark;

[TailwindModifiers(typeof(ClearBuilder))]
public static partial class Clear
{
    public static ClearBuilder Start => new(ClearEnum.Start);
    public static ClearBuilder End => new(ClearEnum.End);
    public static ClearBuilder Left => new(ClearEnum.Left);
    public static ClearBuilder Right => new(ClearEnum.Right);
    public static ClearBuilder Both => new(ClearEnum.Both);
    public static ClearBuilder None => new(ClearEnum.None);
    public static ClearBuilder Token(string value) => new(value.StartsWith("clear-") ? value : $"clear-{value}");
}
