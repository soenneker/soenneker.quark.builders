using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class LineClampEnum
{
    public static readonly LineClampEnum None = new("line-clamp-none");
    public static readonly LineClampEnum Is1 = new("line-clamp-1");
    public static readonly LineClampEnum Is2 = new("line-clamp-2");
    public static readonly LineClampEnum Is3 = new("line-clamp-3");
    public static readonly LineClampEnum Is4 = new("line-clamp-4");
    public static readonly LineClampEnum Is5 = new("line-clamp-5");
    public static readonly LineClampEnum Is6 = new("line-clamp-6");
}
