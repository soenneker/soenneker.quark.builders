using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the flex wrap enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FlexWrapEnum
{
    /// <summary>
    /// The wrap.
    /// </summary>
    public static readonly FlexWrapEnum Wrap = new("flex-wrap");
    /// <summary>
    /// The wrap reverse.
    /// </summary>
    public static readonly FlexWrapEnum WrapReverse = new("flex-wrap-reverse");
    /// <summary>
    /// The no wrap.
    /// </summary>
    public static readonly FlexWrapEnum NoWrap = new("flex-nowrap");
}
