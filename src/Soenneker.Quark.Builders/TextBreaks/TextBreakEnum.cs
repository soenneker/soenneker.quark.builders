using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextBreakEnum
{
    public static readonly TextBreakEnum Normal = new("break-normal");
    public static readonly TextBreakEnum Words = new("break-words");
    public static readonly TextBreakEnum All = new("break-all");
    public static readonly TextBreakEnum Keep = new("break-keep");
}
