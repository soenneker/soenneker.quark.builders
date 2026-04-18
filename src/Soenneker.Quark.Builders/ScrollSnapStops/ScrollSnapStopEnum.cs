using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScrollSnapStopEnum
{
    public static readonly ScrollSnapStopEnum Normal = new("snap-stop-normal");
    public static readonly ScrollSnapStopEnum Always = new("snap-stop-always");
}
