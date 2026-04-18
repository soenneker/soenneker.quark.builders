using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class LineClampEnum
{
    public static readonly LineClampEnum None = new("line-clamp-none");
    public static readonly LineClampEnum One = new("line-clamp-1");
    public static readonly LineClampEnum Two = new("line-clamp-2");
    public static readonly LineClampEnum Three = new("line-clamp-3");
    public static readonly LineClampEnum Four = new("line-clamp-4");
    public static readonly LineClampEnum Five = new("line-clamp-5");
    public static readonly LineClampEnum Six = new("line-clamp-6");
}
