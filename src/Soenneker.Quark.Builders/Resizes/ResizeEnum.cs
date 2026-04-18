using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ResizeEnum
{
    public static readonly ResizeEnum None = new("resize-none");
    public static readonly ResizeEnum Both = new("resize");
    public static readonly ResizeEnum Horizontal = new("resize-x");
    public static readonly ResizeEnum Vertical = new("resize-y");
}
