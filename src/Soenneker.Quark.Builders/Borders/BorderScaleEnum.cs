using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BorderScaleEnum
{
    public static readonly BorderScaleEnum Is0 = new("border-0");
    // Tailwind's canonical 1px border width utility is the unsuffixed `border` form.
    public static readonly BorderScaleEnum Is1 = new("border");
    public static readonly BorderScaleEnum Is2 = new("border-2");
    public static readonly BorderScaleEnum Is3 = new("border-3");
    public static readonly BorderScaleEnum Is4 = new("border-4");
    public static readonly BorderScaleEnum Is5 = new("border-5");
}
