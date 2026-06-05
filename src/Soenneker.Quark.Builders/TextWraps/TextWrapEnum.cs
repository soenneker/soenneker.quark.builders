using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text wrap enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextWrapEnum
{
    /// <summary>
    /// The wrap.
    /// </summary>
    public static readonly TextWrapEnum Wrap = new("text-wrap");
    /// <summary>
    /// The balance.
    /// </summary>
    public static readonly TextWrapEnum Balance = new("text-balance");
    /// <summary>
    /// The pretty.
    /// </summary>
    public static readonly TextWrapEnum Pretty = new("text-pretty");
}
