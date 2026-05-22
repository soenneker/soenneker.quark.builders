using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OverflowWrapEnum
{
    public static readonly OverflowWrapEnum Normal = new("wrap-normal");
    public static readonly OverflowWrapEnum Anywhere = new("wrap-anywhere");
    public static readonly OverflowWrapEnum BreakWord = new("wrap-break-word");
}
