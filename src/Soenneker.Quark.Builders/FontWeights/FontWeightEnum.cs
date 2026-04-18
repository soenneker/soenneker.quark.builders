using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FontWeightEnum
{
    public static readonly FontWeightEnum Extralight = new("font-extralight");
    public static readonly FontWeightEnum Light = new("font-light");
    public static readonly FontWeightEnum Normal = new("font-normal");
    public static readonly FontWeightEnum Medium = new("font-medium");
    public static readonly FontWeightEnum Semibold = new("font-semibold");
    public static readonly FontWeightEnum Bold = new("font-bold");
    public static readonly FontWeightEnum Extrabold = new("font-extrabold");
}
