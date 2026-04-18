using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FillRuleEnum
{
    public static readonly FillRuleEnum Evenodd = new("fill-rule-evenodd");
    public static readonly FillRuleEnum Nonzero = new("fill-rule-nonzero");
}
