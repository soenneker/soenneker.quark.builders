using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DecorationLineEnum
{
    public static readonly DecorationLineEnum None = new("no-underline");
    public static readonly DecorationLineEnum Underline = new("underline");
    public static readonly DecorationLineEnum LineThrough = new("line-through");
    public static readonly DecorationLineEnum Overline = new("overline");
}
