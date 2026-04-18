using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class WhitespaceEnum
{
    public static readonly WhitespaceEnum Normal = new("whitespace-normal");
    public static readonly WhitespaceEnum Nowrap = new("whitespace-nowrap");
    public static readonly WhitespaceEnum Pre = new("whitespace-pre");
    public static readonly WhitespaceEnum PreLine = new("whitespace-pre-line");
    public static readonly WhitespaceEnum PreWrap = new("whitespace-pre-wrap");
    public static readonly WhitespaceEnum BreakSpaces = new("whitespace-break-spaces");
}
