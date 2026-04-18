using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GapAxisEnum
{
    public static readonly GapAxisEnum All = new("gap-");
    public static readonly GapAxisEnum X = new("gap-x-");
    public static readonly GapAxisEnum Y = new("gap-y-");
}
