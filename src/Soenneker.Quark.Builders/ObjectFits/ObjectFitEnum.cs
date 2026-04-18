using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ObjectFitEnum
{
    public static readonly ObjectFitEnum Contain = new("object-contain");
    public static readonly ObjectFitEnum Cover = new("object-cover");
    public static readonly ObjectFitEnum Fill = new("object-fill");
    public static readonly ObjectFitEnum ScaleDown = new("object-scale-down");
    public static readonly ObjectFitEnum None = new("object-none");
}
