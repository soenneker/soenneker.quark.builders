using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class VisibilityEnum
{
    public static readonly VisibilityEnum Visible = new("visible");
    public static readonly VisibilityEnum Invisible = new("invisible");
}
