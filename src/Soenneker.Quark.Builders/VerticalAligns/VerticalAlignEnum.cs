using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class VerticalAlignEnum
{
    public static readonly VerticalAlignEnum Baseline = new("align-baseline");
    public static readonly VerticalAlignEnum Top = new("align-top");
    public static readonly VerticalAlignEnum Middle = new("align-middle");
    public static readonly VerticalAlignEnum Bottom = new("align-bottom");
    public static readonly VerticalAlignEnum TextTop = new("align-text-top");
    public static readonly VerticalAlignEnum TextBottom = new("align-text-bottom");
}
