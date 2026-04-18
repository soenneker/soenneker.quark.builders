using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TransformEnum
{
    public static readonly TransformEnum None = new("none");
    public static readonly TransformEnum Gpu = new("gpu");
    public static readonly TransformEnum Cpu = new("cpu");
}
