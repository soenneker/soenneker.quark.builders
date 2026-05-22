using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ClearEnum
{
    public static readonly ClearEnum Start = new("clear-start");
    public static readonly ClearEnum End = new("clear-end");
    public static readonly ClearEnum Left = new("clear-left");
    public static readonly ClearEnum Right = new("clear-right");
    public static readonly ClearEnum Both = new("clear-both");
    public static readonly ClearEnum None = new("clear-none");
}
