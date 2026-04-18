using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ContainEnum
{
    public static readonly ContainEnum None = new("contain-none");
    public static readonly ContainEnum Size = new("contain-size");
    public static readonly ContainEnum Layout = new("contain-layout");
    public static readonly ContainEnum Style = new("contain-style");
    public static readonly ContainEnum Paint = new("contain-paint");
    public static readonly ContainEnum Strict = new("contain-strict");
    public static readonly ContainEnum Content = new("contain-content");
}
