using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the fill rule enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FillRuleEnum
{
    /// <summary>
    /// The evenodd.
    /// </summary>
    public static readonly FillRuleEnum Evenodd = new("fill-rule-evenodd");
    /// <summary>
    /// The nonzero.
    /// </summary>
    public static readonly FillRuleEnum Nonzero = new("fill-rule-nonzero");
}
