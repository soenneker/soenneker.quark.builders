using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextWrapEnum
{
    public static readonly TextWrapEnum Wrap = new("text-wrap");
    public static readonly TextWrapEnum Balance = new("text-balance");
    public static readonly TextWrapEnum Pretty = new("text-pretty");
}
