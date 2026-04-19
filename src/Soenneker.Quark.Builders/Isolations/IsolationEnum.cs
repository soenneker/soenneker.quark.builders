using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class IsolationEnum
{
    public static readonly IsolationEnum Auto = new("isolation-auto");
    public static readonly IsolationEnum Isolate = new("isolation-isolate");
}
