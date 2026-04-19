using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BorderScaleEnum
{
    public static readonly BorderScaleEnum Is0 = new("0");
    // Tailwind's canonical 1px border width utility is the unsuffixed `border` form.
    public static readonly BorderScaleEnum Is1 = new("");
    public static readonly BorderScaleEnum Is2 = new("2");
    public static readonly BorderScaleEnum Is3 = new("3");
    public static readonly BorderScaleEnum Is4 = new("4");
    public static readonly BorderScaleEnum Is5 = new("5");
}
