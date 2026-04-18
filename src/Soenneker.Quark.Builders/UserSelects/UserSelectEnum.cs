using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class UserSelectEnum
{
    public static readonly UserSelectEnum None = new("select-none");
    public static readonly UserSelectEnum Auto = new("select-auto");
    public static readonly UserSelectEnum All = new("select-all");
}
